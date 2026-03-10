using System;
using System.Collections.Generic;
using GymClassBooking.SpotMe.Models;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Linq;

namespace GymClassBooking.SpotMe.Controllers
{
    public class TrainerController
    {
        private ActivityLogController activityLog = new ActivityLogController();

        private string GetPhotosFolder()
        {
            string appFolder = Path.GetDirectoryName(Application.ExecutablePath);
            string photosFolder = Path.Combine(appFolder, "TrainerPhotos");

            if (!Directory.Exists(photosFolder))
            {
                Directory.CreateDirectory(photosFolder);
            }

            return photosFolder;
        }

        private string SavePhotoToAppFolder(string sourcePath, string trainerName)
        {
            try
            {
                if (string.IsNullOrEmpty(sourcePath) || !File.Exists(sourcePath))
                    return null;

                string extension = Path.GetExtension(sourcePath);
                string fileName = $"{trainerName.Replace(" ", "_")}_{DateTime.Now:yyyyMMddHHmmss}{extension}";
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

        private string SerializeSpecializations(List<string> specializations)
        {
            return specializations != null ? string.Join(",", specializations) : "";
        }

        private List<string> DeserializeSpecializations(string specString)
        {
            if (string.IsNullOrEmpty(specString))
                return new List<string>();
            return specString.Split(',').ToList();
        }

        public List<Trainer> GetAllTrainers()
        {
            List<Trainer> trainers = new List<Trainer>();

            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string sql = "SELECT Id, Name, Email, Phone, DateOfBirth, Gender, Address, Specializations, PhotoPath, HireDate, IsActive FROM Trainers WHERE IsActive = 1 ORDER BY Name";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Trainer trainer = new Trainer
                                {
                                    Id = reader.GetInt32(0),
                                    Name = reader.GetString(1),
                                    Email = reader.GetString(2),
                                    Phone = reader.IsDBNull(3) ? null : reader.GetString(3),
                                    DateOfBirth = reader.IsDBNull(4) ? null : (DateTime?)reader.GetDateTime(4),
                                    Gender = reader.IsDBNull(5) ? null : reader.GetString(5),
                                    Address = reader.IsDBNull(6) ? null : reader.GetString(6),
                                    Specializations = DeserializeSpecializations(reader.IsDBNull(7) ? null : reader.GetString(7)),
                                    PhotoPath = reader.IsDBNull(8) ? null : reader.GetString(8),
                                    HireDate = reader.GetDateTime(9),
                                    IsActive = reader.GetBoolean(10)
                                };

                                if (!string.IsNullOrEmpty(trainer.PhotoPath) && File.Exists(trainer.PhotoPath))
                                {
                                    try
                                    {
                                        using (FileStream fs = new FileStream(trainer.PhotoPath, FileMode.Open, FileAccess.Read))
                                        {
                                            trainer.Photo = Image.FromStream(fs);
                                        }
                                    }
                                    catch { }
                                }

                                trainers.Add(trainer);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading trainers: " + ex.Message, "Database Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return trainers;
        }

        public void AddTrainer(Trainer trainer)
        {
            try
            {
                if (!string.IsNullOrEmpty(trainer.PhotoPath) && File.Exists(trainer.PhotoPath))
                {
                    trainer.PhotoPath = SavePhotoToAppFolder(trainer.PhotoPath, trainer.Name);
                }

                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string sql = @"INSERT INTO Trainers (Name, Email, Phone, DateOfBirth, Gender, Address, Specializations, PhotoPath, HireDate, IsActive) 
                                   VALUES (@Name, @Email, @Phone, @DateOfBirth, @Gender, @Address, @Specializations, @PhotoPath, @HireDate, @IsActive)";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", trainer.Name);
                        cmd.Parameters.AddWithValue("@Email", trainer.Email);
                        cmd.Parameters.AddWithValue("@Phone", (object)trainer.Phone ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@DateOfBirth", (object)trainer.DateOfBirth ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@Gender", (object)trainer.Gender ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@Address", (object)trainer.Address ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@Specializations", SerializeSpecializations(trainer.Specializations));
                        cmd.Parameters.AddWithValue("@PhotoPath", (object)trainer.PhotoPath ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@HireDate", DateTime.Now);
                        cmd.Parameters.AddWithValue("@IsActive", true);

                        cmd.ExecuteNonQuery();
                    }
                }

                activityLog.AddActivityLog(new ActivityLog
                {
                    Action = "Trainer Added",
                    Description = $"{trainer.Name} added as new trainer",
                    Category = "Trainer",
                    Icon = "●"
                });

                MessageBox.Show($"Trainer {trainer.Name} added successfully!", "Success",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627)
                {
                    MessageBox.Show("A trainer with this email already exists.", "Duplicate Email",
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
                MessageBox.Show("Error adding trainer: " + ex.Message, "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void UpdateTrainer(Trainer trainer)
        {
            try
            {
                if (!string.IsNullOrEmpty(trainer.PhotoPath) && File.Exists(trainer.PhotoPath) &&
                    !trainer.PhotoPath.Contains("TrainerPhotos"))
                {
                    trainer.PhotoPath = SavePhotoToAppFolder(trainer.PhotoPath, trainer.Name);
                }

                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    string checkSql = "SELECT COUNT(*) FROM Trainers WHERE Id = @Id";
                    using (SqlCommand checkCmd = new SqlCommand(checkSql, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@Id", trainer.Id);
                        int exists = (int)checkCmd.ExecuteScalar();

                        if (exists == 0)
                        {
                            MessageBox.Show($"Trainer with ID {trainer.Id} not found in database!",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    string sql = @"UPDATE Trainers SET 
                                   Name = @Name, 
                                   Email = @Email, 
                                   Phone = @Phone,
                                   DateOfBirth = @DateOfBirth,
                                   Gender = @Gender,
                                   Address = @Address,
                                   Specializations = @Specializations,
                                   PhotoPath = @PhotoPath,
                                   IsActive = 1
                                   WHERE Id = @Id";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", trainer.Id);
                        cmd.Parameters.AddWithValue("@Name", trainer.Name);
                        cmd.Parameters.AddWithValue("@Email", trainer.Email);
                        cmd.Parameters.AddWithValue("@Phone", (object)trainer.Phone ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@DateOfBirth", (object)trainer.DateOfBirth ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@Gender", (object)trainer.Gender ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@Address", (object)trainer.Address ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@Specializations", SerializeSpecializations(trainer.Specializations));
                        cmd.Parameters.AddWithValue("@PhotoPath", (object)trainer.PhotoPath ?? DBNull.Value);

                        cmd.ExecuteNonQuery();
                    }
                }

                activityLog.AddActivityLog(new ActivityLog
                {
                    Action = "Trainer Updated",
                    Description = $"{trainer.Name} profile updated",
                    Category = "Trainer",
                    Icon = "●"
                });

                MessageBox.Show($"Trainer {trainer.Name} updated successfully!", "Success",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating trainer: " + ex.Message, "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void DeleteTrainer(int trainerId)
        {
            try
            {
                Trainer trainer = GetTrainerById(trainerId);
                string trainerName = trainer?.Name ?? "Unknown";

                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string sql = "UPDATE Trainers SET IsActive = 0 WHERE Id = @Id";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", trainerId);
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            activityLog.AddActivityLog(new ActivityLog
                            {
                                Action = "Trainer Deleted",
                                Description = $"{trainerName} removed from system",
                                Category = "Trainer",
                                Icon = "●"
                            });

                            MessageBox.Show("Trainer deleted successfully!", "Deleted",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Trainer not found.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting trainer: " + ex.Message, "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public Trainer GetTrainerById(int id)
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string sql = "SELECT Id, Name, Email, Phone, DateOfBirth, Gender, Address, Specializations, PhotoPath, HireDate, IsActive FROM Trainers WHERE Id = @Id";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", id);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Trainer trainer = new Trainer
                                {
                                    Id = reader.GetInt32(0),
                                    Name = reader.GetString(1),
                                    Email = reader.GetString(2),
                                    Phone = reader.IsDBNull(3) ? null : reader.GetString(3),
                                    DateOfBirth = reader.IsDBNull(4) ? null : (DateTime?)reader.GetDateTime(4),
                                    Gender = reader.IsDBNull(5) ? null : reader.GetString(5),
                                    Address = reader.IsDBNull(6) ? null : reader.GetString(6),
                                    Specializations = DeserializeSpecializations(reader.IsDBNull(7) ? null : reader.GetString(7)),
                                    PhotoPath = reader.IsDBNull(8) ? null : reader.GetString(8),
                                    HireDate = reader.GetDateTime(9),
                                    IsActive = reader.GetBoolean(10)
                                };

                                if (!string.IsNullOrEmpty(trainer.PhotoPath) && File.Exists(trainer.PhotoPath))
                                {
                                    try
                                    {
                                        using (FileStream fs = new FileStream(trainer.PhotoPath, FileMode.Open, FileAccess.Read))
                                        {
                                            trainer.Photo = Image.FromStream(fs);
                                        }
                                    }
                                    catch { }
                                }

                                return trainer;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error getting trainer: " + ex.Message, "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }
    }
}