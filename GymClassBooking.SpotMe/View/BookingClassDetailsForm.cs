using System;
using System.Drawing;
using System.Windows.Forms;
using GymClassBooking.SpotMe.Controls;
using GymClassBooking.SpotMe.Models;

namespace GymClassBooking.SpotMe.View
{
    public partial class BookingClassDetailsForm : Form
    {
        private BookingClass _bookingClass;

        // Color Palette
        private const int PRIMARY_HUE = 0x6F2C8C;      // Purple
        private const int GRAY_LIGHT = 0xF5F5F5;       // Light gray
        private const int GRAY_DARK = 0x666666;        // Dark gray
        private const int WHITE = 0xFFFFFF;            // White
        private const int GREEN_SUCCESS = 0x22B14C;    // Green
        private const int ORANGE_WARNING = 0xFFA500;   // Orange

        public BookingClassDetailsForm(BookingClass bookingClass)
        {
            InitializeComponent();
            _bookingClass = bookingClass;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Class Details";
            ApplyColorPalette();
            LoadClassDetails();
        }

        private Color ColorFromHex(int hex)
        {
            return Color.FromArgb((hex >> 16) & 0xFF, (hex >> 8) & 0xFF, hex & 0xFF);
        }

        private void ApplyColorPalette()
        {
            this.BackColor = ColorFromHex(WHITE);

            // Header panel
            panelHeader.BackColor = ColorFromHex(PRIMARY_HUE);
            iconCategory.ForeColor = ColorFromHex(WHITE);
            lblCategory.ForeColor = ColorFromHex(WHITE);

            // Content panel
            panelContent.BackColor = ColorFromHex(WHITE);

            // Labels
            lblDescriptionLabel.ForeColor = ColorFromHex(GRAY_DARK);
            lblDescription.ForeColor = ColorFromHex(PRIMARY_HUE);

            lblTrainerLabel.ForeColor = ColorFromHex(GRAY_DARK);
            lblTrainer.ForeColor = ColorFromHex(GRAY_DARK);

            lblCapacityLabel.ForeColor = ColorFromHex(GRAY_DARK);
            lblCapacity.ForeColor = ColorFromHex(GRAY_DARK);

            lblStartTimeLabel.ForeColor = ColorFromHex(GRAY_DARK);
            lblStartTime.ForeColor = ColorFromHex(PRIMARY_HUE);

            lblEndTimeLabel.ForeColor = ColorFromHex(GRAY_DARK);
            lblEndTime.ForeColor = ColorFromHex(PRIMARY_HUE);

            lblDurationLabel.ForeColor = ColorFromHex(GRAY_DARK);
            lblDuration.ForeColor = ColorFromHex(GRAY_DARK);

            // Icon colors
            iconTrainer.ForeColor = ColorFromHex(PRIMARY_HUE);
            iconCapacity.ForeColor = ColorFromHex(PRIMARY_HUE);
            iconStartTime.ForeColor = ColorFromHex(PRIMARY_HUE);
            iconEndTime.ForeColor = ColorFromHex(PRIMARY_HUE);
            iconDuration.ForeColor = ColorFromHex(PRIMARY_HUE);

            // Panels
            panelRow1.BackColor = ColorFromHex(WHITE);
            panelRow2.BackColor = ColorFromHex(WHITE);
            panel1.BackColor = ColorFromHex(WHITE);

            // Button
            btnBackToList.NormalColor = ColorFromHex(WHITE);
            btnBackToList.HoverColor = ColorFromHex(GRAY_LIGHT);
            btnBackToList.ForeColor = ColorFromHex(PRIMARY_HUE);
            btnBackToList.FlatAppearance.BorderColor = ColorFromHex(PRIMARY_HUE);
        }

        private void LoadClassDetails()
        {
            lblCategory.Text = _bookingClass.Category;
            lblStatus.Text = _bookingClass.Status.ToUpper();
            lblStatus.BackColor = _bookingClass.Status == "Upcoming" ? ColorFromHex(PRIMARY_HUE) : ColorFromHex(ORANGE_WARNING);
            lblStatus.ForeColor = ColorFromHex(WHITE);
            lblDescription.Text = _bookingClass.Description;
            lblTrainer.Text = _bookingClass.TrainerName;
            lblCapacity.Text = $"{_bookingClass.BookedCount}/{_bookingClass.Capacity} spots";
            lblStartTime.Text = _bookingClass.StartTime.ToString("M/d/yyyy, h:mm:ss tt");
            lblEndTime.Text = _bookingClass.EndTime.ToString("M/d/yyyy, h:mm:ss tt");

            TimeSpan duration = _bookingClass.EndTime - _bookingClass.StartTime;
            lblDuration.Text = $"{(int)duration.TotalHours} Hours {duration.Minutes} Minutes";
        }

        private void btnBackToList_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelRow1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void iconStartTime_Click(object sender, EventArgs e)
        {
        }

        private void lblDuration_Click(object sender, EventArgs e)
        {
        }

        private void lblDurationLabel_Click(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}