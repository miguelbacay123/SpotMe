using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using GymClassBooking.SpotMe.Controllers;
using GymClassBooking.SpotMe.Models;

namespace GymClassBooking.SpotMe.View
{
    public partial class Donations : Form
    {
        private DonationController donationController = new DonationController();
        private Donation currentDonation;

        // Color Palette
        private const int PRIMARY_HUE = 0x6F2C8C;      // Purple (111, 44, 140)
        private const int GRAY_LIGHT = 0xF5F5F5;       // Light gray background
        private const int GRAY_MEDIUM = 0xAAAAAA;      // Medium gray text
        private const int GRAY_DARK = 0x666666;        // Dark gray text
        private const int BORDER_GRAY = 0xE0E0E0;      // Border color
        private const int BLACK = 0x000000;            // Black text
        private const int WHITE = 0xFFFFFF;            // White background
        private const int GREEN_SUCCESS = 0x22B14C;    // Green
        private const int LIGHT_GREEN = 0x90EE90;      // Light green
        private const int YELLOW_GREEN = 0xADFF2F;     // Yellow-green
        private const int GOLD = 0xFFD700;             // Gold

        public Donations()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private Color ColorFromHex(int hex)
        {
            return Color.FromArgb((hex >> 16) & 0xFF, (hex >> 8) & 0xFF, hex & 0xFF);
        }

        private void Donations_Load(object sender, EventArgs e)
        {
            ApplyColorPalette();
            LoadDonation();
        }

        private void ApplyColorPalette()
        {
            // Left panel
            panelLeft.BackColor = ColorFromHex(0x1a1a1a); // Dark background for image

            // Right panel
            panelRight.BackColor = ColorFromHex(WHITE);

            // Logo and title
            label1.ForeColor = ColorFromHex(PRIMARY_HUE);

            // Text labels
            lblSubtitle.ForeColor = ColorFromHex(GRAY_DARK);
            lblTitle.ForeColor = ColorFromHex(PRIMARY_HUE);
            lblDescription.ForeColor = ColorFromHex(GRAY_DARK);
            lblCategory.ForeColor = ColorFromHex(GRAY_MEDIUM);
            lblAmountRaised.ForeColor = ColorFromHex(PRIMARY_HUE);
            lblGoal.ForeColor = ColorFromHex(GRAY_MEDIUM);

            // Progress bar background
            panelProgressBar.BackColor = ColorFromHex(GRAY_LIGHT);

            // Edit button
            btnEdit.BackColor = ColorFromHex(PRIMARY_HUE);
            btnEdit.ForeColor = ColorFromHex(WHITE);
            btnEdit.FlatAppearance.BorderColor = ColorFromHex(PRIMARY_HUE);
            btnEdit.Cursor = Cursors.Hand;
        }

        private void LoadDonation()
        {
            var donations = donationController.GetAllDonations();
            if (donations.Count > 0)
            {
                currentDonation = donations[0];
                UpdateUI();
            }
        }

