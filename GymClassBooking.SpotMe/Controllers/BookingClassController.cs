using System;
using System.Collections.Generic;
using GymClassBooking.SpotMe.Models;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;
using System.Linq;

namespace GymClassBooking.SpotMe.Controllers
{
    public class BookingClassController
    {
        private ActivityLogController activityLog = new ActivityLogController();

        public List<BookingClass> GetAllClasses()
        {
            List<BookingClass> classes = new List<BookingClass>();

            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string sql = @"SELECT Id, Category, TrainerName, TrainerId, Description, 
                                          Capacity, BookedCount, StartTime, EndTime, Status, IsActive 
                                   FROM BookingClasses WHERE IsActive = 1 ORDER BY StartTime";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                classes.Add(new BookingClass
                                {
                                    Id = reader.GetInt32(0),
                                    Category = reader.GetString(1),
                                    TrainerName = reader.GetString(2),
                                    TrainerId = reader.IsDBNull(3) ? 0 : reader.GetInt32(3),
                                    Description = reader.IsDBNull(4) ? "" : reader.GetString(4),
                                    Capacity = reader.GetInt32(5),
                                    BookedCount = reader.IsDBNull(6) ? 0 : reader.GetInt32(6),
                                    StartTime = reader.GetDateTime(7),
                                    EndTime = reader.GetDateTime(8),
                                    Status = reader.IsDBNull(9) ? "Upcoming" : reader.GetString(9),
                                    IsActive = reader.IsDBNull(10) ? true : reader.GetBoolean(10)
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading classes: " + ex.Message, "Database Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return classes;
        }

        public BookingClass GetClassById(int id)
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string sql = @"SELECT Id, Category, TrainerName, TrainerId, Description, 
                                          Capacity, BookedCount, StartTime, EndTime, Status, IsActive 
                                   FROM BookingClasses WHERE Id = @Id";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", id);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new BookingClass
                                {
                                    Id = reader.GetInt32(0),
                                    Category = reader.GetString(1),
                                    TrainerName = reader.GetString(2),
                                    TrainerId = reader.IsDBNull(3) ? 0 : reader.GetInt32(3),
                                    Description = reader.IsDBNull(4) ? "" : reader.GetString(4),
                                    Capacity = reader.GetInt32(5),
                                    BookedCount = reader.IsDBNull(6) ? 0 : reader.GetInt32(6),
                                    StartTime = reader.GetDateTime(7),
                                    EndTime = reader.GetDateTime(8),
                                    Status = reader.IsDBNull(9) ? "Upcoming" : reader.GetString(9),
                                    IsActive = reader.IsDBNull(10) ? true : reader.GetBoolean(10)
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error getting class: " + ex.Message, "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }

