using GymClassBooking.SpotMe.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Windows.Forms;

namespace GymClassBooking.SpotMe.Controllers
{
    public class AttendanceController
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["SpotMeDB"].ConnectionString;

        public bool AddAttendance(Attendance attendance)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = "INSERT INTO [dbo].[Attendance] (MemberId, MemberName, BookingClassId, ClassName, CheckInTime, ClassDate, Status) " +
                                 "VALUES (@MemberId, @MemberName, @BookingClassId, @ClassName, @CheckInTime, @ClassDate, @Status)";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@MemberId", attendance.MemberId);
                        cmd.Parameters.AddWithValue("@MemberName", attendance.MemberName);
                        cmd.Parameters.AddWithValue("@BookingClassId", attendance.BookingClassId);
                        cmd.Parameters.AddWithValue("@ClassName", attendance.ClassName);
                        cmd.Parameters.AddWithValue("@CheckInTime", attendance.CheckInTime ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@ClassDate", attendance.ClassDate);
                        cmd.Parameters.AddWithValue("@Status", attendance.Status);

                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding attendance: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public Attendance GetBookingClassAttendance(int memberId, int bookingClassId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = "SELECT * FROM [dbo].[Attendance] WHERE MemberId = @MemberId AND BookingClassId = @BookingClassId";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@MemberId", memberId);
                        cmd.Parameters.AddWithValue("@BookingClassId", bookingClassId);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new Attendance
                                {
                                    Id = (int)reader["Id"],
                                    MemberId = (int)reader["MemberId"],
                                    MemberName = reader["MemberName"].ToString(),
                                    BookingClassId = (int)reader["BookingClassId"],
                                    ClassName = reader["ClassName"].ToString(),
                                    CheckInTime = reader["CheckInTime"] != DBNull.Value
                                        ? (DateTime)reader["CheckInTime"]
                                        : (DateTime?)null,
                                    ClassDate = (DateTime)reader["ClassDate"],
                                    Status = reader["Status"].ToString()
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error checking attendance: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return null;
        }

        public List<Attendance> GetMemberAttendance(int memberId)
        {
            List<Attendance> attendanceList = new List<Attendance>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = "SELECT * FROM [dbo].[Attendance] WHERE MemberId = @MemberId ORDER BY ClassDate DESC";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@MemberId", memberId);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                attendanceList.Add(new Attendance
                                {
                                    Id = (int)reader["Id"],
                                    MemberId = (int)reader["MemberId"],
                                    MemberName = reader["MemberName"].ToString(),
                                    BookingClassId = (int)reader["BookingClassId"],
                                    ClassName = reader["ClassName"].ToString(),
                                    CheckInTime = reader["CheckInTime"] != DBNull.Value
                                        ? (DateTime)reader["CheckInTime"]
                                        : (DateTime?)null,
                                    ClassDate = (DateTime)reader["ClassDate"],
                                    Status = reader["Status"].ToString()
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading attendance: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return attendanceList;
        }

        public List<Attendance> GetBookingClassAttendanceList(int bookingClassId)
        {
            List<Attendance> attendanceList = new List<Attendance>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = "SELECT * FROM [dbo].[Attendance] WHERE BookingClassId = @BookingClassId ORDER BY MemberName";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@BookingClassId", bookingClassId);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                attendanceList.Add(new Attendance
                                {
                                    Id = (int)reader["Id"],
                                    MemberId = (int)reader["MemberId"],
                                    MemberName = reader["MemberName"].ToString(),
                                    BookingClassId = (int)reader["BookingClassId"],
                                    ClassName = reader["ClassName"].ToString(),
                                    CheckInTime = reader["CheckInTime"] != DBNull.Value
                                        ? (DateTime)reader["CheckInTime"]
                                        : (DateTime?)null,
                                    ClassDate = (DateTime)reader["ClassDate"],
                                    Status = reader["Status"].ToString()
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading class attendance: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return attendanceList;
        }

        public List<Attendance> GetAllAttendance()
        {
            List<Attendance> attendanceList = new List<Attendance>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = "SELECT * FROM [dbo].[Attendance] ORDER BY ClassDate DESC";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                attendanceList.Add(new Attendance
                                {
                                    Id = (int)reader["Id"],
                                    MemberId = (int)reader["MemberId"],
                                    MemberName = reader["MemberName"].ToString(),
                                    BookingClassId = (int)reader["BookingClassId"],
                                    ClassName = reader["ClassName"].ToString(),
                                    CheckInTime = reader["CheckInTime"] != DBNull.Value
                                        ? (DateTime)reader["CheckInTime"]
                                        : (DateTime?)null,
                                    ClassDate = (DateTime)reader["ClassDate"],
                                    Status = reader["Status"].ToString()
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading attendance: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return attendanceList;
        }

        public bool UpdateAttendance(Attendance attendance)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = "UPDATE [dbo].[Attendance] SET Status = @Status, CheckInTime = @CheckInTime WHERE Id = @Id";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", attendance.Id);
                        cmd.Parameters.AddWithValue("@Status", attendance.Status);
                        cmd.Parameters.AddWithValue("@CheckInTime", attendance.CheckInTime ?? (object)DBNull.Value);

                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating attendance: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool DeleteAttendance(int id)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = "DELETE FROM [dbo].[Attendance] WHERE Id = @Id";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", id);

                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting attendance: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public int GetMemberAttendanceCount(int memberId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = "SELECT COUNT(*) FROM [dbo].[Attendance] WHERE MemberId = @MemberId AND Status = 'Present'";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@MemberId", memberId);

                        return (int)cmd.ExecuteScalar();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error counting attendance: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }
    }
}