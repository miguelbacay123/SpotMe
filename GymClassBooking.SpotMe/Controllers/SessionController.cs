using System;
using System.Collections.Generic;
using GymClassBooking.SpotMe.Models;
using Microsoft.Data.SqlClient;

namespace GymClassBooking.SpotMe.Controllers
{
    public class SessionController
    {
        public List<Session> GetAllSessions()
        {
            List<Session> sessions = new List<Session>();

            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string sql = @"SELECT s.Id, s.Name, s.Description, s.TrainerId, t.Name as TrainerName, 
                                          s.StartTime, s.EndTime, s.Location, s.Capacity, s.BookedCount, 
                                          s.Difficulty, s.Price, s.IsActive 
                                   FROM Sessions s
                                   LEFT JOIN Trainers t ON s.TrainerId = t.Id
                                   WHERE s.StartTime >= @Today
                                   ORDER BY s.StartTime";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Today", DateTime.Today);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                sessions.Add(new Session
                                {
                                    Id = reader.GetInt32(0),
                                    Name = reader.GetString(1),
                                    Description = reader.IsDBNull(2) ? null : reader.GetString(2),
                                    TrainerId = reader.GetInt32(3),
                                    TrainerName = reader.IsDBNull(4) ? "Unassigned" : reader.GetString(4),
                                    StartTime = reader.GetDateTime(5),
                                    EndTime = reader.GetDateTime(6),
                                    Location = reader.IsDBNull(7) ? null : reader.GetString(7),
                                    Capacity = reader.GetInt32(8),
                                    BookedCount = reader.GetInt32(9),
                                    Difficulty = reader.IsDBNull(10) ? null : reader.GetString(10),
                                    Price = reader.GetDecimal(11),
                                    IsActive = reader.GetBoolean(12)
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error loading sessions: " + ex.Message, "Database Error",
                               System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }

            return sessions;
        }

        public List<Session> GetSessionsByDate(DateTime date)
        {
            List<Session> sessions = new List<Session>();

            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string sql = @"SELECT s.Id, s.Name, s.Description, s.TrainerId, t.Name as TrainerName, 
                                          s.StartTime, s.EndTime, s.Location, s.Capacity, s.BookedCount, 
                                          s.Difficulty, s.Price, s.IsActive 
                                   FROM Sessions s
                                   LEFT JOIN Trainers t ON s.TrainerId = t.Id
                                   WHERE CAST(s.StartTime AS DATE) = @Date AND s.IsActive = 1
                                   ORDER BY s.StartTime";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Date", date.Date);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                sessions.Add(new Session
                                {
                                    Id = reader.GetInt32(0),
                                    Name = reader.GetString(1),
                                    Description = reader.IsDBNull(2) ? null : reader.GetString(2),
                                    TrainerId = reader.GetInt32(3),
                                    TrainerName = reader.IsDBNull(4) ? "Unassigned" : reader.GetString(4),
                                    StartTime = reader.GetDateTime(5),
                                    EndTime = reader.GetDateTime(6),
                                    Location = reader.IsDBNull(7) ? null : reader.GetString(7),
                                    Capacity = reader.GetInt32(8),
                                    BookedCount = reader.GetInt32(9),
                                    Difficulty = reader.IsDBNull(10) ? null : reader.GetString(10),
                                    Price = reader.GetDecimal(11),
                                    IsActive = reader.GetBoolean(12)
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error loading sessions: " + ex.Message, "Error",
                               System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }

            return sessions;
        }

        public List<Session> GetSessionsByTrainer(int trainerId)
        {
            List<Session> sessions = new List<Session>();

            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string sql = @"SELECT Id, Name, Description, TrainerId, StartTime, EndTime, 
                                          Location, Capacity, BookedCount, Difficulty, Price, IsActive 
                                   FROM Sessions 
                                   WHERE TrainerId = @TrainerId AND IsActive = 1
                                   ORDER BY StartTime";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@TrainerId", trainerId);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                sessions.Add(new Session
                                {
                                    Id = reader.GetInt32(0),
                                    Name = reader.GetString(1),
                                    Description = reader.IsDBNull(2) ? null : reader.GetString(2),
                                    TrainerId = reader.GetInt32(3),
                                    StartTime = reader.GetDateTime(4),
                                    EndTime = reader.GetDateTime(5),
                                    Location = reader.IsDBNull(6) ? null : reader.GetString(6),
                                    Capacity = reader.GetInt32(7),
                                    BookedCount = reader.GetInt32(8),
                                    Difficulty = reader.IsDBNull(9) ? null : reader.GetString(9),
                                    Price = reader.GetDecimal(10),
                                    IsActive = reader.GetBoolean(11)
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error loading sessions: " + ex.Message, "Error",
                               System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }

            return sessions;
        }

        public void AddSession(Session session)
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string sql = @"INSERT INTO Sessions (Name, Description, TrainerId, StartTime, EndTime, 
                                 Location, Capacity, BookedCount, Difficulty, Price, IsActive) 
                                 VALUES (@Name, @Description, @TrainerId, @StartTime, @EndTime, 
                                 @Location, @Capacity, @BookedCount, @Difficulty, @Price, @IsActive)";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", session.Name);
                        cmd.Parameters.AddWithValue("@Description", (object)session.Description ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@TrainerId", session.TrainerId);
                        cmd.Parameters.AddWithValue("@StartTime", session.StartTime);
                        cmd.Parameters.AddWithValue("@EndTime", session.EndTime);
                        cmd.Parameters.AddWithValue("@Location", (object)session.Location ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@Capacity", session.Capacity);
                        cmd.Parameters.AddWithValue("@BookedCount", 0); // New session starts with 0 bookings
                        cmd.Parameters.AddWithValue("@Difficulty", (object)session.Difficulty ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@Price", session.Price);
                        cmd.Parameters.AddWithValue("@IsActive", true);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error adding session: " + ex.Message, "Error",
                               System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        public void UpdateSession(Session session)
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string sql = @"UPDATE Sessions SET 
                                   Name = @Name, 
                                   Description = @Description, 
                                   TrainerId = @TrainerId, 
                                   StartTime = @StartTime, 
                                   EndTime = @EndTime, 
                                   Location = @Location, 
                                   Capacity = @Capacity, 
                                   Difficulty = @Difficulty, 
                                   Price = @Price,
                                   IsActive = @IsActive
                                   WHERE Id = @Id";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", session.Id);
                        cmd.Parameters.AddWithValue("@Name", session.Name);
                        cmd.Parameters.AddWithValue("@Description", (object)session.Description ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@TrainerId", session.TrainerId);
                        cmd.Parameters.AddWithValue("@StartTime", session.StartTime);
                        cmd.Parameters.AddWithValue("@EndTime", session.EndTime);
                        cmd.Parameters.AddWithValue("@Location", (object)session.Location ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@Capacity", session.Capacity);
                        cmd.Parameters.AddWithValue("@Difficulty", (object)session.Difficulty ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@Price", session.Price);
                        cmd.Parameters.AddWithValue("@IsActive", session.IsActive);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error updating session: " + ex.Message, "Error",
                               System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        public void DeleteSession(int id)
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    // Soft delete
                    string sql = "UPDATE Sessions SET IsActive = 0 WHERE Id = @Id";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", id);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error deleting session: " + ex.Message, "Error",
                               System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }
    }
}