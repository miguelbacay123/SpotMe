using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using GymClassBooking.SpotMe.Controllers;
using GymClassBooking.SpotMe.Models;

namespace GymClassBooking.SpotMe.View
{
    public partial class ManageStaffForm : Form
    {
        private StaffController _staffController = new StaffController();
        private List<Staff> _staffList = new List<Staff>();

        public ManageStaffForm()
        {
            InitializeComponent();
            this.Text = "Manage Staff";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(900, 600);
            this.BackColor = Color.White;
        }

        private void ManageStaffForm_Load(object sender, EventArgs e)
        {
            LoadStaff();
        }

        private void LoadStaff()
        {
            try
            {
                _staffList = _staffController.GetAllStaff();
                DisplayStaff();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading staff: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayStaff()
        {
            pnlContent.Controls.Clear();

            if (_staffList.Count == 0)
            {
                pnlContent.Controls.Add(lblEmpty);
                return;
            }

            int currentY = 0;
            foreach (var staff in _staffList)
            {
                // Email
                Label lblEmail = new Label();
                lblEmail.Text = staff.Email;
                lblEmail.Font = new Font("Segoe UI", 10);
                lblEmail.ForeColor = Color.Black;
                lblEmail.Location = new Point(25, currentY + 10);
                lblEmail.AutoSize = true;
                pnlContent.Controls.Add(lblEmail);

                // Username
                Label lblUsername = new Label();
                lblUsername.Text = staff.Username;
                lblUsername.Font = new Font("Segoe UI", 10);
                lblUsername.ForeColor = Color.Black;
                lblUsername.Location = new Point(370, currentY + 10);
                lblUsername.AutoSize = true;
                pnlContent.Controls.Add(lblUsername);

                // Edit Button
                Button btnEdit = new Button();
                btnEdit.Text = "Edit";
                btnEdit.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                btnEdit.ForeColor = Color.White;
                btnEdit.BackColor = Color.FromArgb(255, 140, 0); // Orange
                btnEdit.FlatStyle = FlatStyle.Flat;
                btnEdit.FlatAppearance.BorderSize = 0;
                btnEdit.Location = new Point(700, currentY + 6);
                btnEdit.Size = new Size(60, 28);
                btnEdit.Tag = staff.Id;
                btnEdit.Cursor = Cursors.Hand;
                btnEdit.Click += (s, e) => EditStaff(staff);
                pnlContent.Controls.Add(btnEdit);

                // Delete Button
                Button btnDelete = new Button();
                btnDelete.Text = "Delete";
                btnDelete.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                btnDelete.ForeColor = Color.White;
                btnDelete.BackColor = Color.FromArgb(220, 53, 69); // Red
                btnDelete.FlatStyle = FlatStyle.Flat;
                btnDelete.FlatAppearance.BorderSize = 0;
                btnDelete.Location = new Point(770, currentY + 6);
                btnDelete.Size = new Size(70, 28);
                btnDelete.Tag = staff.Id;
                btnDelete.Cursor = Cursors.Hand;
                btnDelete.Click += (s, e) => DeleteStaff(staff.Id, staff.Username);
                pnlContent.Controls.Add(btnDelete);

                currentY += 45;

                // Separator Line
                Panel separator = new Panel();
                separator.BackColor = Color.FromArgb(230, 230, 230);
                separator.Location = new Point(0, currentY);
                separator.Size = new Size(860, 1);
                pnlContent.Controls.Add(separator);

                currentY += 8;
            }
        }

        private void BtnAddStaff_Click(object sender, EventArgs e)
        {
            AddStaffForm addForm = new AddStaffForm();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                LoadStaff();
                MessageBox.Show("Staff added successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void EditStaff(Staff staff)
        {
            AddStaffForm editForm = new AddStaffForm(staff);
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                LoadStaff();
            }
        }

        private void DeleteStaff(int staffId, string staffUsername)
        {
            DialogResult result = MessageBox.Show(
                $"Are you sure you want to delete staff member '{staffUsername}'?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    _staffController.DeleteStaff(staffId);
                    MessageBox.Show("Staff deleted successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadStaff();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting staff: {ex.Message}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            // Find and show MainDashboard
            foreach (Form form in Application.OpenForms)
            {
                if (form is MainDashboard)
                {
                    form.Show();
                    form.BringToFront();
                    break;
                }
            }
            this.Close();
        }
    }
}