        private void UpdateUI()
        {
            if (currentDonation == null) return;

            lblTitle.Text = currentDonation.Title;
            lblDescription.Text = currentDonation.Description;
            lblCategory.Text = $"Category: {currentDonation.Category}";
            lblAmountRaised.Text = $"₱{currentDonation.CurrentAmount:F2} raised";
            lblGoal.Text = $"Goal: ₱{currentDonation.GoalAmount:F2}";

            // Update progress bar
            int progressWidth = (int)(panelProgressBar.Width * ((double)currentDonation.PercentageRaised / 100.0));
            panelProgressFill.Width = Math.Max(progressWidth, 0);

            // Change color based on percentage using color palette
            if (currentDonation.PercentageRaised >= 100)
                panelProgressFill.BackColor = ColorFromHex(GREEN_SUCCESS); // Green
            else if (currentDonation.PercentageRaised >= 75)
                panelProgressFill.BackColor = ColorFromHex(LIGHT_GREEN); // Light green
            else if (currentDonation.PercentageRaised >= 50)
                panelProgressFill.BackColor = ColorFromHex(YELLOW_GREEN); // Yellow-green
            else if (currentDonation.PercentageRaised >= 25)
                panelProgressFill.BackColor = ColorFromHex(GOLD); // Gold
            else
                panelProgressFill.BackColor = ColorFromHex(PRIMARY_HUE); // Purple
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (currentDonation == null) return;

            Form editForm = new Form
            {
                Text = $"Edit - {currentDonation.Title}",
                Width = 450,
                Height = 280,
                StartPosition = FormStartPosition.CenterParent,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                MaximizeBox = false,
                MinimizeBox = false,
                BackColor = ColorFromHex(WHITE)
            };

            Label lblAmount = new Label
            {
                Text = "Current Amount Raised (₱):",
                Location = new Point(20, 30),
                Width = 340,
                Font = new Font("Segoe UI", 10F),
                ForeColor = ColorFromHex(GRAY_DARK)
            };

            TextBox txtAmount = new TextBox
            {
                Location = new Point(20, 60),
                Width = 340,
                Text = currentDonation.CurrentAmount.ToString("F2"),
                Font = new Font("Segoe UI", 11F),
                BorderStyle = BorderStyle.FixedSingle
            };

            Label lblGoal = new Label
            {
                Text = "Goal Amount (₱):",
                Location = new Point(20, 100),
                Width = 340,
                Font = new Font("Segoe UI", 10F),
                ForeColor = ColorFromHex(GRAY_DARK)
            };

            TextBox txtGoal = new TextBox
            {
                Location = new Point(20, 130),
                Width = 340,
                Text = currentDonation.GoalAmount.ToString("F2"),
                Font = new Font("Segoe UI", 11F),
                BorderStyle = BorderStyle.FixedSingle
            };

            Button btnSave = new Button
            {
                Text = "💾 Save",
                Location = new Point(130, 180),
                Width = 110,
                Height = 35,
                BackColor = ColorFromHex(PRIMARY_HUE),
                ForeColor = ColorFromHex(WHITE),
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                DialogResult = DialogResult.OK,
                Cursor = Cursors.Hand
            };
            btnSave.FlatAppearance.BorderSize = 0;

            Button btnCancel = new Button
            {
                Text = "✕ Cancel",
                Location = new Point(250, 180),
                Width = 110,
                Height = 35,
                BackColor = ColorFromHex(GRAY_LIGHT),
                ForeColor = ColorFromHex(GRAY_DARK),
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 10F),
                DialogResult = DialogResult.Cancel,
                Cursor = Cursors.Hand
            };
            btnCancel.FlatAppearance.BorderSize = 0;

            editForm.Controls.Add(lblAmount);
            editForm.Controls.Add(txtAmount);
            editForm.Controls.Add(lblGoal);
            editForm.Controls.Add(txtGoal);
            editForm.Controls.Add(btnSave);
            editForm.Controls.Add(btnCancel);

            if (editForm.ShowDialog() == DialogResult.OK)
            {
                bool isValid = true;
                decimal newAmount = 0;
                decimal newGoal = 0;

                if (!decimal.TryParse(txtAmount.Text, out newAmount))
                {
                    MessageBox.Show("Please enter a valid amount for Current Amount.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    isValid = false;
                }

                if (!decimal.TryParse(txtGoal.Text, out newGoal))
                {
                    MessageBox.Show("Please enter a valid amount for Goal.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    isValid = false;
                }

                if (newGoal <= 0)
                {
                    MessageBox.Show("Goal amount must be greater than 0.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    isValid = false;
                }

                if (isValid)
                {
                    currentDonation.CurrentAmount = newAmount;
                    currentDonation.GoalAmount = newGoal;
                    donationController.UpdateDonation(currentDonation);
                    UpdateUI();
                    MessageBox.Show($"✓ Updated!\nRaised: ₱{newAmount:F2}\nGoal: ₱{newGoal:F2}", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}