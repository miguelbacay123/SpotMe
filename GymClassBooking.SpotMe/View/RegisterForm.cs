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
    public partial class RegisterForm : Form
    {
        private StaffController _staffController = new StaffController();

        // Color Palette
        private const int PRIMARY_HUE = 0x6F2C8C;      // Purple (111, 44, 140)
        private const int LIGHT_PURPLE = 0xF9F5FF;     // Light purple tint
        private const int GRAY_LIGHT = 0xF5F5F5;       // Light gray background
        private const int GRAY_DARK = 0x666666;        // Dark gray text
        private const int BLACK = 0x000000;            // Black text
        private const int WHITE = 0xFFFFFF;            // White background

        public RegisterForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            ApplyColorPalette();
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
            panel5.BackColor = ColorFromHex(GRAY_LIGHT);

            // Input labels
            label5.ForeColor = ColorFromHex(GRAY_DARK);
            label7.ForeColor = ColorFromHex(GRAY_DARK);
            label8.ForeColor = ColorFromHex(GRAY_DARK);

            // Input text boxes
            txtEmail.BackColor = ColorFromHex(WHITE);
            txtEmail.ForeColor = ColorFromHex(BLACK);
            txtPassword.BackColor = ColorFromHex(WHITE);
            txtPassword.ForeColor = ColorFromHex(BLACK);
            txtConfirmPassword.BackColor = ColorFromHex(WHITE);
            txtConfirmPassword.ForeColor = ColorFromHex(BLACK);

            // Register button
            btnRegister.BackColor = ColorFromHex(PRIMARY_HUE);
            btnRegister.ForeColor = ColorFromHex(WHITE);
            btnRegister.Cursor = Cursors.Hand;

            // Login link
            linklogin.LinkColor = ColorFromHex(PRIMARY_HUE);
            linklogin.VisitedLinkColor = ColorFromHex(PRIMARY_HUE);
            linklogin.ActiveLinkColor = ColorFromHex(GRAY_DARK);
            linklogin.Cursor = Cursors.Hand;
        }

        private void label1_Click(object sender, EventArgs e) { }
        private void Form1_Load(object sender, EventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void label6_Click(object sender, EventArgs e) { }
        private void pictureBox2_Click(object sender, EventArgs e) { }
        private void pictureBox2_Click_1(object sender, EventArgs e) { }
        private void pictureBox2_Click_2(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string email = txtEmail.Text.Trim();
                string password = txtPassword.Text;
                string confirmPassword = txtConfirmPassword.Text;

                if (password != confirmPassword)
                {
                    MessageBox.Show("Passwords do not match.", "Error",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Please fill all fields.", "Error",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Check if email already exists in Staff table
                if (_staffController.StaffExists(email))
                {
                    MessageBox.Show("This email is registered as staff and already has an account.",
                                   "Email Already Registered",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Information);
                    return;
                }

                if (DatabaseHelper.RegisterUser(email, password))
                {
                    // Set CurrentUser for new member
                    CurrentUser.UserEmail = email;
                    CurrentUser.UserRole = "Member";

                    MessageBox.Show("Registration successful! You can now login.",
                                   "Success",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Registration Error: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void pictureBox1_Click(object sender, EventArgs e) { }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
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
        private void panel5_Paint(object sender, PaintEventArgs e) { }
        private void label3_Click_1(object sender, EventArgs e) { }
    }
}