using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using GymClassBooking.SpotMe.Controls;

namespace GymClassBooking.SpotMe.View
{
    public partial class PartnershipsForm : Form
    {
        private const int PRIMARY_HUE = 0x6F2C8C;
        private const int LIGHT_PURPLE = 0xF9F5FF;
        private const int GRAY_LIGHT = 0xF5F5F5;
        private const int GRAY_MEDIUM = 0xAAAAAA;
        private const int GRAY_DARK = 0x666666;
        private const int WHITE = 0xFFFFFF;
        private const int BLACK = 0x000000;

        public PartnershipsForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private Color ColorFromHex(int hex)
        {
            return Color.FromArgb((hex >> 16) & 0xFF, (hex >> 8) & 0xFF, hex & 0xFF);
        }

        private void PartnershipsForm_Load(object sender, EventArgs e)
        {
            ApplyColorPalette();
            SetupButtonEvents();
        }

        private void ApplyColorPalette()
        {
            this.BackColor = ColorFromHex(WHITE);
            panel1.BackColor = ColorFromHex(LIGHT_PURPLE);
            label1.ForeColor = ColorFromHex(PRIMARY_HUE);
            panelContent.BackColor = ColorFromHex(GRAY_LIGHT);

            foreach (RoundedButton btn in new[] { roundedButton1, roundedButton2, roundedButton3, roundedButton4, roundedButton5, roundedButton6 })
            {
                btn.NormalColor = ColorFromHex(WHITE);
                btn.HoverColor = ColorFromHex(PRIMARY_HUE);
                btn.ForeColor = ColorFromHex(GRAY_DARK);
            }

            // Style the View Website buttons
            btnView1.BackColor = ColorFromHex(PRIMARY_HUE);
            btnView1.ForeColor = ColorFromHex(WHITE);
            btnView2.BackColor = ColorFromHex(PRIMARY_HUE);
            btnView2.ForeColor = ColorFromHex(WHITE);
            btnView3.BackColor = ColorFromHex(PRIMARY_HUE);
            btnView3.ForeColor = ColorFromHex(WHITE);
        }

        private void SetupButtonEvents()
        {
            btnView1.Click += (s, e) => MessageBox.Show($"{lblName1.Text}\n\n{lblDesc1.Text}", "Partnership Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnView2.Click += (s, e) => MessageBox.Show($"{lblName2.Text}\n\n{lblDesc2.Text}", "Partnership Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnView3.Click += (s, e) => MessageBox.Show($"{lblName3.Text}\n\n{lblDesc3.Text}", "Partnership Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
                if (form is MainDashboard)
                {
                    form.Show();
                    break;
                }
            this.Close();
        }

        private void roundedButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MemberManagement().Show();
        }

        private void roundedButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new TrainerManagement().Show();
        }

        private void roundedButton4_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ClassBooking().Show();
        }

        private void roundedButton5_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Sessionschedule().Show();
        }

        private void roundedButton6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBoxLogo3_Click(object sender, EventArgs e)
        {
        }
    }
}