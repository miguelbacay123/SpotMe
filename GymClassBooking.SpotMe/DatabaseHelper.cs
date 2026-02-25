using Microsoft.Data.SqlClient;
using System;
using System.Configuration;
using System.Windows.Forms;

namespace GymClassBooking.SpotMe
{
    public static class DatabaseHelper
    {
        private static string connectionString =
            ConfigurationManager.ConnectionStrings["SpotMeDB"].ConnectionString;

        public static bool RegisterUser(string email, string password)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = "INSERT INTO Users (Email, Password, FullName) VALUES (@Email, @Password, @Email)";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Password", password);

                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627)
                {
                    MessageBox.Show("Email already exists.", "Registration Failed",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Database error: " + ex.Message, "Error",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return false;
            }
        }

        public static bool LoginUser(string email, string password)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = "SELECT COUNT(*) FROM Users WHERE Email = @Email AND Password = @Password";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Password", password);

                        int count = (int)cmd.ExecuteScalar();
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Login error: " + ex.Message, "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}