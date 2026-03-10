using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using GymClassBooking.SpotMe.Models;
using GymClassBooking.SpotMe.Controllers;

namespace GymClassBooking.SpotMe.View
{
    public partial class AddBookingClassForm : Form
    {
        public int TrainerId { get; set; }
        public int ClassId { get; set; }
        private List<Trainer> _trainers;
        private TrainerController _trainerController = new TrainerController();

        // Color Palette
        private const int PRIMARY_HUE = 0x6F2C8C;      // Purple
        private const int GRAY_LIGHT = 0xF5F5F5;       // Light gray
        private const int GRAY_MEDIUM = 0xAAAAAA;      // Medium gray
        private const int GRAY_DARK = 0x666666;        // Dark gray
        private const int BLACK = 0x000000;            // Black
        private const int WHITE = 0xFFFFFF;            // White

        public string ClassCategory => cboCategory.Text;
        public string TrainerName => cboTrainer.Text;
        public string Description => txtDescription.Text;
        public int Capacity => (int)nudCapacity.Value;
        public DateTime StartTime => dtpStartDate.Value.Date +
                                      new TimeSpan(GetHour24(cboStartHour.Text, cboStartAmPm.Text),
                                                   int.Parse(cboStartMinute.Text), 0);
        public DateTime EndTime => dtpEndDate.Value.Date +
                                    new TimeSpan(GetHour24(cboEndHour.Text, cboEndAmPm.Text),
                                                 int.Parse(cboEndMinute.Text), 0);

        public AddBookingClassForm()
        {
            InitializeComponent();
            ApplyColorPalette();
            LoadCategories();
            LoadTrainers();
            PopulateTimeDropdowns();
        }

        private Color ColorFromHex(int hex)
        {
            return Color.FromArgb((hex >> 16) & 0xFF, (hex >> 8) & 0xFF, hex & 0xFF);
        }

        private void ApplyColorPalette()
        {
            this.BackColor = ColorFromHex(WHITE);

            lblTitle.ForeColor = ColorFromHex(PRIMARY_HUE);
            lblSessionInfo.ForeColor = ColorFromHex(PRIMARY_HUE);
            lblDateAndTime.ForeColor = ColorFromHex(PRIMARY_HUE);

            lblCategory.ForeColor = ColorFromHex(GRAY_DARK);
            lblTrainer.ForeColor = ColorFromHex(GRAY_DARK);
            lblDescription.ForeColor = ColorFromHex(GRAY_DARK);
            lblCapacity.ForeColor = ColorFromHex(GRAY_DARK);
            lblStartDateTime.ForeColor = ColorFromHex(GRAY_DARK);
            lblEndDateTime.ForeColor = ColorFromHex(GRAY_DARK);

            btnSave.NormalColor = ColorFromHex(PRIMARY_HUE);
            btnSave.HoverColor = ColorFromHex(0x9B6BA6);
            btnSave.ForeColor = ColorFromHex(WHITE);

            btnCancel.NormalColor = ColorFromHex(GRAY_LIGHT);
            btnCancel.HoverColor = ColorFromHex(PRIMARY_HUE);
            btnCancel.ForeColor = ColorFromHex(GRAY_DARK);
        }

        private void LoadCategories()
        {
            cboCategory.Items.Clear();
            cboCategory.Items.AddRange(new object[] {
                "Select Category", "Yoga", "Boxing", "CrossFit", "General Fitness"
            });
            cboCategory.SelectedIndex = 0;
        }

        private void LoadTrainers()
        {
            try
            {
                _trainers = _trainerController.GetAllTrainers();
                cboTrainer.Items.Clear();
                cboTrainer.Items.Add("Select Trainer");

                foreach (var trainer in _trainers)
                {
                    cboTrainer.Items.Add(trainer.Name);
                }

                cboTrainer.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading trainers: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PopulateTimeDropdowns()
        {
            // Populate hours (1-12)
            for (int i = 1; i <= 12; i++)
            {
                cboStartHour.Items.Add(i.ToString("00"));
                cboEndHour.Items.Add(i.ToString("00"));
            }
            cboStartHour.SelectedIndex = 9; // 10
            cboEndHour.SelectedIndex = 10;  // 11

            // Populate minutes (00-59)
            for (int i = 0; i < 60; i++)
            {
                cboStartMinute.Items.Add(i.ToString("00"));
                cboEndMinute.Items.Add(i.ToString("00"));
            }
            cboStartMinute.SelectedIndex = 0; // 00
            cboEndMinute.SelectedIndex = 0;    // 00

            // AM/PM
            cboStartAmPm.SelectedIndex = 0; // AM
            cboEndAmPm.SelectedIndex = 1;    // PM
        }

        private int GetHour24(string hour12, string ampm)
        {
            int hour = int.Parse(hour12);
            if (ampm == "PM" && hour != 12) hour += 12;
            if (ampm == "AM" && hour == 12) hour = 0;
            return hour;
        }

        public void LoadClassData(BookingClass bookingClass)
        {
            if (bookingClass == null) return;

            this.ClassId = bookingClass.Id;
            this.TrainerId = bookingClass.TrainerId;

            int categoryIndex = cboCategory.FindStringExact(bookingClass.Category);
            if (categoryIndex >= 0)
                cboCategory.SelectedIndex = categoryIndex;

            int trainerIndex = cboTrainer.FindStringExact(bookingClass.TrainerName);
            if (trainerIndex >= 0)
                cboTrainer.SelectedIndex = trainerIndex;

            txtDescription.Text = bookingClass.Description;
            nudCapacity.Value = bookingClass.Capacity;

            dtpStartDate.Value = bookingClass.StartTime;
            dtpEndDate.Value = bookingClass.EndTime;

            // Parse time components
            int startHour24 = bookingClass.StartTime.Hour;
            int startMinute = bookingClass.StartTime.Minute;
            int endHour24 = bookingClass.EndTime.Hour;
            int endMinute = bookingClass.EndTime.Minute;

            // Set start time dropdowns
            cboStartHour.SelectedIndex = startHour24 % 12 == 0 ? 11 : (startHour24 % 12) - 1;
            cboStartMinute.SelectedIndex = startMinute;
            cboStartAmPm.SelectedIndex = startHour24 >= 12 ? 1 : 0;

            // Set end time dropdowns
            cboEndHour.SelectedIndex = endHour24 % 12 == 0 ? 11 : (endHour24 % 12) - 1;
            cboEndMinute.SelectedIndex = endMinute;
            cboEndAmPm.SelectedIndex = endHour24 >= 12 ? 1 : 0;

            // Change button text to "Update"
            btnSave.Text = "✏️ Update";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cboCategory.SelectedIndex <= 0)
            {
                MessageBox.Show("Please select a category.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cboTrainer.SelectedIndex <= 0)
            {
                MessageBox.Show("Please select a trainer.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                MessageBox.Show("Please enter a description.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (EndTime <= StartTime)
            {
                MessageBox.Show("End time must be after start time.", "Invalid Schedule",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
        }
    }
}