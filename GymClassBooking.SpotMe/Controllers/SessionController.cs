using System;
using System.Collections.Generic;
using GymClassBooking.SpotMe.Models;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace GymClassBooking.SpotMe.Controllers
{
    public class SessionController
    {
        /// <summary>
        /// Gets all sessions from the database (using the same BookingClasses table)
        /// </summary>
        public List<Session> GetAllSessions()
        {
            var list = new List<Session>();
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    // Use the same BookingClasses table as ClassBooking
                    string sql = @"
                        SELECT Id, Category, Description, TrainerName, TrainerId, 
                               StartTime, EndTime, Capacity, BookedCount, Status, IsActive
                        FROM BookingClasses 
                        WHERE IsActive = 1
                        ORDER BY StartTime";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        using (SqlDataReader r = cmd.ExecuteReader())
                        {
                            while (r.Read())
                            {
                                Session session = new Session
                                {
                                    Id = r.GetInt32(0),
                                    Category = r.GetString(1),
                                    Description = r.IsDBNull(2) ? "" : r.GetString(2),
                                    TrainerName = r.GetString(3),
                                    TrainerId = r.IsDBNull(4) ? 0 : r.GetInt32(4),
                                    StartTime = r.GetDateTime(5),
                                    EndTime = r.GetDateTime(6),
                                    Capacity = r.GetInt32(7),
                                    BookedCount = r.IsDBNull(8) ? 0 : r.GetInt32(8),
                                    Status = r.IsDBNull(9) ? "Upcoming" : r.GetString(9),
                                    IsActive = r.IsDBNull(10) ? true : r.GetBoolean(10)
                                };

                                // Calculate current status dynamically based on current time
                                session.Status = session.GetCurrentStatus();

                                list.Add(session);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading sessions: " + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return list;
        }

        /// <summary>
        /// Gets a single session by ID
        /// </summary>
        public Session GetSessionById(int sessionId)
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string sql = @"
                        SELECT Id, Category, Description, TrainerName, TrainerId, 
                               StartTime, EndTime, Capacity, BookedCount, Status, IsActive
                        FROM BookingClasses 
                        WHERE Id = @Id AND IsActive = 1";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", sessionId);
                        using (SqlDataReader r = cmd.ExecuteReader())
                        {
                            if (r.Read())
                            {
                                Session session = new Session
                                {
                                    Id = r.GetInt32(0),
                                    Category = r.GetString(1),
                                    Description = r.IsDBNull(2) ? "" : r.GetString(2),
                                    TrainerName = r.GetString(3),
                                    TrainerId = r.IsDBNull(4) ? 0 : r.GetInt32(4),
                                    StartTime = r.GetDateTime(5),
                                    EndTime = r.GetDateTime(6),
                                    Capacity = r.GetInt32(7),
                                    BookedCount = r.IsDBNull(8) ? 0 : r.GetInt32(8),
                                    Status = r.IsDBNull(9) ? "Upcoming" : r.GetString(9),
                                    IsActive = r.IsDBNull(10) ? true : r.GetBoolean(10)
                                };

                                // Calculate current status dynamically
                                session.Status = session.GetCurrentStatus();

                                return session;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading session: " + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }

        /// <summary>
        /// Adds a new session to the database
        /// </summary>
        public void AddSession(Session session)
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string sql = @"
                        INSERT INTO BookingClasses (Category, Description, TrainerName, TrainerId, 
                                              StartTime, EndTime, Capacity, BookedCount, Status, IsActive)
                        VALUES (@Category, @Description, @TrainerName, @TrainerId, 
                                @StartTime, @EndTime, @Capacity, 0, @Status, 1)";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Category", session.Category);
                        cmd.Parameters.AddWithValue("@Description", session.Description ?? "");
                        cmd.Parameters.AddWithValue("@TrainerName", session.TrainerName);
                        cmd.Parameters.AddWithValue("@TrainerId", session.TrainerId);
                        cmd.Parameters.AddWithValue("@StartTime", session.StartTime);
                        cmd.Parameters.AddWithValue("@EndTime", session.EndTime);
                        cmd.Parameters.AddWithValue("@Capacity", session.Capacity);
                        cmd.Parameters.AddWithValue("@Status", "Upcoming");
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding session: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        /// <summary>
        /// Updates an existing session
        /// </summary>
        public void UpdateSession(Session session)
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string sql = @"
                        UPDATE BookingClasses 
                        SET Category = @Category,
                            Description = @Description,
                            TrainerName = @TrainerName,
                            TrainerId = @TrainerId,
                            StartTime = @StartTime,
                            EndTime = @EndTime,
                            Capacity = @Capacity,
                            Status = @Status
                        WHERE Id = @Id";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", session.Id);
                        cmd.Parameters.AddWithValue("@Category", session.Category);
                        cmd.Parameters.AddWithValue("@Description", session.Description ?? "");
                        cmd.Parameters.AddWithValue("@TrainerName", session.TrainerName);
                        cmd.Parameters.AddWithValue("@TrainerId", session.TrainerId);
                        cmd.Parameters.AddWithValue("@StartTime", session.StartTime);
                        cmd.Parameters.AddWithValue("@EndTime", session.EndTime);
                        cmd.Parameters.AddWithValue("@Capacity", session.Capacity);
                        cmd.Parameters.AddWithValue("@Status", "Upcoming");
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating session: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        /// <summary>
        /// Deletes a session (soft delete by setting IsActive = 0)
        /// </summary>
        public void DeleteSession(int sessionId)
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string sql = "UPDATE BookingClasses SET IsActive = 0 WHERE Id = @Id";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", sessionId);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting session: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        /// <summary>
        /// Gets all bookings for a specific session
        /// </summary>
        public List<SessionBooking> GetBookingsBySession(int sessionId)
        {
            var list = new List<SessionBooking>();
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string sql = @"
                        SELECT sb.Id, sb.SessionId, sb.MemberId,
                               m.Name AS MemberName, sb.BookingDate, sb.Status
                        FROM SessionBookings sb
                        INNER JOIN Members m ON m.Id = sb.MemberId
                        WHERE sb.SessionId = @SessionId
                          AND sb.Status = 'Active'
                        ORDER BY sb.BookingDate";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@SessionId", sessionId);
                        using (SqlDataReader r = cmd.ExecuteReader())
                        {
                            while (r.Read())
                            {
                                list.Add(new SessionBooking
                                {
                                    Id = r.GetInt32(0),
                                    SessionId = r.GetInt32(1),
                                    MemberId = r.GetInt32(2),
                                    MemberName = r.GetString(3),
                                    BookingDate = r.GetDateTime(4),
                                    Status = r.GetString(5)
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading bookings: " + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return list;
        }

        /// <summary>
        /// Adds a new booking for a member to a session
        /// </summary>
        public void AddBooking(int sessionId, int memberId)
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string sql = @"
                        INSERT INTO SessionBookings (SessionId, MemberId, BookingDate, Status)
                        VALUES (@SessionId, @MemberId, @BookingDate, 'Active');
                        
                        UPDATE BookingClasses 
                        SET BookedCount = BookedCount + 1 
                        WHERE Id = @SessionId";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@SessionId", sessionId);
                        cmd.Parameters.AddWithValue("@MemberId", memberId);
                        cmd.Parameters.AddWithValue("@BookingDate", DateTime.Now);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding booking: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        /// <summary>
        /// Cancels a booking for a member
        /// </summary>
        public void CancelBooking(int bookingId, int sessionId)
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string sql = @"
                        UPDATE SessionBookings 
                        SET Status = 'Cancelled' 
                        WHERE Id = @Id;
                        
                        UPDATE BookingClasses 
                        SET BookedCount = CASE 
                            WHEN BookedCount > 0 THEN BookedCount - 1 
                            ELSE 0 
                        END
                        WHERE Id = @SessionId";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", bookingId);
                        cmd.Parameters.AddWithValue("@SessionId", sessionId);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error cancelling booking: " + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
    }
}