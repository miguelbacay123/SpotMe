using System;
using System.Collections.Generic;
using System.Linq;
using GymClassBooking.SpotMe.Models;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace GymClassBooking.SpotMe.Controllers
{
    public class ActivityLogController
    {
        public List<ActivityLog> GetRecentActivities(int count = 6)
        {
            List<ActivityLog> activities = new List<ActivityLog>();

            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = @"
                        SELECT TOP(@count) 
                            Id, Action, Description, Category, Icon, Timestamp, UserId
                        FROM dbo.ActivityLog
                        ORDER BY Timestamp DESC";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@count", count);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                activities.Add(new ActivityLog
                                {
                                    Id = reader.GetInt32(0),
                                    Action = reader.GetString(1),
                                    Description = reader.IsDBNull(2) ? "" : reader.GetString(2),
                                    Category = reader.IsDBNull(3) ? "" : reader.GetString(3),
                                    Icon = reader.IsDBNull(4) ? "●" : reader.GetString(4),
                                    Timestamp = reader.GetDateTime(5),
                                    UserId = reader.IsDBNull(6) ? (int?)null : reader.GetInt32(6)
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching activities: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return activities;
        }

        public Dictionary<string, int> GetActivityChartData(int days = 7)
        {
            Dictionary<string, int> data = new Dictionary<string, int>();

            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = @"
                        SELECT 
                            DATENAME(dw, CONVERT(DATE, Timestamp)) AS DayName,
                            COUNT(*) AS ActivityCount
                        FROM dbo.ActivityLog
                        WHERE Timestamp >= DATEADD(DAY, -@days, CAST(GETDATE() AS DATE))
                        GROUP BY CONVERT(DATE, Timestamp), DATENAME(dw, CONVERT(DATE, Timestamp))
                        ORDER BY CONVERT(DATE, Timestamp) ASC";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@days", days - 1);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string dayName = reader.GetString(0).Substring(0, 3);
                                int count = reader.GetInt32(1);
                                data[dayName] = count;
                            }
                        }
                    }
                }

                // Fill in missing days with 0
                for (int i = days - 1; i >= 0; i--)
                {
                    DateTime date = DateTime.Now.AddDays(-i);
                    string dayName = date.ToString("ddd");
                    if (!data.ContainsKey(dayName))
                    {
                        data[dayName] = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching chart data: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return data;
        }

        public void AddActivityLog(ActivityLog log)
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = @"
                        INSERT INTO dbo.ActivityLog (Action, Description, Category, Icon, Timestamp, UserId)
                        VALUES (@action, @description, @category, @icon, @timestamp, @userId)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@action", log.Action);
                        cmd.Parameters.AddWithValue("@description", log.Description ?? "");
                        cmd.Parameters.AddWithValue("@category", log.Category ?? "");
                        cmd.Parameters.AddWithValue("@icon", log.Icon ?? "●");
                        cmd.Parameters.AddWithValue("@timestamp", DateTime.Now);

                        if (CurrentUser.UserId.HasValue)
                            cmd.Parameters.AddWithValue("@userId", CurrentUser.UserId.Value);
                        else
                            cmd.Parameters.AddWithValue("@userId", DBNull.Value);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error logging activity: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public List<ActivityLog> GetActivitiesByDate(DateTime date)
        {
            List<ActivityLog> activities = new List<ActivityLog>();

            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = @"
                        SELECT Id, Action, Description, Category, Icon, Timestamp, UserId
                        FROM dbo.ActivityLog
                        WHERE CONVERT(DATE, Timestamp) = @date
                        ORDER BY Timestamp DESC";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@date", date.Date);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                activities.Add(new ActivityLog
                                {
                                    Id = reader.GetInt32(0),
                                    Action = reader.GetString(1),
                                    Description = reader.IsDBNull(2) ? "" : reader.GetString(2),
                                    Category = reader.IsDBNull(3) ? "" : reader.GetString(3),
                                    Icon = reader.IsDBNull(4) ? "●" : reader.GetString(4),
                                    Timestamp = reader.GetDateTime(5),
                                    UserId = reader.IsDBNull(6) ? (int?)null : reader.GetInt32(6)
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching activities: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return activities;
        }
    }
}