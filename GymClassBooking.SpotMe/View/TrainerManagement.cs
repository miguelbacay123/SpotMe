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
    public partial class TrainerManagement : Form
    {
        private List<Trainer> trainers = new List<Trainer>();
        private TrainerController trainerController = new TrainerController();
        private ActivityLogController activityLogController = new ActivityLogController();

        // Color Palette
        private const int PRIMARY_HUE = 0x6F2C8C;      // Purple (111, 44, 140)
        private const int GRAY_LIGHT = 0xF5F5F5;       // Light gray background
        private const int GRAY_MEDIUM = 0xAAAAAA;      // Medium gray text
        private const int GRAY_DARK = 0x666666;        // Dark gray text
        private const int BORDER_GRAY = 0xE0E0E0;      // Border color
        private const int BLACK = 0x000000;            // Black text
        private const int WHITE = 0xFFFFFF;            // White background

        // Table Layout Constants
        private const int COL_PHOTO = 25;
        private const int COL_NAME = 132;
        private const int COL_EMAIL = 250;
        private const int COL_PHONE = 425;
        private const int COL_SPECIALTIES = 555;
        private const int COL_ACTION = 735;

        private const int W_PHOTO = 107;
        private const int W_NAME = 118;
        private const int W_EMAIL = 175;
        private const int W_PHONE = 130;
        private const int W_SPECIALTIES = 180;
        private const int W_ACTION = 75;

        private const int PHOTO_SIZE = 40;
        private const int ROW_H = 55;
        private const int ROW_SPACING = 60;
        private const int PANEL_W = 830;
        private const int ITEMS_PER_PAGE = 5;

        private int currentPage = 1;
        private int totalPages = 1;
        private Panel paginationPanel;

        public TrainerManagement()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private Color ColorFromHex(int hex)
        {
            return Color.FromArgb((hex >> 16) & 0xFF, (hex >> 8) & 0xFF, hex & 0xFF);
        }

        private void TrainerManagement_Load(object sender, EventArgs e)
        {
            ApplyColorPalette();
            panelRowsContainer.AutoScroll = false;
            LoadTrainers();
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
            panelHeader.BackColor = ColorFromHex(GRAY_LIGHT);
            foreach (Label lbl in panelHeader.Controls.OfType<Label>())
            {
                lbl.ForeColor = ColorFromHex(BLACK);
                lbl.BackColor = ColorFromHex(GRAY_LIGHT);
            }

            // Add button - Only visible for SuperAdmin and Staff
            btnAddTrainer.Visible = CurrentUser.IsSuperAdmin() || CurrentUser.IsStaff();
            if (btnAddTrainer.Visible)
            {
                btnAddTrainer.NormalColor = ColorFromHex(PRIMARY_HUE);
                btnAddTrainer.HoverColor = ColorFromHex(0x9B6BA6);
                btnAddTrainer.ForeColor = ColorFromHex(WHITE);
            }

            // Navigation buttons
            foreach (RoundedButton btn in new[] { roundedButton1, roundedButton3, roundedButton4, roundedButton5, roundedButton6, roundedButton7 })
            {
                btn.NormalColor = ColorFromHex(WHITE);
                btn.HoverColor = ColorFromHex(PRIMARY_HUE);
                btn.ForeColor = ColorFromHex(GRAY_DARK);
            }
        }

        private void LoadTrainers()
        {
            trainers = trainerController.GetAllTrainers();
            currentPage = 1;
            totalPages = (int)Math.Ceiling((double)trainers.Count / ITEMS_PER_PAGE);
            RefreshTrainerDisplay();
        }

        private void RefreshTrainerDisplay()
        {
            if (panelRowsContainer == null) return;
            panelRowsContainer.Controls.Clear();

            if (trainers.Count == 0)
            {
                panelRowsContainer.Controls.Add(new Label
                {
                    Text = "No trainers found.",
                    Font = new Font("Segoe UI", 11, FontStyle.Italic),
                    ForeColor = ColorFromHex(GRAY_MEDIUM),
                    Location = new Point(COL_NAME, 15),
                    Size = new Size(500, 30),
                    TextAlign = ContentAlignment.MiddleLeft
                });
                return;
            }

            int startIndex = (currentPage - 1) * ITEMS_PER_PAGE;
            var pageItems = trainers.Skip(startIndex).Take(ITEMS_PER_PAGE).ToList();

            int rowIndex = 0;
            foreach (var trainer in pageItems)
            {
                AddTrainerRow(trainer, rowIndex);
                rowIndex++;
            }

            if (trainers.Count > ITEMS_PER_PAGE)
                AddPagination(rowIndex);
        }

        private Label Cell(string text, int x, int w)
        {
            return new Label
            {
                Text = text,
                Font = new Font("Segoe UI", 10, FontStyle.Regular),
                ForeColor = ColorFromHex(GRAY_DARK),
                BackColor = ColorFromHex(WHITE),
                Location = new Point(x, 0),
                Size = new Size(w, ROW_H),
                TextAlign = ContentAlignment.MiddleLeft,
                AutoSize = false,
                AutoEllipsis = false
            };
        }

        private void AddTrainerRow(Trainer trainer, int rowIndex)
        {
            int yPos = 5 + rowIndex * ROW_SPACING;

            Panel row = new Panel
            {
                BackColor = ColorFromHex(WHITE),
                BorderStyle = BorderStyle.FixedSingle,
                Location = new Point(0, yPos),
                Size = new Size(PANEL_W, ROW_H),
                Tag = trainer
            };

            CircularPictureBox pic = new CircularPictureBox
            {
                BackColor = ColorFromHex(GRAY_LIGHT),
                Location = new Point(COL_PHOTO, (ROW_H - PHOTO_SIZE) / 2),
                Size = new Size(PHOTO_SIZE, PHOTO_SIZE),
                SizeMode = PictureBoxSizeMode.Zoom
            };

            if (trainer.Photo != null)
            {
                pic.Image = trainer.Photo;
            }
            else
            {
                Bitmap bmp = CreateDefaultPhoto(trainer.Name, PHOTO_SIZE);
                pic.Image = bmp;
            }
            row.Controls.Add(pic);

            row.Controls.Add(Cell(trainer.Name, COL_NAME, W_NAME));
            row.Controls.Add(Cell(trainer.Email, COL_EMAIL, W_EMAIL));
            row.Controls.Add(Cell(trainer.Phone ?? "N/A", COL_PHONE, W_PHONE));

            string specs = trainer.Specializations != null && trainer.Specializations.Any()
                ? string.Join(", ", trainer.Specializations) : "Not specified";
            row.Controls.Add(Cell(specs, COL_SPECIALTIES, W_SPECIALTIES));

            // Only show action button for SuperAdmin and Staff
            if (CurrentUser.IsSuperAdmin() || CurrentUser.IsStaff())
            {
                Button btnAction = new Button
                {
                    Text = "⋮",
                    Font = new Font("Segoe UI", 12, FontStyle.Bold),
                    ForeColor = ColorFromHex(PRIMARY_HUE),
                    BackColor = ColorFromHex(WHITE),
                    FlatStyle = FlatStyle.Flat,
                    Location = new Point(COL_ACTION, (ROW_H - 30) / 2),
                    Size = new Size(W_ACTION, 30),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Tag = trainer,
                    Cursor = Cursors.Hand
                };
                btnAction.FlatAppearance.BorderSize = 1;
                btnAction.FlatAppearance.BorderColor = ColorFromHex(BORDER_GRAY);
                btnAction.Click += BtnAction_Click;
                row.Controls.Add(btnAction);
            }

            panelRowsContainer.Controls.Add(row);
        }

        private Bitmap CreateDefaultPhoto(string name, int size)
        {
            Bitmap defaultImage = new Bitmap(size, size);
            using (Graphics g = Graphics.FromImage(defaultImage))
            {
                g.Clear(ColorFromHex(PRIMARY_HUE));
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                string firstLetter = name.Length > 0 ? name.Substring(0, 1).ToUpper() : "?";
                Font font = new Font("Arial", size == 40 ? 16 : 48, FontStyle.Bold);
                StringFormat format = new StringFormat();
                format.Alignment = StringAlignment.Center;
                format.LineAlignment = StringAlignment.Center;

                g.DrawString(firstLetter, font, Brushes.White, new RectangleF(0, 0, size, size), format);
            }
            return defaultImage;
        }

        private void AddPagination(int rowIndex)
        {
            int paginationY = 5 + rowIndex * ROW_SPACING + 10;

            paginationPanel = new Panel
            {
                BackColor = ColorFromHex(GRAY_LIGHT),
                Location = new Point(0, paginationY),
                Size = new Size(PANEL_W, 40),
                Tag = "pagination"
            };

            Button btnPrevious = new Button
            {
                Text = "◀ Previous",
                Font = new Font("Segoe UI", 9, FontStyle.Bold),
                ForeColor = ColorFromHex(WHITE),
                BackColor = currentPage == 1 ? ColorFromHex(GRAY_MEDIUM) : ColorFromHex(PRIMARY_HUE),
                FlatStyle = FlatStyle.Flat,
                Location = new Point(150, 5),
                Size = new Size(100, 30),
                Enabled = currentPage > 1,
                Cursor = Cursors.Hand
            };
            btnPrevious.FlatAppearance.BorderSize = 0;
            btnPrevious.Click += (s, e) => { currentPage--; RefreshTrainerDisplay(); };
            paginationPanel.Controls.Add(btnPrevious);

            Label lblPageInfo = new Label
            {
                Text = $"Page {currentPage} of {totalPages}",
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                ForeColor = ColorFromHex(BLACK),
                BackColor = ColorFromHex(GRAY_LIGHT),
                Location = new Point(320, 10),
                Size = new Size(150, 20),
                TextAlign = ContentAlignment.MiddleCenter,
                AutoSize = false
            };
            paginationPanel.Controls.Add(lblPageInfo);

            Button btnNext = new Button
            {
                Text = "Next ▶",
                Font = new Font("Segoe UI", 9, FontStyle.Bold),
                ForeColor = ColorFromHex(WHITE),
                BackColor = currentPage == totalPages ? ColorFromHex(GRAY_MEDIUM) : ColorFromHex(PRIMARY_HUE),
                FlatStyle = FlatStyle.Flat,
                Location = new Point(580, 5),
                Size = new Size(100, 30),
                Enabled = currentPage < totalPages,
                Cursor = Cursors.Hand
            };
            btnNext.FlatAppearance.BorderSize = 0;
            btnNext.Click += (s, e) => { currentPage++; RefreshTrainerDisplay(); };
            paginationPanel.Controls.Add(btnNext);

            panelRowsContainer.Controls.Add(paginationPanel);
        }

        private void BtnAction_Click(object sender, EventArgs e)
        {
            if (!(sender is Button btn) || !(btn.Tag is Trainer trainer)) return;

            ContextMenuStrip menu = new ContextMenuStrip
            {
                Font = new Font("Segoe UI", 10, FontStyle.Regular),
                BackColor = ColorFromHex(WHITE),
                ForeColor = ColorFromHex(GRAY_DARK)
            };
            menu.Items.Add("👁️ View Details");
            menu.Items.Add("✏️ Edit");
            menu.Items.Add("🗑️ Delete");

            menu.ItemClicked += (s, args) =>
            {
                switch (args.ClickedItem.Text)
                {
                    case "👁️ View Details":
                        new TrainerDetailsForm(trainer).ShowDialog();
                        break;

                    case "✏️ Edit":
                        AddTrainerForm editForm = new AddTrainerForm();
                        editForm.LoadTrainerData(trainer);
                        if (editForm.ShowDialog() == DialogResult.OK)
                        {
                            trainerController.UpdateTrainer(new Trainer
                            {
                                Id = trainer.Id,
                                Name = editForm.TrainerName,
                                Email = editForm.TrainerEmail,
                                Phone = editForm.TrainerPhone,
                                DateOfBirth = editForm.TrainerDateOfBirth,
                                Gender = editForm.TrainerGender,
                                Address = editForm.TrainerAddress,
                                Specializations = editForm.TrainerSpecializations,
                                Photo = editForm.TrainerPhoto,
                                PhotoPath = editForm.TrainerPhotoPath,
                                IsActive = true
                            });
                            LoadTrainers();
                            RefreshMainDashboard();
                            MessageBox.Show($"Trainer {editForm.TrainerName} updated successfully!",
                                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        break;

                    case "🗑️ Delete":
                        if (MessageBox.Show(
                                $"Are you sure you want to delete {trainer.Name}?",
                                "Confirm Delete", MessageBoxButtons.YesNo,
                                MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            try
                            {
                                trainerController.DeleteTrainer(trainer.Id);
                                LoadTrainers();
                                RefreshMainDashboard();
                                MessageBox.Show($"{trainer.Name} has been deleted.",
                                    "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"Error deleting trainer: {ex.Message}",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        break;
                }
            };

            menu.Show(btn, new Point(0, btn.Height));
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

        private void btnAddTrainer_Click(object sender, EventArgs e)
        {
            AddTrainerForm addForm = new AddTrainerForm();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                trainerController.AddTrainer(new Trainer
                {
                    Name = addForm.TrainerName,
                    Email = addForm.TrainerEmail,
                    Phone = addForm.TrainerPhone,
                    DateOfBirth = addForm.TrainerDateOfBirth,
                    Gender = addForm.TrainerGender,
                    Address = addForm.TrainerAddress,
                    Specializations = addForm.TrainerSpecializations,
                    Photo = addForm.TrainerPhoto,
                    PhotoPath = addForm.TrainerPhotoPath
                });
                LoadTrainers();
                RefreshMainDashboard();
                MessageBox.Show($"Trainer {addForm.TrainerName} added successfully!",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            RefreshTrainerDisplay();
        }

        private void roundedButton4_Click(object sender, EventArgs e)
        {
            new ClassBooking().Show();
            this.Hide();
        }

        private void roundedButton5_Click(object sender, EventArgs e)
        {
            new Sessionschedule().Show();
            this.Hide();
        }

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

                if (CurrentUser.IsSuperAdmin())
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
                MessageBox.Show($"Error showing dropdown: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        if (MessageBox.Show("Are you sure you want to logout?", "Logout",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            CurrentUser.Logout();
                            this.Close();
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error handling menu click: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void roundedButton7_Click(object sender, EventArgs e) { }
    }
}