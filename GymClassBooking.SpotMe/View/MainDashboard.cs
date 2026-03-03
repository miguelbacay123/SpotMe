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

namespace GymClassBooking.SpotMe
{
    public partial class MainDashboard : Form
    {
        public MainDashboard()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void MainDashboard_Load(object sender, EventArgs e)
        {
            // Your load code here
        }

        // HOME BUTTON - Refresh current dashboard
        private void roundedButton1_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        // MEMBERS BUTTON - Open MemberManagement
        private void roundedButton2_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide MainDashboard
            MemberManagement memberForm = new MemberManagement();
            memberForm.Show();
        }

        // TRAINERS BUTTON - Open TrainerManagement
        private void roundedButton3_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide MainDashboard
            TrainerManagement trainerForm = new TrainerManagement();
            trainerForm.Show();
        }

        // CLASS BOOKING BUTTON - Open ClassBooking
        private void roundedButton4_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide MainDashboard
            ClassBooking bookingForm = new ClassBooking();
            bookingForm.Show();
        }

        // SESSION SCHEDULE BUTTON - Open Sessionschedule
        private void roundedButton5_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide MainDashboard
            Sessionschedule scheduleForm = new Sessionschedule();
            scheduleForm.Show();
        }

        // MORE BUTTON (dropdownButton1) - Shows dropdown menu with Donations, Partnerships, Manage Staff, Logout
        private void dropdownButton1_Click(object sender, EventArgs e)
        {
            try
            {
                // Create the dropdown menu
                ContextMenuStrip moreMenu = new ContextMenuStrip();

                // Make it look nice with proper sizing
                moreMenu.Font = new Font("Segoe UI", 11, FontStyle.Regular);
                moreMenu.BackColor = Color.White;
                moreMenu.RenderMode = ToolStripRenderMode.Professional;
                moreMenu.ShowImageMargin = false;

                // Set width to fit text properly (about 150 pixels wide)
                moreMenu.Width = 150;

                // Add ONLY the 4 items you want: Donations, Partnerships, Manage Staff, Logout
                moreMenu.Items.Add("Donations");
                moreMenu.Items.Add("Partnerships");
                moreMenu.Items.Add("Manage Staff");
                moreMenu.Items.Add(new ToolStripSeparator()); // Line before Logout
                moreMenu.Items.Add("Logout");

                // Add click handlers for each menu item
                foreach (ToolStripItem item in moreMenu.Items)
                {
                    if (item is ToolStripMenuItem menuItem)
                    {
                        menuItem.Click += MoreMenuItem_Click;

                        // Make each item a bit taller for better fit
                        menuItem.Height = 35;
                    }
                }

                // Show the menu below the MORE button
                Button moreButton = sender as Button;
                moreMenu.Show(moreButton, new Point(0, moreButton.Height));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error showing dropdown: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Handle clicks on more menu items
        private void MoreMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ToolStripMenuItem clickedItem = sender as ToolStripMenuItem;
                if (clickedItem != null)
                {
                    string option = clickedItem.Text;

                    // Handle each menu item
                    switch (option)
                    {
                        case "Donations":
                            MessageBox.Show("Donations clicked - Opening Donations form...",
                                "Donations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // TODO: Open Donations form
                            // DonationsForm donationsForm = new DonationsForm();
                            // donationsForm.Show();
                            // this.Hide();
                            break;

                        case "Partnerships":
                            MessageBox.Show("Partnerships clicked - Opening Partnerships form...",
                                "Partnerships", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // TODO: Open Partnerships form
                            // PartnershipsForm partnershipsForm = new PartnershipsForm();
                            // partnershipsForm.Show();
                            // this.Hide();
                            break;

                        case "Manage Staff":
                            MessageBox.Show("Manage Staff clicked - Opening Manage Staff form...",
                                "Manage Staff", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // TODO: Open Manage Staff form
                            // ManageStaffForm staffForm = new ManageStaffForm();
                            // staffForm.Show();
                            // this.Hide();
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

        // GET STARTED BUTTON
        private void btnGetStarted_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Get Started clicked!", "SpotMe",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // EXPLORE MORE BUTTON
        private void btnExploreMore_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Explore More clicked!", "SpotMe",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Keep your existing empty methods
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
    }
}