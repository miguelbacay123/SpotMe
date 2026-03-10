using System;
using System.Drawing;
using System.Windows.Forms;
using GymClassBooking.SpotMe.Controllers;
using GymClassBooking.SpotMe.Models;

namespace GymClassBooking.SpotMe.View
{
    public partial class AddStaffForm : Form
    {
        private StaffController _staffController = new StaffController();

        // Color Palette
        private const int PRIMARY_HUE = 0x6F2C8C;      // Purple
        private const int GRAY_LIGHT = 0xF5F5F5;       // Light gray
        private const int GRAY_DARK = 0x666666;        // Dark gray
        private const int WHITE = 0xFFFFFF;            // White

        public string StaffUsername { get; private set; }
        public string StaffEmail { get; private set; }
        public string StaffPassword { get; private set; }

        private Staff _editingStaff = null;
        private bool _isEditing = false;

        public AddStaffForm()
        {
            InitializeComponent();
            ApplyColorPalette();
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Text = "Add New Staff";
            _isEditing = false;
            btnCreate.Text = "Add Staff";
        }

        public AddStaffForm(Staff staffToEdit)
        {
            InitializeComponent();
            ApplyColorPalette();
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            _editingStaff = staffToEdit;
            _isEditing = true;
            this.Text = "Edit Staff";

            // Load existing data
            txtUsername.Text = staffToEdit.Username;
            txtEmail.Text = staffToEdit.Email;
            txtPassword.Text = staffToEdit.Password;
            btnCreate.Text = "Update";
        }

        private Color ColorFromHex(int hex)
        {
            return Color.FromArgb((hex >> 16) & 0xFF, (hex >> 8) & 0xFF, hex & 0xFF);
        }

        private void ApplyColorPalette()
        {
            this.BackColor = ColorFromHex(WHITE);

            lblTitle.ForeColor = ColorFromHex(PRIMARY_HUE);
            lblUsername.ForeColor = ColorFromHex(GRAY_DARK);
            lblEmail.ForeColor = ColorFromHex(GRAY_DARK);
            lblPassword.ForeColor = ColorFromHex(GRAY_DARK);

            btnCreate.BackColor = ColorFromHex(PRIMARY_HUE);
            btnCreate.ForeColor = ColorFromHex(WHITE);
            btnCreate.Cursor = Cursors.Hand;

            btnCancel.BackColor = ColorFromHex(WHITE);
            btnCancel.ForeColor = ColorFromHex(PRIMARY_HUE);
            btnCancel.Cursor = Cursors.Hand;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            // Validate inputs
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Username is required.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Email is required.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Password is required.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string email = txtEmail.Text.Trim();

                if (_isEditing)
                {
                    // Update existing staff
                    // Only check for duplicate if email changed
                    if (email != _editingStaff.Email)
                    {
                        var existingStaff = _staffController.GetStaffByEmail(email);
                        if (existingStaff != null)
                        {
                            MessageBox.Show("This email already exists as a staff member.", "Duplicate Email",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    Staff updatedStaff = new Staff
                    {
                        Id = _editingStaff.Id,
                        Username = txtUsername.Text.Trim(),
                        Email = email,
                        Password = txtPassword.Text,
                        IsActive = true
                    };

                    _staffController.UpdateStaff(updatedStaff);

                    // Also update in login system
                    DatabaseHelper.UpdateUserPassword(email, txtPassword.Text);

                    StaffUsername = updatedStaff.Username;
                    StaffEmail = updatedStaff.Email;
                    StaffPassword = updatedStaff.Password;

                    MessageBox.Show("Staff updated successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // CHECK IF EMAIL EXISTS IN STAFF TABLE
                    var existingStaff = _staffController.GetStaffByEmail(email);
                    if (existingStaff != null)
                    {
                        MessageBox.Show("This email already exists as a staff member.", "Duplicate Email",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // First, create staff in Staff table
                    Staff newStaff = new Staff
                    {
                        Username = txtUsername.Text.Trim(),
                        Email = email,
                        Password = txtPassword.Text
                    };

                    if (!_staffController.AddStaff(newStaff))
                    {
                        MessageBox.Show("Failed to add staff. Please try again.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Then, register in Users table (login system)
                    // This is secondary - if it fails, staff still exists in Staff table
                    if (!DatabaseHelper.RegisterUser(email, txtPassword.Text))
                    {
                        // Email already in Users table - that's OK, just update password
                        DatabaseHelper.UpdateUserPassword(email, txtPassword.Text);
                    }

                    StaffUsername = newStaff.Username;
                    StaffEmail = newStaff.Email;
                    StaffPassword = newStaff.Password;

                    MessageBox.Show("Staff added successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}