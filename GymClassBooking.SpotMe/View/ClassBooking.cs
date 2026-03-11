using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using GymClassBooking.SpotMe.Controls;
using GymClassBooking.SpotMe.Models;
using GymClassBooking.SpotMe.Controllers;
using GymClassBooking.SpotMe.View;
using System.Linq;

namespace GymClassBooking.SpotMe.View
{
    public partial class ClassBooking : Form
    {
        private List<BookingClass> classes = new List<BookingClass>();
        private BookingClassController classController = new BookingClassController();
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

        public ClassBooking()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private Color ColorFromHex(int hex)
        {
            return Color.FromArgb((hex >> 16) & 0xFF, (hex >> 8) & 0xFF, hex & 0xFF);
        }

        private void ClassBooking_Load(object sender, EventArgs e)
        {
            ApplyColorPalette();

            panelRowsContainer.AutoScroll = true;
            panelRowsContainer.HorizontalScroll.Enabled = false;
            panelRowsContainer.HorizontalScroll.Visible = false;
            panelRowsContainer.VerticalScroll.Enabled = true;

            _loaded = true;
            LoadClasses();

            panelRowsContainer.Resize += (s, resizeArgs) => { if (_loaded) RefreshClassDisplay(); };
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

            // Header panel
            panelHeader.BackColor = ColorFromHex(WHITE);
            lblHeaderTitle.ForeColor = ColorFromHex(PRIMARY_HUE);
            lblHeaderSubtitle.ForeColor = ColorFromHex(GRAY_MEDIUM);

            // Add button - Only visible for SuperAdmin and Staff
            btnAddClass.Visible = CurrentUser.IsSuperAdmin() || CurrentUser.IsStaff();
            if (btnAddClass.Visible)
            {
                btnAddClass.NormalColor = ColorFromHex(PRIMARY_HUE);
                btnAddClass.HoverColor = ColorFromHex(0x9B6BA6);
                btnAddClass.ForeColor = ColorFromHex(WHITE);
            }

            // Navigation buttons
            foreach (RoundedButton btn in new[] { Home, Members, Trainers, btnClassBooking, SessionSchedule, More })
            {
                btn.NormalColor = ColorFromHex(WHITE);
                btn.HoverColor = ColorFromHex(PRIMARY_HUE);
                btn.ForeColor = ColorFromHex(GRAY_DARK);
            }

            // Container
            panelRowsContainer.BackColor = ColorFromHex(WHITE);
        }

        private void LoadClasses()
        {
            classes = classController.GetAllClasses();
            RefreshClassDisplay();
        }

