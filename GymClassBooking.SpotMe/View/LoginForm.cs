using System;
using GymClassBooking.SpotMe.Controllers;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymClassBooking.SpotMe
{
    public partial class LoginForm : Form
    {
        // Static properties to track logged-in user
        public static string LoggedInUserEmail { get; set; }
        public static string LoggedInUserRole { get; set; } // "SuperAdmin", "Admin" or "Member"

        // SuperAdmin emails list (add your email here)
        private static readonly List<string> SuperAdminEmails = new List<string>
        {
            "miguelbacay123@gmail.com"
        };

        public LoginForm()
        {
            try
            {
                InitializeComponent();
                this.StartPosition = FormStartPosition.CenterScreen;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error in LoginForm constructor: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // LOGIN BUTTON - FIXED VERSION
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string email = txtEmail.Text.Trim();
                string password = txtPassword.Text;

                if (DatabaseHelper.LoginUser(email, password))
                {
                    // Set logged-in user info
                    LoggedInUserEmail = email;

                    // Check if user is SuperAdmin first
                    if (SuperAdminEmails.Contains(email))
                    {
                        LoggedInUserRole = "SuperAdmin";
                    }
                    else
                    {
                        // Determine user role (Admin or Member)
                        // Check if user exists in Staff table using direct method
                        StaffController staffController = new StaffController();
                        var staffUser = staffController.GetStaffByEmail(email);

                        if (staffUser != null)
                        {
                            LoggedInUserRole = "Admin"; // Staff members are admins
                        }
                        else
                        {
                            LoggedInUserRole = "Member"; // Regular users are members
                        }
                    }

                    this.Hide();

                    // Create MainDashboard and handle its close event
                    MainDashboard dashboard = new MainDashboard();
                    dashboard.FormClosed += (s, args) =>
                    {
                        // When dashboard closes, show login form again
                        this.Show();
                        // Clear password field for security
                        txtPassword.Clear();
                        txtEmail.Focus();

                        // Clear logged-in user
                        LoggedInUserEmail = null;
                        LoggedInUserRole = null;
                    };

                    dashboard.Show(); // Use Show() not ShowDialog()
                }
                else
                {
                    MessageBox.Show("Invalid email or password.",
                                   "Login Failed",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Error);

                    txtPassword.Clear();
                    txtEmail.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Login Error: {ex.Message}\n\n{ex.StackTrace}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Register link - FIXED VERSION
        private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                this.Hide();

                RegisterForm registerForm = new RegisterForm();
                registerForm.FormClosed += (s, args) =>
                {
                    this.Show();
                };
                registerForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening register form: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Show();
            }
        }

        // All your existing empty event handlers
        private void label1_Click(object sender, EventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void label6_Click(object sender, EventArgs e) { }
        private void pictureBox2_Click(object sender, EventArgs e) { }
        private void pictureBox2_Click_1(object sender, EventArgs e) { }
        private void pictureBox2_Click_2(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void pictureBox1_Click(object sender, EventArgs e) { }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) { }
        private void panel2_Paint(object sender, PaintEventArgs e) { }
        private void textBox1_TextChanged_1(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e) { }
        private void panel1_Paint_1(object sender, PaintEventArgs e) { }
        private void panel3_Paint(object sender, PaintEventArgs e) { }
        private void label5_Click_1(object sender, EventArgs e) { }
        private void panel4_Paint(object sender, PaintEventArgs e) { }
        private void txtPassword_TextChanged(object sender, EventArgs e) { }
        private void label7_Click(object sender, EventArgs e) { }
    }
}