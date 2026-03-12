using System;
using System.Collections.Generic;
using GymClassBooking.SpotMe.Models;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace GymClassBooking.SpotMe.Controllers
{
    public class MemberController
    {
        private ActivityLogController activityLog = new ActivityLogController();

        private string GetPhotosFolder()
        {
            string appFolder = Path.GetDirectoryName(Application.ExecutablePath);
            string photosFolder = Path.Combine(appFolder, "MemberPhotos");

            if (!Directory.Exists(photosFolder))
            {
                Directory.CreateDirectory(photosFolder);
            }

            return photosFolder;
        }

        private string SavePhotoToAppFolder(string sourcePath, string memberName)
        {
            try
            {
                if (string.IsNullOrEmpty(sourcePath) || !File.Exists(sourcePath))
                    return null;

                string extension = Path.GetExtension(sourcePath);
                string fileName = $"{memberName.Replace(" ", "_")}_{DateTime.Now:yyyyMMddHHmmss}{extension}";
                string photosFolder = GetPhotosFolder();
                string destPath = Path.Combine(photosFolder, fileName);

                File.Copy(sourcePath, destPath, true);
                return destPath;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving photo: {ex.Message}", "Photo Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return sourcePath;
            }
        }

        private bool TryReactivateMember(string email, Member newMember)
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    string checkSql = "SELECT Id FROM Members WHERE Email = @Email AND IsActive = 0";
                    using (SqlCommand checkCmd = new SqlCommand(checkSql, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@Email", email);
                        object result = checkCmd.ExecuteScalar();

                        if (result != null)
                        {
                            int existingId = (int)result;

                            string photoPath = newMember.PhotoPath;
                            if (!string.IsNullOrEmpty(photoPath) && File.Exists(photoPath))
                            {
                                photoPath = SavePhotoToAppFolder(photoPath, newMember.Name);
                            }

                            string updateSql = @"UPDATE Members SET 
                                                Name = @Name,
                                                Phone = @Phone,
                                                Gender = @Gender,
                                                FitnessGoal = @FitnessGoal,
                                                PhotoPath = @PhotoPath,
                                                DateJoined = @DateJoined,
                                                IsActive = 1
                                                WHERE Id = @Id";

                            using (SqlCommand updateCmd = new SqlCommand(updateSql, conn))
                            {
                                updateCmd.Parameters.AddWithValue("@Id", existingId);
                                updateCmd.Parameters.AddWithValue("@Name", newMember.Name);
                                updateCmd.Parameters.AddWithValue("@Phone", (object)newMember.Phone ?? DBNull.Value);
                                updateCmd.Parameters.AddWithValue("@Gender", (object)newMember.Gender ?? DBNull.Value);
                                updateCmd.Parameters.AddWithValue("@FitnessGoal", (object)newMember.FitnessGoal ?? DBNull.Value);
                                updateCmd.Parameters.AddWithValue("@PhotoPath", (object)photoPath ?? DBNull.Value);
                                updateCmd.Parameters.AddWithValue("@DateJoined", DateTime.Now);

                                updateCmd.ExecuteNonQuery();
                            }

                            activityLog.AddActivityLog(new ActivityLog
                            {
                                Action = "Member Reactivated",
                                Description = $"{newMember.Name} membership reactivated",
                                Category = "Member",
                                Icon = "●"
                            });

                            MessageBox.Show($"Member {newMember.Name} reactivated successfully!", "Success",
                                           MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reactivating member: " + ex.Message, "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        public List<Member> GetAllMembers()
        {
            List<Member> members = new List<Member>();

            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string sql = "SELECT Id, Name, Email, Phone, Gender, FitnessGoal, PhotoPath, DateJoined, IsActive FROM Members WHERE IsActive = 1 ORDER BY Name";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Member member = new Member
                                {
                                    Id = reader.GetInt32(0),
                                    Name = reader.GetString(1),
                                    Email = reader.GetString(2),
                                    Phone = reader.IsDBNull(3) ? null : reader.GetString(3),
                                    Gender = reader.IsDBNull(4) ? null : reader.GetString(4),
                                    FitnessGoal = reader.IsDBNull(5) ? null : reader.GetString(5),
                                    PhotoPath = reader.IsDBNull(6) ? null : reader.GetString(6),
                                    DateJoined = reader.IsDBNull(7) ? DateTime.Now : reader.GetDateTime(7),
                                    IsActive = reader.IsDBNull(8) ? true : reader.GetBoolean(8)
                                };

                                if (!string.IsNullOrEmpty(member.PhotoPath) && File.Exists(member.PhotoPath))
                                {
                                    try
                                    {
                                        using (FileStream fs = new FileStream(member.PhotoPath, FileMode.Open, FileAccess.Read))
                                        {
                                            member.Photo = Image.FromStream(fs);
                                        }
                                    }
                                    catch { }
                                }

                                members.Add(member);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading members: " + ex.Message, "Database Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return members;
        }

        public void AddMember(Member member)
        {
            try
            {
                if (TryReactivateMember(member.Email, member))
                {
                    return;
                }

                if (!string.IsNullOrEmpty(member.PhotoPath) && File.Exists(member.PhotoPath))
                {
                    member.PhotoPath = SavePhotoToAppFolder(member.PhotoPath, member.Name);
                }

                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string sql = @"INSERT INTO Members (Name, Email, Phone, Gender, FitnessGoal, PhotoPath, DateJoined, IsActive) 
                                   VALUES (@Name, @Email, @Phone, @Gender, @FitnessGoal, @PhotoPath, @DateJoined, @IsActive)";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", member.Name);
                        cmd.Parameters.AddWithValue("@Email", member.Email);
                        cmd.Parameters.AddWithValue("@Phone", (object)member.Phone ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@Gender", (object)member.Gender ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@FitnessGoal", (object)member.FitnessGoal ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@PhotoPath", (object)member.PhotoPath ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@DateJoined", DateTime.Now);
                        cmd.Parameters.AddWithValue("@IsActive", true);

                        cmd.ExecuteNonQuery();
                    }
                }

                activityLog.AddActivityLog(new ActivityLog
                {
                    Action = "New Member Created",
                    Description = $"{member.Name} registered for membership",
                    Category = "Member",
                    Icon = "●"
                });

                MessageBox.Show($"Member {member.Name} added successfully!", "Success",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627)
                {
                    MessageBox.Show("A member with this email already exists and is active.", "Duplicate Email",
                                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Database error: " + ex.Message, "Error",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding member: " + ex.Message, "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void UpdateMember(Member member)
        {
            try
            {
                if (!string.IsNullOrEmpty(member.PhotoPath) && File.Exists(member.PhotoPath) &&
                    !member.PhotoPath.Contains("MemberPhotos"))
                {
                    member.PhotoPath = SavePhotoToAppFolder(member.PhotoPath, member.Name);
                }

                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    string checkSql = "SELECT COUNT(*) FROM Members WHERE Id = @Id";
                    using (SqlCommand checkCmd = new SqlCommand(checkSql, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@Id", member.Id);
                        int exists = (int)checkCmd.ExecuteScalar();

                        if (exists == 0)
                        {
                            MessageBox.Show($"Member with ID {member.Id} not found in database!",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    string sql = @"UPDATE Members SET 
                                   Name = @Name, 
                                   Email = @Email, 
                                   Phone = @Phone, 
                                   Gender = @Gender,
                                   FitnessGoal = @FitnessGoal,
                                   PhotoPath = @PhotoPath,
                                   IsActive = 1
                                   WHERE Id = @Id";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", member.Id);
                        cmd.Parameters.AddWithValue("@Name", member.Name);
                        cmd.Parameters.AddWithValue("@Email", member.Email);
                        cmd.Parameters.AddWithValue("@Phone", (object)member.Phone ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@Gender", (object)member.Gender ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@FitnessGoal", (object)member.FitnessGoal ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@PhotoPath", (object)member.PhotoPath ?? DBNull.Value);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            activityLog.AddActivityLog(new ActivityLog
                            {
                                Action = "Member Updated",
                                Description = $"{member.Name} profile updated",
                                Category = "Member",
                                Icon = "●"
                            });

                            MessageBox.Show($"Member {member.Name} updated successfully!", "Success",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No rows were updated. Member ID may not exist.",
                                "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating member: " + ex.Message, "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void DeleteMember(int memberId)
        {
            try
            {
                Member member = GetMemberById(memberId);
                string memberName = member?.Name ?? "Unknown";

                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string sql = "UPDATE Members SET IsActive = 0 WHERE Id = @Id";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", memberId);
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            activityLog.AddActivityLog(new ActivityLog
                            {
                                Action = "Member Deleted",
                                Description = $"{memberName} membership deleted",
                                Category = "Member",
                                Icon = "●"
                            });

                            MessageBox.Show("Member deleted successfully!", "Deleted",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Member not found.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting member: " + ex.Message, "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public Member GetMemberById(int id)
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string sql = "SELECT Id, Name, Email, Phone, Gender, FitnessGoal, PhotoPath, DateJoined, IsActive FROM Members WHERE Id = @Id";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", id);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Member member = new Member
                                {
                                    Id = reader.GetInt32(0),
                                    Name = reader.GetString(1),
                                    Email = reader.GetString(2),
                                    Phone = reader.IsDBNull(3) ? null : reader.GetString(3),
                                    Gender = reader.IsDBNull(4) ? null : reader.GetString(4),
                                    FitnessGoal = reader.IsDBNull(5) ? null : reader.GetString(5),
                                    PhotoPath = reader.IsDBNull(6) ? null : reader.GetString(6),
                                    DateJoined = reader.IsDBNull(7) ? DateTime.Now : reader.GetDateTime(7),
                                    IsActive = reader.IsDBNull(8) ? true : reader.GetBoolean(8)
                                };

                                if (!string.IsNullOrEmpty(member.PhotoPath) && File.Exists(member.PhotoPath))
                                {
                                    try
                                    {
                                        using (FileStream fs = new FileStream(member.PhotoPath, FileMode.Open, FileAccess.Read))
                                        {
                                            member.Photo = Image.FromStream(fs);
                                        }
                                    }
                                    catch { }
                                }

                                return member;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error getting member: " + ex.Message, "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }

        public List<Member> GetAllMembersIncludingInactive()
        {
            List<Member> members = new List<Member>();

            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string sql = "SELECT Id, Name, Email, Phone, Gender, FitnessGoal, PhotoPath, DateJoined, IsActive FROM Members ORDER BY IsActive DESC, Name";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Member member = new Member
                                {
                                    Id = reader.GetInt32(0),
                                    Name = reader.GetString(1),
                                    Email = reader.GetString(2),
                                    Phone = reader.IsDBNull(3) ? null : reader.GetString(3),
                                    Gender = reader.IsDBNull(4) ? null : reader.GetString(4),
                                    FitnessGoal = reader.IsDBNull(5) ? null : reader.GetString(5),
                                    PhotoPath = reader.IsDBNull(6) ? null : reader.GetString(6),
                                    DateJoined = reader.IsDBNull(7) ? DateTime.Now : reader.GetDateTime(7),
                                    IsActive = reader.IsDBNull(8) ? true : reader.GetBoolean(8)
                                };

                                if (!string.IsNullOrEmpty(member.PhotoPath) && File.Exists(member.PhotoPath))
                                {
                                    try
                                    {
                                        using (FileStream fs = new FileStream(member.PhotoPath, FileMode.Open, FileAccess.Read))
                                        {
                                            member.Photo = Image.FromStream(fs);
                                        }
                                    }
                                    catch { }
                                }

                                members.Add(member);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading members: " + ex.Message, "Database Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return members;
        }

        private void DeletePhotoFile(string photoPath)
        {
            try
            {
                if (!string.IsNullOrEmpty(photoPath) && File.Exists(photoPath))
                {
                    File.Delete(photoPath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting photo file: {ex.Message}", "Warning",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}