        private void RefreshClassDisplay()
        {
            if (panelRowsContainer == null) return;

            panelRowsContainer.Controls.Clear();

            if (classes.Count == 0)
            {
                Label lblNoClasses = new Label
                {
                    Text = "No classes found.",
                    Font = new Font("Segoe UI", 12, FontStyle.Italic),
                    ForeColor = ColorFromHex(GRAY_MEDIUM),
                    Location = new Point(20, 20),
                    Size = new Size(500, 30),
                    TextAlign = ContentAlignment.MiddleLeft
                };
                panelRowsContainer.Controls.Add(lblNoClasses);
                return;
            }

            int margin = 15;
            int cardsPerRow = 3;
            int scrollbarWidth = 17;
            int availableWidth = panelRowsContainer.ClientSize.Width - scrollbarWidth;
            int cardWidth = (availableWidth - (margin * (cardsPerRow + 1))) / cardsPerRow;

            contentPanel = new Panel
            {
                BackColor = Color.Transparent,
                AutoSize = false,
                Location = new Point(0, 0)
            };

            List<Panel> allCards = new List<Panel>();
            List<int> cardHeights = new List<int>();

            for (int i = 0; i < classes.Count; i++)
            {
                Panel card = CreateClassCard(classes[i], cardWidth);
                allCards.Add(card);
                cardHeights.Add(card.Height);
            }

            int currentY = margin;
            int maxWidth = 0;

            for (int row = 0; row < (classes.Count + cardsPerRow - 1) / cardsPerRow; row++)
            {
                int rowStart = row * cardsPerRow;
                int rowEnd = Math.Min(rowStart + cardsPerRow, classes.Count);

                int maxHeightInRow = 0;
                for (int i = rowStart; i < rowEnd; i++)
                {
                    if (cardHeights[i] > maxHeightInRow)
                        maxHeightInRow = cardHeights[i];
                }

                for (int col = 0; col < cardsPerRow && rowStart + col < classes.Count; col++)
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
            panelRowsContainer.Controls.Add(contentPanel);
        }

        private Panel CreateClassCard(BookingClass cls, int width)
        {
            Panel cardPanel = new Panel();
            cardPanel.BackColor = ColorFromHex(WHITE);
            cardPanel.BorderStyle = BorderStyle.FixedSingle;
            cardPanel.Name = "cardPanel" + Guid.NewGuid().ToString();
            cardPanel.Tag = cls;
            cardPanel.Width = width;

            int currentY = 15;
            int leftMargin = 15;
            int rightMargin = 15;
            int contentWidth = width - (leftMargin + rightMargin);

            // Category Label
            Label lblCategory = new Label();
            lblCategory.Text = cls.Category;
            lblCategory.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            lblCategory.ForeColor = ColorFromHex(PRIMARY_HUE);
            lblCategory.Location = new Point(leftMargin, currentY);
            lblCategory.Size = new Size(contentWidth, 25);
            lblCategory.TextAlign = ContentAlignment.MiddleLeft;
            cardPanel.Controls.Add(lblCategory);
            currentY += 30;

            // Description
            string displayDesc = cls.Description;
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
            lblTrainer.Text = $"Trainer: {cls.TrainerName}";
            lblTrainer.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            lblTrainer.ForeColor = ColorFromHex(GRAY_DARK);
            lblTrainer.Location = new Point(leftMargin, currentY);
            lblTrainer.Size = new Size(contentWidth, 20);
            cardPanel.Controls.Add(lblTrainer);
            currentY += 20;

            // Date
            Label lblDate = new Label();
            lblDate.Text = $"Date: {cls.StartTime:M/d/yyyy}";
            lblDate.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            lblDate.ForeColor = ColorFromHex(GRAY_DARK);
            lblDate.Location = new Point(leftMargin, currentY);
            lblDate.Size = new Size(contentWidth, 20);
            cardPanel.Controls.Add(lblDate);
            currentY += 20;

            // Time
            Label lblTime = new Label();
            lblTime.Text = $"Time: {cls.StartTime:hh:mm tt} - {cls.EndTime:hh:mm tt}";
            lblTime.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            lblTime.ForeColor = ColorFromHex(GRAY_DARK);
            lblTime.Location = new Point(leftMargin, currentY);
            lblTime.Size = new Size(contentWidth, 20);
            cardPanel.Controls.Add(lblTime);
            currentY += 20;

            // Duration
            TimeSpan duration = cls.EndTime - cls.StartTime;
            Label lblDuration = new Label();
            lblDuration.Text = $"Duration: {duration:hh\\:mm}";
            lblDuration.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            lblDuration.ForeColor = ColorFromHex(GRAY_DARK);
            lblDuration.Location = new Point(leftMargin, currentY);
            lblDuration.Size = new Size(contentWidth, 20);
            cardPanel.Controls.Add(lblDuration);
            currentY += 20;

            // Capacity
            Label lblCapacity = new Label();
            lblCapacity.Text = $"Capacity: {cls.BookedCount}/{cls.Capacity} slots";
            lblCapacity.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            lblCapacity.ForeColor = cls.BookedCount >= cls.Capacity
                ? ColorFromHex(RED_DELETE)
                : ColorFromHex(PRIMARY_HUE);
            lblCapacity.Location = new Point(leftMargin, currentY);
            lblCapacity.Size = new Size(contentWidth, 20);
            cardPanel.Controls.Add(lblCapacity);
            currentY += 30;

            // View Details Button - Always show
            Button btnView = new Button();
            btnView.Text = "👁️ View Details";
            btnView.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            btnView.ForeColor = ColorFromHex(PRIMARY_HUE);
            btnView.BackColor = ColorFromHex(WHITE);
            btnView.FlatStyle = FlatStyle.Flat;
            btnView.FlatAppearance.BorderColor = ColorFromHex(PRIMARY_HUE);
            btnView.FlatAppearance.BorderSize = 1;
            btnView.Location = new Point(leftMargin, currentY);
            btnView.Size = new Size(contentWidth, 28);
            btnView.Tag = cls;
            btnView.Cursor = Cursors.Hand;
            btnView.Click += BtnView_Click;
            cardPanel.Controls.Add(btnView);
            currentY += 33;

            // Edit and Delete buttons - Only for SuperAdmin and Staff
            if (CurrentUser.IsSuperAdmin() || CurrentUser.IsStaff())
            {
                // Edit Button
                Button btnEdit = new Button();
                btnEdit.Text = "✏️ Edit";
                btnEdit.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                btnEdit.ForeColor = ColorFromHex(PRIMARY_HUE);
                btnEdit.BackColor = ColorFromHex(WHITE);
                btnEdit.FlatStyle = FlatStyle.Flat;
                btnEdit.FlatAppearance.BorderColor = ColorFromHex(PRIMARY_HUE);
                btnEdit.FlatAppearance.BorderSize = 1;
                btnEdit.Location = new Point(leftMargin, currentY);
                btnEdit.Size = new Size((contentWidth - 5) / 2, 28);
                btnEdit.Tag = cls;
                btnEdit.Cursor = Cursors.Hand;
                btnEdit.Click += BtnEdit_Click;
                cardPanel.Controls.Add(btnEdit);

                // Delete Button
                Button btnDelete = new Button();
                btnDelete.Text = "🗑️ Delete";
                btnDelete.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                btnDelete.ForeColor = ColorFromHex(RED_DELETE);
                btnDelete.BackColor = ColorFromHex(WHITE);
                btnDelete.FlatStyle = FlatStyle.Flat;
                btnDelete.FlatAppearance.BorderColor = ColorFromHex(RED_DELETE);
                btnDelete.FlatAppearance.BorderSize = 1;
                btnDelete.Location = new Point(leftMargin + (contentWidth - 5) / 2 + 5, currentY);
                btnDelete.Size = new Size((contentWidth - 5) / 2, 28);
                btnDelete.Tag = cls;
                btnDelete.Cursor = Cursors.Hand;
                btnDelete.Click += BtnDelete_Click;
                cardPanel.Controls.Add(btnDelete);

                currentY += 28;
            }

            cardPanel.Size = new Size(width, currentY + 15);

            return cardPanel;
        }

        private void BtnView_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn == null) return;

