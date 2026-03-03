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
    public partial class Sessionschedule : Form
    {
        public Sessionschedule()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Sessionschedule_Load(object sender, EventArgs e)
        {
            // Load schedule data here
        }

        // HOME BUTTON - Go back to MainDashboard
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

        // MEMBERS BUTTON - Switch to MemberManagement
        private void roundedButton2_Click(object sender, EventArgs e)
        {
            MemberManagement memberForm = new MemberManagement();
            memberForm.Show();
            this.Hide();
        }

        // TRAINERS BUTTON - Switch to TrainerManagement
        private void roundedButton3_Click(object sender, EventArgs e)
        {
            TrainerManagement trainerForm = new TrainerManagement();
            trainerForm.Show();
            this.Hide();
        }

        // CLASS BOOKING BUTTON - Switch to ClassBooking
        private void roundedButton4_Click(object sender, EventArgs e)
        {
            ClassBooking bookingForm = new ClassBooking();
            bookingForm.Show();
            this.Hide();
        }

        // SESSION SCHEDULE BUTTON - Refresh current page
        private void roundedButton5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Refreshing session schedule...");
        }

        // MORE BUTTON - Shows dropdown menu
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
    }
}