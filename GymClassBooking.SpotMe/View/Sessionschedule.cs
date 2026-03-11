using GymClassBooking.SpotMe.Controllers;
using GymClassBooking.SpotMe.Controls;
using GymClassBooking.SpotMe.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace GymClassBooking.SpotMe.View
{
    public partial class Sessionschedule : Form
    {
        private List<Session> sessions = new List<Session>();
        private SessionController sessionController = new SessionController();
        private ActivityLogController activityLogController = new ActivityLogController();
        private bool _loaded = false;
        private Panel contentPanel;

        // Color Palette
        private const int PRIMARY_HUE = 0x6F2C8C;      // Purple (111, 44, 140)
        private const int GRAY_LIGHT = 0xF5F5F5;       // Light gray background
        private const int GRAY_MEDIUM = 0xAAAAAA;      // Medium gray text
        private const int GRAY_DARK = 0x666666;        // Dark gray text
        private const int BORDER_GRAY = 0xE0E0E0;      // Border color
        private const int BLACK = 0x000000;            // Black text
        private const int WHITE = 0xFFFFFF;            // White background
        private const int RED_DELETE = 0xCD5C5C;       // Indian Red for delete

        public Sessionschedule()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private Color ColorFromHex(int hex)
        {
            return Color.FromArgb((hex >> 16) & 0xFF, (hex >> 8) & 0xFF, hex & 0xFF);
        }

        private void Sessionschedule_Load(object sender, EventArgs e)
        {
            ApplyColorPalette();

            panelSessionsContainer.AutoScroll = true;
            panelSessionsContainer.HorizontalScroll.Enabled = false;
            panelSessionsContainer.HorizontalScroll.Visible = false;
            panelSessionsContainer.VerticalScroll.Enabled = true;

            _loaded = true;
            LoadSessions();

            panelSessionsContainer.Resize += (s, resizeArgs) => { if (_loaded) RefreshSessionDisplay(); };
        }

        private void ApplyColorPalette()
        {
            // Main form
            this.BackColor = ColorFromHex(WHITE);

            // Top panel with logo
            panel1.BackColor = ColorFromHex(0xF9F5FF); // Light purple tint
            label1.ForeColor = ColorFromHex(PRIMARY_HUE);

            // Content panel
            panelContent.BackColor = ColorFromHex(WHITE);

            // Header labels
            lblPageTitle.ForeColor = ColorFromHex(PRIMARY_HUE);
            lblPageSubtitle.ForeColor = ColorFromHex(GRAY_MEDIUM);

            // Sessions container
            panelSessionsContainer.BackColor = ColorFromHex(GRAY_LIGHT);

            // Navigation buttons
            foreach (RoundedButton btn in new[] { Home, Members, Trainers, ClassBooking, btnSessionSchedule, More })
            {
                btn.NormalColor = ColorFromHex(WHITE);
                btn.HoverColor = ColorFromHex(PRIMARY_HUE);
                btn.ForeColor = ColorFromHex(GRAY_DARK);
            }
        }

        private void LoadSessions()
        {
            sessions = sessionController.GetAllSessions();
            RefreshSessionDisplay();
        }

        private void RefreshSessionDisplay()
        {
            if (panelSessionsContainer == null) return;

            panelSessionsContainer.Controls.Clear();

            if (sessions.Count == 0)
            {
                Label lblNoSessions = new Label
                {
                    Text = "No sessions found.",
                    Font = new Font("Segoe UI", 12, FontStyle.Italic),
                    ForeColor = ColorFromHex(GRAY_MEDIUM),
                    Location = new Point(20, 20),
                    Size = new Size(500, 30),
                    TextAlign = ContentAlignment.MiddleLeft
                };
                panelSessionsContainer.Controls.Add(lblNoSessions);
                return;
            }

            int margin = 15;
            int cardsPerRow = 3;
            int scrollbarWidth = 17;
            int availableWidth = panelSessionsContainer.ClientSize.Width - scrollbarWidth;
            int cardWidth = (availableWidth - (margin * (cardsPerRow + 1))) / cardsPerRow;

            contentPanel = new Panel
            {
                BackColor = Color.Transparent,
                AutoSize = false,
                Location = new Point(0, 0)
            };

            List<Panel> allCards = new List<Panel>();
            List<int> cardHeights = new List<int>();

            for (int i = 0; i < sessions.Count; i++)
            {
                Panel card = CreateSessionCard(sessions[i], cardWidth);
                allCards.Add(card);
                cardHeights.Add(card.Height);
            }

            int currentY = margin;
            int maxWidth = 0;

            for (int row = 0; row < (sessions.Count + cardsPerRow - 1) / cardsPerRow; row++)
            {
                int rowStart = row * cardsPerRow;
                int rowEnd = Math.Min(rowStart + cardsPerRow, sessions.Count);

                int maxHeightInRow = 0;
                for (int i = rowStart; i < rowEnd; i++)
                {
                    if (cardHeights[i] > maxHeightInRow)
                        maxHeightInRow = cardHeights[i];
                }

                for (int col = 0; col < cardsPerRow && rowStart + col < sessions.Count; col++)
                {
                    int cardIndex = rowStart + col;
                    int xPos = margin + col * (cardWidth + margin);
                    int yPos = currentY;

                    Panel card = allCards[cardIndex];
                    card.Location = new Point(xPos, yPos);
                    contentPanel.Controls.Add(card);

                    if (xPos + cardWidth + margin > maxWidth)
                        maxWidth = xPos + cardWidth + margin;
                }

                currentY += maxHeightInRow + margin;
            }

            contentPanel.Size = new Size(maxWidth, currentY);
            panelSessionsContainer.Controls.Add(contentPanel);
        }

        private Panel CreateSessionCard(Session session, int width)
        {
            Panel cardPanel = new Panel();
            cardPanel.BackColor = ColorFromHex(WHITE);
            cardPanel.BorderStyle = BorderStyle.FixedSingle;
            cardPanel.Name = "cardPanel" + Guid.NewGuid().ToString();
            cardPanel.Tag = session;
            cardPanel.Width = width;

            int currentY = 15;
            int leftMargin = 15;
            int rightMargin = 15;
            int contentWidth = width - (leftMargin + rightMargin);

            // Category Label
            Label lblCategory = new Label();
            lblCategory.Text = session.Category;
            lblCategory.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            lblCategory.ForeColor = ColorFromHex(PRIMARY_HUE);
            lblCategory.Location = new Point(leftMargin, currentY);
            lblCategory.Size = new Size(contentWidth, 25);
            lblCategory.TextAlign = ContentAlignment.MiddleLeft;
            cardPanel.Controls.Add(lblCategory);
            currentY += 30;

            // Description
            string displayDesc = session.Description;
            if (!string.IsNullOrEmpty(displayDesc) && displayDesc.Length > 30)
                displayDesc = displayDesc.Substring(0, 27) + "...";

            Label lblDescription = new Label();
            lblDescription.Text = displayDesc ?? "No description";
            lblDescription.Font = new Font("Segoe UI", 9, FontStyle.Italic);
            lblDescription.ForeColor = ColorFromHex(GRAY_MEDIUM);
            lblDescription.Location = new Point(leftMargin, currentY);
            lblDescription.Size = new Size(contentWidth, 20);
            cardPanel.Controls.Add(lblDescription);
            currentY += 25;

            // Trainer
            Label lblTrainer = new Label();
            lblTrainer.Text = $"Trainer: {session.TrainerName}";
            lblTrainer.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            lblTrainer.ForeColor = ColorFromHex(GRAY_DARK);
            lblTrainer.Location = new Point(leftMargin, currentY);
            lblTrainer.Size = new Size(contentWidth, 20);
            cardPanel.Controls.Add(lblTrainer);
            currentY += 20;

            // Date
            Label lblDate = new Label();
            lblDate.Text = $"Date: {session.StartTime:M/d/yyyy}";
            lblDate.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            lblDate.ForeColor = ColorFromHex(GRAY_DARK);
            lblDate.Location = new Point(leftMargin, currentY);
            lblDate.Size = new Size(contentWidth, 20);
            cardPanel.Controls.Add(lblDate);
            currentY += 20;

            // Time
            Label lblTime = new Label();
            lblTime.Text = $"Time: {session.StartTime:hh:mm tt} - {session.EndTime:hh:mm tt}";
            lblTime.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            lblTime.ForeColor = ColorFromHex(GRAY_DARK);
            lblTime.Location = new Point(leftMargin, currentY);
            lblTime.Size = new Size(contentWidth, 20);
            cardPanel.Controls.Add(lblTime);
            currentY += 20;

            // Duration
            TimeSpan duration = session.EndTime - session.StartTime;
            Label lblDuration = new Label();
            lblDuration.Text = $"Duration: {duration:hh\\:mm}";
            lblDuration.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            lblDuration.ForeColor = ColorFromHex(GRAY_DARK);
            lblDuration.Location = new Point(leftMargin, currentY);
            lblDuration.Size = new Size(contentWidth, 20);
            cardPanel.Controls.Add(lblDuration);
            currentY += 20;

            // Status Badge
            Label lblStatus = new Label();
            lblStatus.Text = $"Status: {session.GetCurrentStatus()}";
            lblStatus.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            string status = session.GetCurrentStatus();
            int statusColor = status == "Upcoming" ? PRIMARY_HUE :
                             status == "Ongoing" ? 0x00AA00 :
                             0x666666;
            lblStatus.ForeColor = ColorFromHex(statusColor);
            lblStatus.Location = new Point(leftMargin, currentY);
            lblStatus.Size = new Size(contentWidth, 20);
            cardPanel.Controls.Add(lblStatus);
            currentY += 20;

            // Capacity
            Label lblCapacity = new Label();
            lblCapacity.Text = $"Capacity: {session.BookedCount}/{session.Capacity} slots";
            lblCapacity.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            lblCapacity.ForeColor = session.BookedCount >= session.Capacity
                ? ColorFromHex(RED_DELETE)
                : ColorFromHex(PRIMARY_HUE);
            lblCapacity.Location = new Point(leftMargin, currentY);
            lblCapacity.Size = new Size(contentWidth, 20);
            cardPanel.Controls.Add(lblCapacity);
            currentY += 30;

            // View Members Button - Visible for all roles (Members see read-only list)
            Button btnViewMembers = new Button();
            btnViewMembers.Text = "👥 View Members";
            btnViewMembers.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            btnViewMembers.ForeColor = ColorFromHex(PRIMARY_HUE);
            btnViewMembers.BackColor = ColorFromHex(WHITE);
            btnViewMembers.FlatStyle = FlatStyle.Flat;
            btnViewMembers.FlatAppearance.BorderColor = ColorFromHex(PRIMARY_HUE);
            btnViewMembers.FlatAppearance.BorderSize = 1;
            btnViewMembers.Location = new Point(leftMargin, currentY);
            btnViewMembers.Size = new Size(contentWidth, 28);
            btnViewMembers.Tag = session;
            btnViewMembers.Cursor = Cursors.Hand;
            btnViewMembers.Click += BtnViewMembers_Click;
            cardPanel.Controls.Add(btnViewMembers);
            currentY += 33;

            cardPanel.Size = new Size(width, currentY + 15);

            return cardPanel;
        }

        private void BtnViewMembers_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn == null) return;

            Session session = btn.Tag as Session;
            if (session == null) return;

            SessionMembersForm membersForm = new SessionMembersForm(session);
            membersForm.ShowDialog();
            LoadSessions();
            RefreshMainDashboard();
        }

        private void RefreshMainDashboard()
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is MainDashboard dashboard)
                {
                    dashboard.RefreshActivityData();
                    break;
                }
            }
        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
                if (form is MainDashboard) { form.Show(); break; }
            this.Close();
        }

        private void roundedButton2_Click(object sender, EventArgs e)
        {
            new MemberManagement().Show();
            this.Hide();
        }

        private void roundedButton3_Click(object sender, EventArgs e)
        {
            new TrainerManagement().Show();
            this.Hide();
        }

        private void roundedButton4_Click(object sender, EventArgs e)
        {
            new ClassBooking().Show();
            this.Hide();
        }

        private void roundedButton5_Click(object sender, EventArgs e)
        {
            LoadSessions();
        }

        private void roundedButton6_Click(object sender, EventArgs e)
        {
            try
            {
                ContextMenuStrip moreMenu = new ContextMenuStrip();
                moreMenu.Font = new Font("Segoe UI", 11, FontStyle.Regular);
                moreMenu.BackColor = ColorFromHex(WHITE);
                moreMenu.RenderMode = ToolStripRenderMode.Professional;
                moreMenu.ShowImageMargin = true;
                moreMenu.ImageScalingSize = new Size(24, 24);
                moreMenu.Width = 180;
                moreMenu.AutoClose = true;

                moreMenu.Items.Add("Donations");
                moreMenu.Items.Add("Partnerships");

                if (CurrentUser.IsSuperAdmin())
                {
                    moreMenu.Items.Add("Manage Staff");
                }

                moreMenu.Items.Add(new ToolStripSeparator());
                moreMenu.Items.Add("Logout");

                foreach (ToolStripItem item in moreMenu.Items)
                {
                    if (item is ToolStripMenuItem menuItem)
                    {
                        menuItem.Click += MoreMenuItem_Click;
                        menuItem.Height = 35;
                    }
                }

                if (sender is Button moreButton)
                    moreMenu.Show(moreButton, new Point(0, moreButton.Height));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error showing dropdown: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MoreMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ToolStripMenuItem clickedItem = sender as ToolStripMenuItem;
                if (clickedItem != null)
                {
                    string option = clickedItem.Text;

                    switch (option)
                    {
                        case "Donations":
                            Donations donationsForm = new Donations();
                            donationsForm.ShowDialog();
                            break;

                        case "Partnerships":
                            PartnershipsForm partnershipsForm = new PartnershipsForm();
                            partnershipsForm.ShowDialog();
                            break;

                        case "Manage Staff":
                            if (CurrentUser.IsSuperAdmin())
                            {
                                ManageStaffForm staffForm = new ManageStaffForm();
                                staffForm.ShowDialog();
                            }
                            else
                            {
                                MessageBox.Show("You don't have permission to access this feature.",
                                    "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            break;

                        case "Logout":
                            DialogResult result = MessageBox.Show("Are you sure you want to logout?",
                                "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            if (result == DialogResult.Yes)
                            {
                                CurrentUser.Logout();
                                this.Close();
                            }
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error handling menu click: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}