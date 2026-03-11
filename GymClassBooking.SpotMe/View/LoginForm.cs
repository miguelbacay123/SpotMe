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
        public static string LoggedInUserRole { get; set; } // "SuperAdmin", "Staff" or "Member"

        // SuperAdmin emails list
        private static readonly List<string> SuperAdminEmails = new List<string>
        {
            "miguelbacay123@gmail.com"
        };

        // Color Palette
        private const int PRIMARY_HUE = 0x6F2C8C;      // Purple (111, 44, 140)
        private const int LIGHT_PURPLE = 0xF9F5FF;     // Light purple tint
        private const int GRAY_LIGHT = 0xF5F5F5;       // Light gray background
        private const int GRAY_DARK = 0x666666;        // Dark gray text
        private const int BLACK = 0x000000;            // Black text
        private const int WHITE = 0xFFFFFF;            // White background
        private const int SNOW = 0xFFFAFA;             // Snow color

        public LoginForm()
        {
            try
            {
                InitializeComponent();
                this.StartPosition = FormStartPosition.CenterScreen;
                ApplyColorPalette();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error in LoginForm constructor: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Color ColorFromHex(int hex)
        {
            return Color.FromArgb((hex >> 16) & 0xFF, (hex >> 8) & 0xFF, hex & 0xFF);
        }

        private void ApplyColorPalette()
        {
            // Main form background
            this.BackColor = ColorFromHex(WHITE);

            // Left panel (image panel)
            panel1.BackColor = ColorFromHex(LIGHT_PURPLE);

            // Right panel (form content)
            panel2.BackColor = ColorFromHex(WHITE);

            // Title and branding
            label1.ForeColor = ColorFromHex(PRIMARY_HUE);
            label6.ForeColor = ColorFromHex(PRIMARY_HUE);

            // Subtitle text
            label3.ForeColor = ColorFromHex(GRAY_DARK);
            label4.ForeColor = ColorFromHex(GRAY_DARK);

            // Input panels
            panel3.BackColor = ColorFromHex(GRAY_LIGHT);
            panel4.BackColor = ColorFromHex(GRAY_LIGHT);

            // Input labels
            label5.ForeColor = ColorFromHex(GRAY_DARK);
            label7.ForeColor = ColorFromHex(GRAY_DARK);

            // Input text boxes
            txtEmail.BackColor = ColorFromHex(WHITE);
            txtEmail.ForeColor = ColorFromHex(BLACK);
            txtPassword.BackColor = ColorFromHex(WHITE);
            txtPassword.ForeColor = ColorFromHex(BLACK);

            // Login button
            btnLogin.BackColor = ColorFromHex(PRIMARY_HUE);
            btnLogin.ForeColor = ColorFromHex(WHITE);
            btnLogin.Cursor = Cursors.Hand;

            // Register link
            linkRegister.LinkColor = ColorFromHex(PRIMARY_HUE);
            linkRegister.VisitedLinkColor = ColorFromHex(PRIMARY_HUE);
            linkRegister.ActiveLinkColor = ColorFromHex(GRAY_DARK);
            linkRegister.Cursor = Cursors.Hand;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

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
                    CurrentUser.UserEmail = email;

                    // Check if user is SuperAdmin first
                    if (SuperAdminEmails.Contains(email))
                    {
                        LoggedInUserRole = "SuperAdmin";
                        CurrentUser.UserRole = "SuperAdmin";
                    }
                    else
                    {
                        // Determine user role (Staff or Member)
                        StaffController staffController = new StaffController();
                        var staffUser = staffController.GetStaffByEmail(email);

                        if (staffUser != null)
                        {
                            LoggedInUserRole = "Staff";
                            CurrentUser.UserRole = "Staff";
                        }
                        else
                        {
                            LoggedInUserRole = "Member";
                            CurrentUser.UserRole = "Member";
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
                        CurrentUser.UserEmail = null;
                        CurrentUser.UserRole = null;
                        CurrentUser.Logout();
                    };

                    dashboard.Show();
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

        // Empty event handlers
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