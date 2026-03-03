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

                // Create a unique filename
                string extension = Path.GetExtension(sourcePath);
                string fileName = $"{memberName.Replace(" ", "_")}_{DateTime.Now:yyyyMMddHHmmss}{extension}";

                // Get photos folder
                string photosFolder = GetPhotosFolder();
                string destPath = Path.Combine(photosFolder, fileName);

                // Copy the file
                File.Copy(sourcePath, destPath, true);

                return destPath;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving photo: {ex.Message}", "Photo Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return sourcePath; // Return original path if copy fails
            }
        }

        public List<Member> GetAllMembers()
        {
            List<Member> members = new List<Member>();

            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string sql = "SELECT Id, Name, Email, Phone, Gender, PhotoPath, DateJoined, IsActive FROM Members WHERE IsActive = 1 ORDER BY Name";

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
                                    PhotoPath = reader.IsDBNull(5) ? null : reader.GetString(5),
                                    DateJoined = reader.GetDateTime(6),
                                    IsActive = reader.GetBoolean(7)
                                };

                                // Load photo if PhotoPath exists
                                if (!string.IsNullOrEmpty(member.PhotoPath) && File.Exists(member.PhotoPath))
                                {
                                    try
                                    {
                                        using (FileStream fs = new FileStream(member.PhotoPath, FileMode.Open, FileAccess.Read))
                                        {
                                            member.Photo = Image.FromStream(fs);
                                        }
                                    }
                                    catch
                                    {
                                        // If image can't be loaded, leave as null
                                        member.Photo = null;
                                    }
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
                // Save photo to app folder if exists
                if (!string.IsNullOrEmpty(member.PhotoPath) && File.Exists(member.PhotoPath))
                {
                    member.PhotoPath = SavePhotoToAppFolder(member.PhotoPath, member.Name);
                }

                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string sql = @"INSERT INTO Members (Name, Email, Phone, Gender, PhotoPath, DateJoined, IsActive) 
                                   VALUES (@Name, @Email, @Phone, @Gender, @PhotoPath, @DateJoined, @IsActive)";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", member.Name);
                        cmd.Parameters.AddWithValue("@Email", member.Email);
                        cmd.Parameters.AddWithValue("@Phone", (object)member.Phone ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@Gender", (object)member.Gender ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@PhotoPath", (object)member.PhotoPath ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@DateJoined", DateTime.Now);
                        cmd.Parameters.AddWithValue("@IsActive", true);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show($"Member {member.Name} added successfully!", "Success",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627) // Unique constraint violation
                {
                    MessageBox.Show("A member with this email already exists.", "Duplicate Email",
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
                // Save new photo if provided
                if (!string.IsNullOrEmpty(member.PhotoPath) && File.Exists(member.PhotoPath) &&
                    !member.PhotoPath.Contains("MemberPhotos"))
                {
                    member.PhotoPath = SavePhotoToAppFolder(member.PhotoPath, member.Name);
                }

                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string sql = @"UPDATE Members SET 
                                   Name = @Name, 
                                   Email = @Email, 
                                   Phone = @Phone, 
                                   Gender = @Gender, 
                                   PhotoPath = @PhotoPath,
                                   IsActive = @IsActive
                                   WHERE Id = @Id";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", member.Id);
                        cmd.Parameters.AddWithValue("@Name", member.Name);
                        cmd.Parameters.AddWithValue("@Email", member.Email);
                        cmd.Parameters.AddWithValue("@Phone", (object)member.Phone ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@Gender", (object)member.Gender ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@PhotoPath", (object)member.PhotoPath ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@IsActive", member.IsActive);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show($"Member {member.Name} updated successfully!", "Success",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                // Get member info first to delete photo
                Member member = GetMemberById(memberId);

                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    // Soft delete - just mark as inactive
                    string sql = "UPDATE Members SET IsActive = 0 WHERE Id = @Id";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", memberId);
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
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
                    string sql = "SELECT Id, Name, Email, Phone, Gender, PhotoPath, DateJoined, IsActive FROM Members WHERE Id = @Id";

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
                                    PhotoPath = reader.IsDBNull(5) ? null : reader.GetString(5),
                                    DateJoined = reader.GetDateTime(6),
                                    IsActive = reader.GetBoolean(7)
                                };

                                // Load photo if exists
                                if (!string.IsNullOrEmpty(member.PhotoPath) && File.Exists(member.PhotoPath))
                                {
                                    try
                                    {
                                        using (FileStream fs = new FileStream(member.PhotoPath, FileMode.Open, FileAccess.Read))
                                        {
                                            member.Photo = Image.FromStream(fs);
                                        }
                                    }
                                    catch
                                    {
                                        member.Photo = null;
                                    }
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

        // Method to get all members including inactive ones (for admin purposes)
        public List<Member> GetAllMembersIncludingInactive()
        {
            List<Member> members = new List<Member>();

            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string sql = "SELECT Id, Name, Email, Phone, Gender, PhotoPath, DateJoined, IsActive FROM Members ORDER BY Name";

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
                                    PhotoPath = reader.IsDBNull(5) ? null : reader.GetString(5),
                                    DateJoined = reader.GetDateTime(6),
                                    IsActive = reader.GetBoolean(7)
                                };

                                // Load photo if exists
                                if (!string.IsNullOrEmpty(member.PhotoPath) && File.Exists(member.PhotoPath))
                                {
                                    try
                                    {
                                        using (FileStream fs = new FileStream(member.PhotoPath, FileMode.Open, FileAccess.Read))
                                        {
                                            member.Photo = Image.FromStream(fs);
                                        }
                                    }
                                    catch
                                    {
                                        member.Photo = null;
                                    }
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

        // Method to delete photo file when member is permanently deleted
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