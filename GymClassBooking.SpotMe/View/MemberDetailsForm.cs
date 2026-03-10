using System;
using System.Drawing;
using System.Windows.Forms;
using GymClassBooking.SpotMe.Controls;
using GymClassBooking.SpotMe.Models;

namespace GymClassBooking.SpotMe.View
{
    public partial class MemberDetailsForm : Form
    {
        private Member _member;

        // Color Palette
        private const int PRIMARY_HUE = 0x6F2C8C;      // Purple
        private const int GRAY_LIGHT = 0xF5F5F5;       // Light gray
        private const int GRAY_DARK = 0x666666;        // Dark gray
        private const int WHITE = 0xFFFFFF;            // White

        public MemberDetailsForm(Member member)
        {
            InitializeComponent();
            _member = member;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Member Details";
            ApplyColorPalette();
            LoadMemberDetails();
        }

        private Color ColorFromHex(int hex)
        {
            return Color.FromArgb((hex >> 16) & 0xFF, (hex >> 8) & 0xFF, hex & 0xFF);
        }

        private void ApplyColorPalette()
        {
            this.BackColor = ColorFromHex(WHITE);
            panelMain.BackColor = ColorFromHex(WHITE);

            lblFullNameLabel.ForeColor = ColorFromHex(PRIMARY_HUE);
            lblFullName.ForeColor = ColorFromHex(GRAY_DARK);

            lblEmailLabel.ForeColor = ColorFromHex(PRIMARY_HUE);
            lblEmail.ForeColor = ColorFromHex(GRAY_DARK);

            lblPhoneLabel.ForeColor = ColorFromHex(PRIMARY_HUE);
            lblPhone.ForeColor = ColorFromHex(GRAY_DARK);

            lblGenderLabel.ForeColor = ColorFromHex(PRIMARY_HUE);
            lblGender.ForeColor = ColorFromHex(GRAY_DARK);

            lblFitnessGoalLabel.ForeColor = ColorFromHex(PRIMARY_HUE);
            lblFitnessGoal.ForeColor = ColorFromHex(GRAY_DARK);

            btnBackToList.NormalColor = ColorFromHex(GRAY_LIGHT);
            btnBackToList.HoverColor = ColorFromHex(PRIMARY_HUE);
            btnBackToList.ForeColor = ColorFromHex(PRIMARY_HUE);

            btnDone.NormalColor = ColorFromHex(PRIMARY_HUE);
            btnDone.HoverColor = ColorFromHex(0x9B6BA6);
            btnDone.ForeColor = ColorFromHex(WHITE);
        }

        private void LoadMemberDetails()
        {
            // Photo
            if (_member.Photo != null)
            {
                picMemberPhoto.Image = _member.Photo;
            }
            else if (!string.IsNullOrEmpty(_member.PhotoPath) && System.IO.File.Exists(_member.PhotoPath))
            {
                try
                {
                    picMemberPhoto.Image = Image.FromFile(_member.PhotoPath);
                }
                catch
                {
                    CreateDefaultPhoto();
                }
            }
            else
            {
                CreateDefaultPhoto();
            }

            // Make photo circular
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, picMemberPhoto.Width - 1, picMemberPhoto.Height - 1);
            picMemberPhoto.Region = new Region(gp);

            // Member details
            lblFullName.Text = _member.Name;
            lblEmail.Text = _member.Email;
            lblPhone.Text = _member.Phone;
            lblGender.Text = !string.IsNullOrEmpty(_member.Gender) ? _member.Gender : "Not specified";
            lblFitnessGoal.Text = !string.IsNullOrEmpty(_member.FitnessGoal) ? _member.FitnessGoal : "Not specified";
        }

        private void CreateDefaultPhoto()
        {
            Bitmap defaultImage = new Bitmap(120, 120);
            using (Graphics g = Graphics.FromImage(defaultImage))
            {
                g.Clear(ColorFromHex(PRIMARY_HUE));
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                string firstLetter = _member.Name.Length > 0 ? _member.Name.Substring(0, 1).ToUpper() : "?";
                Font font = new Font("Arial", 48, FontStyle.Bold);
                StringFormat format = new StringFormat();
                format.Alignment = StringAlignment.Center;
                format.LineAlignment = StringAlignment.Center;

                g.DrawString(firstLetter, font, Brushes.White, new RectangleF(0, 0, 120, 120), format);
            }
            picMemberPhoto.Image = defaultImage;
        }

        private void btnBackToList_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}