        public void AddClass(BookingClass bookingClass)
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string sql = @"INSERT INTO BookingClasses (Category, TrainerName, TrainerId, Description, 
                                   Capacity, BookedCount, StartTime, EndTime, Status, IsActive, StaffId) 
                                   VALUES (@Category, @TrainerName, @TrainerId, @Description, 
                                   @Capacity, @BookedCount, @StartTime, @EndTime, @Status, @IsActive, @StaffId)";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Category", bookingClass.Category);
                        cmd.Parameters.AddWithValue("@TrainerName", bookingClass.TrainerName);
                        cmd.Parameters.AddWithValue("@TrainerId", bookingClass.TrainerId > 0 ? (object)bookingClass.TrainerId : DBNull.Value);
                        cmd.Parameters.AddWithValue("@Description", bookingClass.Description ?? "");
                        cmd.Parameters.AddWithValue("@Capacity", bookingClass.Capacity);
                        cmd.Parameters.AddWithValue("@BookedCount", 0);
                        cmd.Parameters.AddWithValue("@StartTime", bookingClass.StartTime);
                        cmd.Parameters.AddWithValue("@EndTime", bookingClass.EndTime);
                        cmd.Parameters.AddWithValue("@Status", "Upcoming");
                        cmd.Parameters.AddWithValue("@IsActive", true);
                        cmd.Parameters.AddWithValue("@StaffId", bookingClass.StaffId);

                        cmd.ExecuteNonQuery();
                    }
                }

                activityLog.AddActivityLog(new ActivityLog
                {
                    Action = "Class Created",
                    Description = $"{bookingClass.Category} class created by {bookingClass.TrainerName}",
                    Category = "Class",
                    Icon = "▲"
                });

                MessageBox.Show($"Class '{bookingClass.Category}' added successfully!", "Success",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding class: " + ex.Message, "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void UpdateClass(BookingClass bookingClass)
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    string checkSql = "SELECT COUNT(*) FROM BookingClasses WHERE Id = @Id";
                    using (SqlCommand checkCmd = new SqlCommand(checkSql, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@Id", bookingClass.Id);
                        int exists = (int)checkCmd.ExecuteScalar();

                        if (exists == 0)
                        {
                            MessageBox.Show($"Class with ID {bookingClass.Id} not found!",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    string sql = @"UPDATE BookingClasses SET 
                                   Category = @Category,
                                   TrainerName = @TrainerName,
                                   TrainerId = @TrainerId,
                                   Description = @Description,
                                   Capacity = @Capacity,
                                   StartTime = @StartTime,
                                   EndTime = @EndTime,
                                   Status = @Status
                                   WHERE Id = @Id";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", bookingClass.Id);
                        cmd.Parameters.AddWithValue("@Category", bookingClass.Category);
                        cmd.Parameters.AddWithValue("@TrainerName", bookingClass.TrainerName);
                        cmd.Parameters.AddWithValue("@TrainerId", bookingClass.TrainerId > 0 ? (object)bookingClass.TrainerId : DBNull.Value);
                        cmd.Parameters.AddWithValue("@Description", bookingClass.Description ?? "");
                        cmd.Parameters.AddWithValue("@Capacity", bookingClass.Capacity);
                        cmd.Parameters.AddWithValue("@StartTime", bookingClass.StartTime);
                        cmd.Parameters.AddWithValue("@EndTime", bookingClass.EndTime);
                        cmd.Parameters.AddWithValue("@Status", bookingClass.Status);

                        cmd.ExecuteNonQuery();
                    }
                }

                activityLog.AddActivityLog(new ActivityLog
                {
                    Action = "Class Updated",
                    Description = $"{bookingClass.Category} class updated",
                    Category = "Class",
                    Icon = "▲"
                });

                MessageBox.Show($"Class '{bookingClass.Category}' updated successfully!", "Success",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating class: " + ex.Message, "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void DeleteClass(int classId)
        {
            try
            {
                BookingClass cls = GetClassById(classId);
                string className = cls?.Category ?? "Class";

                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string sql = "UPDATE BookingClasses SET IsActive = 0 WHERE Id = @Id";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", classId);
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            activityLog.AddActivityLog(new ActivityLog
                            {
                                Action = "Class Deleted",
                                Description = $"{className} class deleted",
                                Category = "Class",
                                Icon = "▲"
                            });

                            MessageBox.Show($"Class '{className}' deleted successfully!", "Deleted",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Class not found.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting class: " + ex.Message, "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public List<BookingClass> GetAllClassesIncludingInactive()
        {
            List<BookingClass> classes = new List<BookingClass>();

            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string sql = @"SELECT Id, Category, TrainerName, TrainerId, Description, 
                                          Capacity, BookedCount, StartTime, EndTime, Status, IsActive 
                                                   FROM BookingClasses ORDER BY IsActive DESC, StartTime";

                                   using (SqlCommand cmd = new SqlCommand(sql, conn))
                                   {
                                       using (SqlDataReader reader = cmd.ExecuteReader())
                                       {
                                           while (reader.Read())
                                           {
                                               classes.Add(new BookingClass
                                               {
                                                   Id = reader.GetInt32(0),
                                                   Category = reader.GetString(1),
                                                   TrainerName = reader.GetString(2),
                                                   TrainerId = reader.IsDBNull(3) ? 0 : reader.GetInt32(3),
                                                   Description = reader.IsDBNull(4) ? "" : reader.GetString(4),
                                                   Capacity = reader.GetInt32(5),
                                                   BookedCount = reader.IsDBNull(6) ? 0 : reader.GetInt32(6),
                                                   StartTime = reader.GetDateTime(7),
                                                   EndTime = reader.GetDateTime(8),
                                                   Status = reader.IsDBNull(9) ? "Upcoming" : reader.GetString(9),
                                                   IsActive = reader.IsDBNull(10) ? true : reader.GetBoolean(10)
                                               });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading classes: " + ex.Message, "Database Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return classes;
        }
    }
}