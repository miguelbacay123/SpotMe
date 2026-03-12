using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GymClassBooking.SpotMe.View;
using GymClassBooking.SpotMe.Controllers;
using GymClassBooking.SpotMe.Models;

namespace GymClassBooking.SpotMe
{
    public partial class MainDashboard : Form
    {
        private MemberController memberController = new MemberController();
        private SessionController sessionController = new SessionController();
        private TrainerController trainerController = new TrainerController();
        private ActivityLogController activityLogController = new ActivityLogController();
        private Timer refreshTimer;

        private const int PRIMARY_HUE = 0x6F2C8C;
        private const int GRAY_LIGHT = 0xF5F5F5;
        private const int GRAY_MEDIUM = 0xAAAAAA;
        private const int GRAY_DARK = 0x666666;
        private const int BORDER_GRAY = 0xE0E0E0;
        private const int GRID_GRAY = 0xD0D0D0;
        private const int BLACK = 0x000000;
        private const int WHITE = 0xFFFFFF;

        public MainDashboard()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (refreshTimer != null)
            {
                refreshTimer.Stop();
                refreshTimer.Dispose();
            }
            Environment.Exit(0);
            base.OnFormClosing(e);
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style &= ~0x100000;
                return cp;
            }
        }

        private Color ColorFromHex(int hex)
        {
            return Color.FromArgb((hex >> 16) & 0xFF, (hex >> 8) & 0xFF, hex & 0xFF);
        }

        private void MainDashboard_Load(object sender, EventArgs e)
        {
            LoadDashboardStatistics();
            LoadActivityLogs();
            LoadActivityChart();
        }

        public void RefreshActivityData()
        {
            LoadActivityLogs();
            LoadActivityChart();
        }

        private void LoadDashboardStatistics()
        {
            try
            {
                List<Member> allMembers = memberController.GetAllMembers();
                List<Session> allSessions = sessionController.GetAllSessions();
                List<Trainer> allTrainers = trainerController.GetAllTrainers();

                int upcomingSessions = 0, ongoingSessions = 0, completedSessions = 0;
                foreach (var session in allSessions)
                {
                    string status = session.GetCurrentStatus();
                    if (status == "Upcoming") upcomingSessions++;
                    else if (status == "Ongoing") ongoingSessions++;
                    else if (status == "Completed") completedSessions++;
                }

                lblTotalMembersNum.Text = allMembers.Count.ToString();
                lblActiveMembersNum.Text = allMembers.Count.ToString();
                lblTrainersNum.Text = allTrainers.Count.ToString();
                lblUpcomingNum.Text = upcomingSessions.ToString();
                lblOngoingNum.Text = ongoingSessions.ToString();
                lblCompletedNum.Text = completedSessions.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void LoadActivityLogs()
        {
            try
            {
                panelActivityLogs.Controls.Clear();

                var lblTitle = new Label
                {
                    Text = "Recent Activity",
                    Font = new Font("Segoe UI", 13F, FontStyle.Bold),
                    ForeColor = ColorFromHex(PRIMARY_HUE),
                    Location = new Point(15, 10),
                    Size = new Size(300, 28),
                    AutoSize = false
                };
                panelActivityLogs.Controls.Add(lblTitle);

                var lblSubtitle = new Label
                {
                    Text = "Latest updates",
                    Font = new Font("Segoe UI", 9F),
                    ForeColor = ColorFromHex(GRAY_MEDIUM),
                    Location = new Point(15, 38),
                    Size = new Size(300, 20),
                    AutoSize = false
                };
                panelActivityLogs.Controls.Add(lblSubtitle);

                var activities = activityLogController.GetRecentActivities(6);
                int yPos = 70;

                foreach (var activity in activities)
                {
                    Panel panel = new Panel
                    {
                        BackColor = ColorFromHex(WHITE),
                        Location = new Point(10, yPos),
                        Size = new Size(345, 65),
                        BorderStyle = BorderStyle.FixedSingle
                    };

                    panel.Controls.Add(new Label { Text = activity.Icon, Font = new Font("Segoe UI", 16F, FontStyle.Bold), ForeColor = ColorFromHex(PRIMARY_HUE), Location = new Point(10, 8), Size = new Size(30, 50), TextAlign = ContentAlignment.MiddleCenter });
                    panel.Controls.Add(new Label { Text = activity.Action, Font = new Font("Segoe UI", 10F, FontStyle.Bold), ForeColor = ColorFromHex(BLACK), Location = new Point(50, 8), Size = new Size(250, 18), AutoSize = false });
                    panel.Controls.Add(new Label { Text = activity.Description, Font = new Font("Segoe UI", 8F), ForeColor = ColorFromHex(GRAY_MEDIUM), Location = new Point(50, 28), Size = new Size(250, 30), AutoSize = false });
                    panel.Controls.Add(new Label { Text = activity.TimeAgo, Font = new Font("Segoe UI", 8F), ForeColor = ColorFromHex(GRAY_LIGHT), Location = new Point(290, 8), Size = new Size(40, 50), TextAlign = ContentAlignment.TopRight, AutoSize = false });

                    panelActivityLogs.Controls.Add(panel);
                    yPos += 70;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void LoadActivityChart()
        {
            try
            {
                panelActivityChart.Controls.Clear();

                panelActivityChart.Controls.Add(new Label
                {
                    Text = "Activity - Last 7 Days",
                    Font = new Font("Segoe UI", 12F, FontStyle.Bold),
                    ForeColor = ColorFromHex(PRIMARY_HUE),
                    Location = new Point(20, 15),
                    Size = new Size(300, 25),
                    AutoSize = false
                });

                var totalActivities = activityLogController.GetActivityChartData().Values.Sum();
                panelActivityChart.Controls.Add(new Label
                {
                    Text = $"Total: {totalActivities} activities",
                    Font = new Font("Segoe UI", 9F),
                    ForeColor = ColorFromHex(GRAY_MEDIUM),
                    Location = new Point(20, 40),
                    Size = new Size(300, 20),
                    AutoSize = false
                });

                DrawBarChart();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void DrawBarChart()
        {
            var rawData = activityLogController.GetActivityChartData(7);

            var dayOrder = new[] { "Sat", "Mon", "Tue", "Wed", "Thu", "Fri", "Sun" };
            var chartData = dayOrder
                .Where(d => rawData.ContainsKey(d))
                .ToDictionary(d => d, d => rawData[d]);

            foreach (var kvp in rawData)
                if (!chartData.ContainsKey(kvp.Key))
                    chartData[kvp.Key] = kvp.Value;

            const int FIXED_MAX = 20;
            const int STEP = 5;
            const int Y_AXIS_WIDTH = 50;
            const int BOTTOM_SPACING = 50;
            const int TOP_SPACING = 70;

            int chartLeft = Y_AXIS_WIDTH;
            int chartTop = TOP_SPACING;
            int chartWidth = panelActivityChart.Width - Y_AXIS_WIDTH - 20;
            int chartHeight = panelActivityChart.Height - TOP_SPACING - BOTTOM_SPACING - 20;

            int barStartX = chartLeft + 40;
            int baselineY = chartTop + chartHeight;
            int barWidth = (chartWidth - 80) / 7;

            for (int i = 0; i <= FIXED_MAX; i += STEP)
            {
                string labelText = (i == FIXED_MAX) ? "20+" : i.ToString();
                int labelY = baselineY - (int)(i * chartHeight / (float)FIXED_MAX);

                panelActivityChart.Controls.Add(new Label
                {
                    Text = labelText,
                    Font = new Font("Segoe UI", 9F),
                    ForeColor = ColorFromHex(GRAY_DARK),
                    Location = new Point(2, labelY - 10),
                    Size = new Size(42, 20),
                    TextAlign = ContentAlignment.MiddleRight,
                    AutoSize = false
                });
            }

            panelActivityChart.Paint -= PanelActivityChart_Paint;
            panelActivityChart.Paint += (s, e) =>
            {
                e.Graphics.Clear(ColorFromHex(GRAY_LIGHT));

                using (Pen gridPen = new Pen(ColorFromHex(GRID_GRAY), 1f))
                {
                    for (int i = 0; i <= FIXED_MAX; i += STEP)
                    {
                        int gridY = baselineY - (int)(i * chartHeight / (float)FIXED_MAX);
                        e.Graphics.DrawLine(gridPen, chartLeft, gridY, chartLeft + chartWidth, gridY);
                    }
                }

                using (Pen borderPen = new Pen(ColorFromHex(BORDER_GRAY), 1))
                {
                    e.Graphics.DrawRectangle(borderPen, chartLeft, chartTop, chartWidth, chartHeight);
                }
            };

            int barX = barStartX;
            foreach (var day in chartData)
            {
                float clampedValue = Math.Min(day.Value, FIXED_MAX);
                int barHeight = (int)(clampedValue * chartHeight / (float)FIXED_MAX);
                if (barHeight == 0 && day.Value > 0) barHeight = 1;

                var bar = new Panel
                {
                    BackColor = ColorFromHex(PRIMARY_HUE),
                    Location = new Point(barX, baselineY - barHeight),
                    Size = new Size(barWidth - 10, barHeight)
                };

                bar.Paint += (s, e) =>
                {
                    using (System.Drawing.Drawing2D.GraphicsPath path = CreateRoundedRectanglePath(bar.ClientRectangle, 4))
                    {
                        e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                        e.Graphics.FillPath(new SolidBrush(ColorFromHex(PRIMARY_HUE)), path);
                    }
                };

                panelActivityChart.Controls.Add(bar);

                panelActivityChart.Controls.Add(new Label
                {
                    Text = day.Value.ToString(),
                    Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                    ForeColor = ColorFromHex(PRIMARY_HUE),
                    Location = new Point(barX - 5, baselineY - barHeight - 25),
                    Size = new Size(barWidth, 20),
                    TextAlign = ContentAlignment.BottomCenter,
                    AutoSize = false
                });

                panelActivityChart.Controls.Add(new Label
                {
                    Text = day.Key,
                    Font = new Font("Segoe UI", 9F),
                    ForeColor = ColorFromHex(GRAY_DARK),
                    Location = new Point(barX - 5, baselineY + 10),
                    Size = new Size(barWidth, 18),
                    TextAlign = ContentAlignment.TopCenter,
                    AutoSize = false
                });

                barX += barWidth;
            }

            panelActivityChart.Invalidate();
        }

        private void PanelActivityLogs_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(ColorFromHex(GRAY_LIGHT));
            var path = CreateRoundedRectanglePath(panelActivityLogs.ClientRectangle, 15);
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            e.Graphics.DrawPath(new Pen(ColorFromHex(BORDER_GRAY), 1), path);
        }

        private void PanelActivityChart_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(ColorFromHex(GRAY_LIGHT));
            var path = CreateRoundedRectanglePath(panelActivityChart.ClientRectangle, 15);
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            e.Graphics.DrawPath(new Pen(ColorFromHex(BORDER_GRAY), 1), path);
        }

        private System.Drawing.Drawing2D.GraphicsPath CreateRoundedRectanglePath(Rectangle rect, int radius)
        {
            var path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
            path.CloseFigure();
            return path;
        }

        private void roundedButton1_Click(object sender, EventArgs e) { LoadDashboardStatistics(); LoadActivityLogs(); LoadActivityChart(); }
        private void roundedButton2_Click(object sender, EventArgs e) { this.Hide(); new MemberManagement().Show(); }
        private void roundedButton3_Click(object sender, EventArgs e) { this.Hide(); new TrainerManagement().Show(); }
        private void roundedButton4_Click(object sender, EventArgs e) { this.Hide(); new ClassBooking().Show(); }
        private void roundedButton5_Click(object sender, EventArgs e) { this.Hide(); new Sessionschedule().Show(); }
        private void roundedButton6_Click(object sender, EventArgs e)
        {
            try
            {
                ContextMenuStrip moreMenu = new ContextMenuStrip
                {
                    Font = new Font("Segoe UI", 11, FontStyle.Regular),
                    BackColor = ColorFromHex(WHITE),
                    RenderMode = ToolStripRenderMode.Professional,
                    ShowImageMargin = true,
                    ImageScalingSize = new Size(24, 24),
                    Width = 180,
                    AutoClose = true
                };
                moreMenu.Items.Add("Donations");
                moreMenu.Items.Add("Partnerships");

                if (LoginForm.LoggedInUserRole == "SuperAdmin")
                {
                    moreMenu.Items.Add("Manage Staff");
                }

                moreMenu.Items.Add(new ToolStripSeparator());
                moreMenu.Items.Add("Logout");

                foreach (ToolStripItem item in moreMenu.Items)
                    if (item is ToolStripMenuItem mi) { mi.Click += MoreMenuItem_Click; mi.Height = 35; }

                if (sender is Button btn)
                    moreMenu.Show(btn, new Point(0, btn.Height));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error showing dropdown: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MoreMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(sender is ToolStripMenuItem item)) return;
                switch (item.Text)
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
                        ManageStaffForm staffForm = new ManageStaffForm();
                        staffForm.ShowDialog();
                        break;

                    case "Logout":
                        if (MessageBox.Show("Are you sure you want to logout?", "Logout",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            this.Close();
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error handling menu click: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGetStarted_Click(object sender, EventArgs e) { this.Hide(); new MemberManagement().Show(); }
        private void btnExploreMore_Click(object sender, EventArgs e) { this.Hide(); new ClassBooking().Show(); }

        private void pictureBox1_Click(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void button1_Click(object sender, EventArgs e) { }
        private void richTextBox1_TextChanged(object sender, EventArgs e) { }
        private void richTextBox2_TextChanged(object sender, EventArgs e) { }
        private void richTextBox3_TextChanged(object sender, EventArgs e) { }
        private void richTextBox4_TextChanged(object sender, EventArgs e) { }
        private void richTextBox2_TextChanged_1(object sender, EventArgs e) { }
        private void textBox3_TextChanged(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void pictureBox2_Click(object sender, EventArgs e) { }
        private void textBox4_TextChanged(object sender, EventArgs e) { }
        private void roundedButton7_Click(object sender, EventArgs e) { }
        private void label1_Click_1(object sender, EventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void richTextBox1_TextChanged_1(object sender, EventArgs e) { }
        private void panel2_Paint(object sender, PaintEventArgs e) { }
        private void lblTotalMembersNum_Click(object sender, EventArgs e) { }
        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e) { }
        private void lblUpcomingNum_Click(object sender, EventArgs e) { }
        private void lblActiveMembersNum_Click(object sender, EventArgs e) { }
        private void lblTrainersNum_Click(object sender, EventArgs e) { }
    }
}