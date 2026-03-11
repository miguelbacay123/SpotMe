using GymClassBooking.SpotMe.Controllers;
using GymClassBooking.SpotMe.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace GymClassBooking.SpotMe.View
{
    public partial class SessionMembersForm : Form
    {
        private Session _session;
        private SessionController _sessionController = new SessionController();
        private AttendanceController _attendanceController = new AttendanceController();
        private List<SessionBooking> _bookings = new List<SessionBooking>();

        // Color Palette
        private const int PRIMARY_HUE = 0x6F2C8C;      // Purple
        private const int GRAY_LIGHT = 0xF5F5F5;       // Light gray
        private const int GRAY_DARK = 0x666666;        // Dark gray
        private const int WHITE = 0xFFFFFF;            // White
        private const int GREEN_SUCCESS = 0x22B14C;    // Green
        private const int ORANGE_WARNING = 0xFFA500;   // Orange
        private const int RED_DANGER = 0xDC3545;       // Red

        public SessionMembersForm(Session session)
        {
            InitializeComponent();
            _session = session;
            this.Text = $"Session Members - {session.Category}";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(900, 600);
            ApplyColorPalette();
        }

        private Color ColorFromHex(int hex)
        {
            return Color.FromArgb((hex >> 16) & 0xFF, (hex >> 8) & 0xFF, hex & 0xFF);
        }

        private void ApplyColorPalette()
        {
            this.BackColor = ColorFromHex(WHITE);

            pnlHeader.BackColor = ColorFromHex(PRIMARY_HUE);
            lblTitle.ForeColor = ColorFromHex(WHITE);
            lblSubtitle.ForeColor = ColorFromHex(WHITE);

            // Hide "New Booking" button for Members
            btnNewBooking.Visible = CurrentUser.IsSuperAdmin() || CurrentUser.IsStaff();
            if (btnNewBooking.Visible)
            {
                btnNewBooking.BackColor = ColorFromHex(WHITE);
                btnNewBooking.ForeColor = ColorFromHex(PRIMARY_HUE);
                btnNewBooking.Cursor = Cursors.Hand;
            }

            pnlTableHeader.BackColor = ColorFromHex(GRAY_LIGHT);
            foreach (Label lbl in pnlTableHeader.Controls.OfType<Label>())
            {
                lbl.ForeColor = ColorFromHex(GRAY_DARK);
                lbl.BackColor = ColorFromHex(GRAY_LIGHT);
            }

            pnlContent.BackColor = ColorFromHex(WHITE);
            lblEmpty.ForeColor = ColorFromHex(GRAY_DARK);

            btnBack.BackColor = ColorFromHex(PRIMARY_HUE);
            btnBack.ForeColor = ColorFromHex(WHITE);
            btnBack.Cursor = Cursors.Hand;
        }

        private void SessionMembersForm_Load(object sender, EventArgs e)
        {
            LoadBookings();
        }

        private void LoadBookings()
        {
            try
            {
                _bookings = _sessionController.GetBookingsBySession(_session.Id);
                DisplayBookings();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading bookings: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayBookings()
        {
            pnlContent.Controls.Clear();

            if (_bookings.Count == 0)
            {
                pnlContent.Controls.Add(lblEmpty);
                return;
            }

            int currentY = 0;
            foreach (var booking in _bookings)
            {
                // Check if already marked present
                Attendance existingAttendance = _attendanceController.GetBookingClassAttendance(booking.MemberId, _session.Id);
                bool isMarkedPresent = existingAttendance != null && existingAttendance.Status == "Present";

                // Row Panel (container for all elements in this row)
                Panel rowPanel = new Panel();
                rowPanel.Location = new Point(0, currentY);
                rowPanel.Size = new Size(860, 45);
                rowPanel.BackColor = ColorFromHex(WHITE);
                rowPanel.BorderStyle = BorderStyle.FixedSingle;

                // Member Name
                Label lblMember = new Label();
                lblMember.Text = booking.MemberName;
                lblMember.Font = new Font("Segoe UI", 10);
                lblMember.ForeColor = ColorFromHex(GRAY_DARK);
                lblMember.Location = new Point(25, 0);
                lblMember.Size = new Size(170, 45);
                lblMember.TextAlign = ContentAlignment.MiddleLeft;
                lblMember.AutoSize = false;
                lblMember.Padding = new Padding(5, 0, 0, 0);
                rowPanel.Controls.Add(lblMember);

                // Booking DateTime
                Label lblDate = new Label();
                lblDate.Text = booking.BookingDate.ToString("M/d/yyyy, h:mm:ss tt");
                lblDate.Font = new Font("Segoe UI", 9);
                lblDate.ForeColor = ColorFromHex(GRAY_DARK);
                lblDate.Location = new Point(201, 0);
                lblDate.Size = new Size(235, 45);
                lblDate.TextAlign = ContentAlignment.MiddleLeft;
                lblDate.AutoSize = false;
                lblDate.Padding = new Padding(5, 0, 0, 0);
                rowPanel.Controls.Add(lblDate);

                // Status Label
                Label lblStatus = new Label();
                if (isMarkedPresent)
                {
                    lblStatus.Text = "Present";
                    lblStatus.ForeColor = ColorFromHex(GREEN_SUCCESS);
                }
                else
                {
                    lblStatus.Text = "Pending";
                    lblStatus.ForeColor = ColorFromHex(ORANGE_WARNING);
                }
                lblStatus.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                lblStatus.Location = new Point(456, 0);
                lblStatus.Size = new Size(80, 45);
                lblStatus.TextAlign = ContentAlignment.MiddleLeft;
                lblStatus.AutoSize = false;
                rowPanel.Controls.Add(lblStatus);

                // Mark Present Button - Only for SuperAdmin and Staff
                if (CurrentUser.IsSuperAdmin() || CurrentUser.IsStaff())
                {
                    Button btnMarkPresent = new Button();
                    btnMarkPresent.Text = isMarkedPresent ? "Marked" : "Mark Present";
                    btnMarkPresent.Font = new Font("Segoe UI", 8, FontStyle.Bold);
                    btnMarkPresent.ForeColor = ColorFromHex(WHITE);
                    btnMarkPresent.BackColor = isMarkedPresent ? ColorFromHex(GRAY_DARK) : ColorFromHex(GREEN_SUCCESS);
                    btnMarkPresent.FlatStyle = FlatStyle.Flat;
                    btnMarkPresent.FlatAppearance.BorderSize = 0;
                    btnMarkPresent.Location = new Point(677, 8);
                    btnMarkPresent.Size = new Size(85, 28);
                    btnMarkPresent.Tag = booking;
                    btnMarkPresent.Cursor = Cursors.Hand;
                    btnMarkPresent.Enabled = !isMarkedPresent;
                    btnMarkPresent.Click += (s, e) => MarkPresent(booking);
                    rowPanel.Controls.Add(btnMarkPresent);
                }

                // Cancel Button - Only for SuperAdmin and Staff
                if (CurrentUser.IsSuperAdmin() || CurrentUser.IsStaff())
                {
                    Button btnCancel = new Button();
                    btnCancel.Text = "Cancel";
                    btnCancel.Font = new Font("Segoe UI", 8, FontStyle.Bold);
                    btnCancel.ForeColor = ColorFromHex(WHITE);
                    btnCancel.BackColor = ColorFromHex(RED_DANGER);
                    btnCancel.FlatStyle = FlatStyle.Flat;
                    btnCancel.FlatAppearance.BorderSize = 0;
                    btnCancel.Location = new Point(765, 8);
                    btnCancel.Size = new Size(70, 28);
                    btnCancel.Tag = booking.Id;
                    btnCancel.Cursor = Cursors.Hand;
                    btnCancel.Click += (s, e) => CancelBooking(booking.Id);
                    rowPanel.Controls.Add(btnCancel);
                }

                pnlContent.Controls.Add(rowPanel);
                currentY += 50;
            }
        }

        private void MarkPresent(SessionBooking booking)
        {
            try
            {
                // Check if already marked
                Attendance existing = _attendanceController.GetBookingClassAttendance(booking.MemberId, _session.Id);
                if (existing != null)
                {
                    MessageBox.Show($"{booking.MemberName} is already marked present.", "Already Marked",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Create attendance record
                Attendance attendance = new Attendance
                {
                    MemberId = booking.MemberId,
                    MemberName = booking.MemberName,
                    BookingClassId = _session.Id,
                    ClassName = _session.Category,
                    CheckInTime = DateTime.Now,
                    ClassDate = _session.StartTime.Date,
                    Status = "Present"
                };

                _attendanceController.AddAttendance(attendance);

                MessageBox.Show($"{booking.MemberName} marked as present!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadBookings();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error marking attendance: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnNewBooking_Click(object sender, EventArgs e)
        {
            CreateNewBookingForm bookingForm = new CreateNewBookingForm(_session);
            if (bookingForm.ShowDialog() == DialogResult.OK)
            {
                LoadBookings();
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CancelBooking(int bookingId)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to cancel this booking?",
                "Confirm Cancel",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    _sessionController.CancelBooking(bookingId, _session.Id);
                    MessageBox.Show("Booking cancelled successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadBookings();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error cancelling booking: {ex.Message}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void lblHeaderDate_Click(object sender, EventArgs e)
        {
        }
    }
}