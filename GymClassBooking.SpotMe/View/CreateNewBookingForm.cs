using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using GymClassBooking.SpotMe.Controllers;
using GymClassBooking.SpotMe.Models;

namespace GymClassBooking.SpotMe.View
{
    public partial class CreateNewBookingForm : Form
    {
        private Session _session;
        private SessionController _sessionController = new SessionController();
        private MemberController _memberController = new MemberController();
        private ActivityLogController _activityLogController = new ActivityLogController();
        private List<Member> _members = new List<Member>();
        private int _selectedMemberId = -1;

        // Color Palette
        private const int PRIMARY_HUE = 0x6F2C8C;      // Purple
        private const int GRAY_LIGHT = 0xF5F5F5;       // Light gray
        private const int GRAY_DARK = 0x666666;        // Dark gray
        private const int GRAY_MEDIUM = 0xAAAAAA;      // Medium gray
        private const int WHITE = 0xFFFFFF;            // White

        public CreateNewBookingForm(Session session)
        {
            InitializeComponent();
            _session = session;
            this.Text = $"New Booking - {session.Category}";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(700, 450);
            ApplyColorPalette();
        }

        private Color ColorFromHex(int hex)
        {
            return Color.FromArgb((hex >> 16) & 0xFF, (hex >> 8) & 0xFF, hex & 0xFF);
        }

        private void ApplyColorPalette()
        {
            this.BackColor = ColorFromHex(WHITE);

            lblTitle.ForeColor = ColorFromHex(PRIMARY_HUE);

            pnlMain.BackColor = ColorFromHex(WHITE);
            pnlMain.BorderStyle = BorderStyle.FixedSingle;

            lblBookingInfo.ForeColor = ColorFromHex(PRIMARY_HUE);
            lblMember.ForeColor = ColorFromHex(GRAY_DARK);

            cbMembers.BackColor = ColorFromHex(WHITE);
            cbMembers.ForeColor = ColorFromHex(GRAY_DARK);

            btnCreate.BackColor = ColorFromHex(PRIMARY_HUE);
            btnCreate.ForeColor = ColorFromHex(WHITE);
            btnCreate.Cursor = Cursors.Hand;

            btnBack.BackColor = ColorFromHex(GRAY_LIGHT);
            btnBack.ForeColor = ColorFromHex(PRIMARY_HUE);
            btnBack.Cursor = Cursors.Hand;
        }

        private void CreateNewBookingForm_Load(object sender, EventArgs e)
        {
            LoadMembers();
        }

        private void LoadMembers()
        {
            try
            {
                // Load all active members from database
                _members = _memberController.GetAllMembers();

                // Clear existing items
                cbMembers.Items.Clear();
                cbMembers.Items.Add("-- Select Member --");

                // Add members to dropdown
                foreach (var member in _members)
                {
                    cbMembers.Items.Add(member.Name);
                }

                cbMembers.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading members: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbMembers_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedMemberId = cbMembers.SelectedIndex > 0 ? cbMembers.SelectedIndex - 1 : -1;
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            if (_selectedMemberId < 0)
            {
                MessageBox.Show("Please select a member.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                _sessionController.AddBooking(_session.Id, _members[_selectedMemberId].Id);

                // Log activity
                _activityLogController.AddActivityLog(new Models.ActivityLog
                {
                    Action = "Booking Created",
                    Description = $"{_members[_selectedMemberId].Name} booked {_session.Category} session",
                    Category = "Booking",
                    Icon = "✓"
                });

                MessageBox.Show("Booking created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error creating booking: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}