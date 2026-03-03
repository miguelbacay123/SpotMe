using GymClassBooking.SpotMe.Controls;
using GymClassBooking.SpotMe.Models;
using GymClassBooking.SpotMe.Controllers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace GymClassBooking.SpotMe.View
{
    public partial class MemberManagement : Form
    {
        private List<Member> members = new List<Member>();
        private MemberController memberController = new MemberController();

        public MemberManagement()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void MemberManagement_Load(object sender, EventArgs e)
        {
            LoadMembers();
        }

        private void LoadMembers()
        {
            members = memberController.GetAllMembers();
            RefreshMemberDisplay();
        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            AddMemberForm addForm = new AddMemberForm();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                Member newMember = new Member
                {
                    Name = addForm.MemberName,
                    Email = addForm.MemberEmail,
                    Phone = addForm.MemberPhone,
                    Gender = addForm.MemberGender,
                    Photo = addForm.MemberPhoto,
                    PhotoPath = addForm.MemberPhotoPath
                };

                memberController.AddMember(newMember);
                LoadMembers();

                MessageBox.Show($"Member {addForm.MemberName} added successfully!",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void AddMemberRow(Member member)
        {
            int rowCount = panelRowsContainer.Controls.Count;
            int yPos = 5 + (rowCount * 60);

            Panel rowPanel = new Panel();
            rowPanel.BackColor = Color.White;
            rowPanel.BorderStyle = BorderStyle.FixedSingle;
            rowPanel.Location = new Point(0, yPos);
            rowPanel.Size = new Size(830, 55);
            rowPanel.Name = "rowPanel" + rowCount;
            rowPanel.Tag = member;

            // Circular Photo (20px left + 40px width = 60px, header at 25)
            CircularPictureBox picPhoto = new CircularPictureBox();
            picPhoto.BackColor = Color.LightGray;
            picPhoto.Location = new Point(20, 8);
            picPhoto.Size = new Size(40, 40);
            picPhoto.SizeMode = PictureBoxSizeMode.Zoom;

            if (member.Photo != null)
            {
                picPhoto.Image = member.Photo;
            }
            else
            {
                // Default placeholder with first letter
                Bitmap defaultImage = new Bitmap(40, 40);
                using (Graphics g = Graphics.FromImage(defaultImage))
                {
                    g.Clear(Color.FromArgb(111, 44, 140));
                    string firstLetter = member.Name.Length > 0 ? member.Name.Substring(0, 1).ToUpper() : "?";
                    g.DrawString(firstLetter,
                        new Font("Arial", 16, FontStyle.Bold),
                        Brushes.White,
                        new PointF(10, 8));
                }
                picPhoto.Image = defaultImage;
            }
            rowPanel.Controls.Add(picPhoto);

            // Name Label (80px left, header at 85)
            Label lblName = new Label();
            lblName.Text = member.Name;
            lblName.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            lblName.Location = new Point(80, 18);
            lblName.Size = new Size(140, 20);
            rowPanel.Controls.Add(lblName);

            // Email Label (230px left, header at 235)
            Label lblEmail = new Label();
            lblEmail.Text = member.Email;
            lblEmail.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            lblEmail.Location = new Point(230, 18);
            lblEmail.Size = new Size(180, 20);
            rowPanel.Controls.Add(lblEmail);

            // Gender Label (420px left, header at 425)
            Label lblGender = new Label();
            lblGender.Text = member.Gender;
            lblGender.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            lblGender.Location = new Point(420, 18);
            lblGender.Size = new Size(80, 20);
            rowPanel.Controls.Add(lblGender);

            // Phone Label (510px left, header at 515)
            Label lblPhone = new Label();
            lblPhone.Text = member.Phone;
            lblPhone.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            lblPhone.Location = new Point(510, 18);
            lblPhone.Size = new Size(120, 20);
            rowPanel.Controls.Add(lblPhone);

            // Action Button (3 dots) - PERFECTLY ALIGNED under "ti" in "Action"
            // Header at 722px, "ti" starts at about 722 + 15px = 737px
            Button btnAction = new Button();
            btnAction.Text = "...";
            btnAction.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            btnAction.ForeColor = Color.FromArgb(111, 44, 140);
            btnAction.BackColor = Color.White;
            btnAction.FlatStyle = FlatStyle.Flat;
            btnAction.FlatAppearance.BorderSize = 0;
            btnAction.Location = new Point(735, 12); // Perfect alignment under "ti"
            btnAction.Size = new Size(40, 30);
            btnAction.TextAlign = ContentAlignment.MiddleCenter;
            btnAction.Tag = member;
            btnAction.Click += BtnAction_Click;
            rowPanel.Controls.Add(btnAction);

            panelRowsContainer.Controls.Add(rowPanel);
        }

        private void BtnAction_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn == null) return;

            Member member = btn.Tag as Member;
            if (member == null) return;

            // Create context menu for actions
            ContextMenuStrip actionMenu = new ContextMenuStrip();
            actionMenu.Items.Add("Edit");
            actionMenu.Items.Add("Delete");
            actionMenu.Items.Add("View Details");

            // Style the menu
            actionMenu.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            actionMenu.BackColor = Color.White;
            actionMenu.Width = 120;

            // Use a local variable to avoid conflict
            ContextMenuStrip currentMenu = actionMenu;

            currentMenu.ItemClicked += (menuSender, menuArgs) =>
            {
                string option = menuArgs.ClickedItem.Text;

                if (option == "Edit")
                {
                    MessageBox.Show($"Edit {member.Name} - Coming soon!",
                        "Edit Member", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (option == "Delete")
                {
                    DialogResult confirmDelete = MessageBox.Show(
                        $"Are you sure you want to delete {member.Name}?",
                        "Confirm Delete",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);

                    if (confirmDelete == DialogResult.Yes)
                    {
                        try
                        {
                            memberController.DeleteMember(member.Id);
                            LoadMembers();

                            MessageBox.Show($"{member.Name} has been deleted.",
                                "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error deleting member: {ex.Message}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else if (option == "View Details")
                {
                    MessageBox.Show($"Name: {member.Name}\nEmail: {member.Email}\nPhone: {member.Phone}\nGender: {member.Gender}",
                        "Member Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            };

            // Show menu below the button
            currentMenu.Show(btn, new Point(0, btn.Height));
        }

        private void RepositionRows()
        {
            int yPos = 5;
            foreach (Control control in panelRowsContainer.Controls)
            {
                if (control is Panel)
                {
                    control.Location = new Point(0, yPos);
                    yPos += 60;
                }
            }
        }

        private void RefreshMemberDisplay()
        {
            if (panelRowsContainer == null) return;

            panelRowsContainer.Controls.Clear();
            foreach (var member in members)
            {
                AddMemberRow(member);
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
            RefreshMemberDisplay();
            MessageBox.Show("Refreshing member list...");
        }

        private void roundedButton3_Click(object sender, EventArgs e)
        {
            TrainerManagement trainerForm = new TrainerManagement();
            trainerForm.Show();
            this.Hide();
        }

        private void roundedButton4_Click(object sender, EventArgs e)
        {
            ClassBooking bookingForm = new ClassBooking();
            bookingForm.Show();
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
                moreMenu.BackColor = Color.White;
                moreMenu.Width = 150;

                moreMenu.Items.Add("Donations");
                moreMenu.Items.Add("Partnerships");
                moreMenu.Items.Add("Manage Staff");
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

                Button moreButton = sender as Button;
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
                            MessageBox.Show("Donations clicked - Opening Donations form...",
                                "Donations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;

                        case "Partnerships":
                            MessageBox.Show("Partnerships clicked - Opening Partnerships form...",
                                "Partnerships", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;

                        case "Manage Staff":
                            MessageBox.Show("Manage Staff clicked - Opening Manage Staff form...",
                                "Manage Staff", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;

                        case "Logout":
                            DialogResult result = MessageBox.Show("Are you sure you want to logout?",
                                "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            if (result == DialogResult.Yes)
                            {
                                this.Hide();
                                LoginForm loginForm = new LoginForm();
                                loginForm.Show();
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

        private void roundedButton7_Click(object sender, EventArgs e) { }
        private void btnBackToList_Click(object sender, EventArgs e) { }
        private void btnAdd_Click(object sender, EventArgs e) { }
        private void lblHeaderName_Click(object sender, EventArgs e) { }
        private void lblHeaderPhone_Click(object sender, EventArgs e) { }
    }
}