            BookingClass cls = btn.Tag as BookingClass;
            if (cls == null) return;

            BookingClassDetailsForm detailsForm = new BookingClassDetailsForm(cls);
            detailsForm.ShowDialog();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn == null) return;

            BookingClass cls = btn.Tag as BookingClass;
            if (cls == null) return;

            AddBookingClassForm editForm = new AddBookingClassForm();
            editForm.LoadClassData(cls);
            editForm.Text = "Edit Class";

            if (editForm.ShowDialog() == DialogResult.OK)
            {
                BookingClass updatedClass = new BookingClass
                {
                    Id = cls.Id,
                    Category = editForm.ClassCategory,
                    TrainerName = editForm.TrainerName,
                    TrainerId = editForm.TrainerId,
                    Description = editForm.Description,
                    Capacity = editForm.Capacity,
                    StartTime = editForm.StartTime,
                    EndTime = editForm.EndTime,
                    Status = cls.Status,
                    BookedCount = cls.BookedCount,
                    IsActive = true
                };

                classController.UpdateClass(updatedClass);
                LoadClasses();
                RefreshMainDashboard();

                MessageBox.Show($"Class {editForm.ClassCategory} updated successfully!",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn == null) return;

            BookingClass cls = btn.Tag as BookingClass;
            if (cls == null) return;

            DialogResult result = MessageBox.Show(
                $"Are you sure you want to delete {cls.Category}?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    classController.DeleteClass(cls.Id);
                    LoadClasses();
                    RefreshMainDashboard();
                    MessageBox.Show($"{cls.Category} has been deleted.", "Deleted",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting class: {ex.Message}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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

        private void btnAddClass_Click(object sender, EventArgs e)
        {
            AddBookingClassForm addForm = new AddBookingClassForm();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                BookingClass newClass = new BookingClass
                {
                    Category = addForm.ClassCategory,
                    TrainerName = addForm.TrainerName,
                    TrainerId = addForm.TrainerId,
                    Description = addForm.Description,
                    Capacity = addForm.Capacity,
                    StartTime = addForm.StartTime,
                    EndTime = addForm.EndTime,
                    Status = "Upcoming",
                    BookedCount = 0,
                    IsActive = true
                };

                classController.AddClass(newClass);
                LoadClasses();
                RefreshMainDashboard();

                MessageBox.Show($"Class {addForm.ClassCategory} added successfully!",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is MainDashboard)
                {
                    form.Show();
                    break;
                }
            }
            this.Close();
        }

        private void roundedButton2_Click(object sender, EventArgs e)
        {
            LoadClasses();
        }

        private void roundedButton3_Click(object sender, EventArgs e)
        {
            TrainerManagement trainerForm = new TrainerManagement();
            trainerForm.Show();
            this.Hide();
        }

        private void roundedButton4_Click(object sender, EventArgs e)
        {
            MemberManagement memberForm = new MemberManagement();
            memberForm.Show();
            this.Hide();
        }

        private void roundedButton5_Click(object sender, EventArgs e)
        {
            Sessionschedule scheduleForm = new Sessionschedule();
            scheduleForm.Show();
            this.Hide();
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