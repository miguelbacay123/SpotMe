using System;
using System.Collections.Generic;
using GymClassBooking.SpotMe.Models;
using Microsoft.Data.SqlClient;

namespace GymClassBooking.SpotMe.Controllers
{
    public class TrainerController
    {
        public List<Trainer> GetAllTrainers()
        {
            List<Trainer> trainers = new List<Trainer>();

            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string sql = "SELECT Id, Name, Email, Phone, Specialization, Biography, PhotoPath, HireDate, IsActive FROM Trainers ORDER BY Name";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                trainers.Add(new Trainer
                                {
                                    Id = reader.GetInt32(0),
                                    Name = reader.GetString(1),
                                    Email = reader.GetString(2),
                                    Phone = reader.IsDBNull(3) ? null : reader.GetString(3),
                                    Specialization = reader.IsDBNull(4) ? null : reader.GetString(4),
                                    Biography = reader.IsDBNull(5) ? null : reader.GetString(5),
                                    PhotoPath = reader.IsDBNull(6) ? null : reader.GetString(6),
                                    HireDate = reader.GetDateTime(7),
                                    IsActive = reader.GetBoolean(8)
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error loading trainers: " + ex.Message, "Database Error",
                               System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }

            return trainers;
        }

        public Trainer GetTrainerById(int id)
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string sql = "SELECT Id, Name, Email, Phone, Specialization, Biography, PhotoPath, HireDate, IsActive FROM Trainers WHERE Id = @Id";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", id);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new Trainer
                                {
                                    Id = reader.GetInt32(0),
                                    Name = reader.GetString(1),
                                    Email = reader.GetString(2),
                                    Phone = reader.IsDBNull(3) ? null : reader.GetString(3),
                                    Specialization = reader.IsDBNull(4) ? null : reader.GetString(4),
                                    Biography = reader.IsDBNull(5) ? null : reader.GetString(5),
                                    PhotoPath = reader.IsDBNull(6) ? null : reader.GetString(6),
                                    HireDate = reader.GetDateTime(7),
                                    IsActive = reader.GetBoolean(8)
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error getting trainer: " + ex.Message, "Error",
                               System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            return null;
        }

        public void AddTrainer(Trainer trainer)
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string sql = @"INSERT INTO Trainers (Name, Email, Phone, Specialization, Biography, PhotoPath, HireDate, IsActive) 
                                   VALUES (@Name, @Email, @Phone, @Specialization, @Biography, @PhotoPath, @HireDate, @IsActive)";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", trainer.Name);
                        cmd.Parameters.AddWithValue("@Email", trainer.Email);
                        cmd.Parameters.AddWithValue("@Phone", (object)trainer.Phone ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@Specialization", (object)trainer.Specialization ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@Biography", (object)trainer.Biography ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@PhotoPath", (object)trainer.PhotoPath ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@HireDate", trainer.HireDate == DateTime.MinValue ? DateTime.Now : trainer.HireDate);
                        cmd.Parameters.AddWithValue("@IsActive", trainer.IsActive);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error adding trainer: " + ex.Message, "Error",
                               System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        public void UpdateTrainer(Trainer trainer)
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string sql = @"UPDATE Trainers SET 
                                   Name = @Name, 
                                   Email = @Email, 
                                   Phone = @Phone, 
                                   Specialization = @Specialization, 
                                   Biography = @Biography, 
                                   PhotoPath = @PhotoPath,
                                   IsActive = @IsActive
                                   WHERE Id = @Id";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", trainer.Id);
                        cmd.Parameters.AddWithValue("@Name", trainer.Name);
                        cmd.Parameters.AddWithValue("@Email", trainer.Email);
                        cmd.Parameters.AddWithValue("@Phone", (object)trainer.Phone ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@Specialization", (object)trainer.Specialization ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@Biography", (object)trainer.Biography ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@PhotoPath", (object)trainer.PhotoPath ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@IsActive", trainer.IsActive);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error updating trainer: " + ex.Message, "Error",
                               System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        public void DeleteTrainer(int id)
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    // Soft delete - just mark as inactive
                    string sql = "UPDATE Trainers SET IsActive = 0 WHERE Id = @Id";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", id);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error deleting trainer: " + ex.Message, "Error",
                               System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }
    }
}