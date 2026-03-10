using System;
using System.Drawing;
using System.Windows.Forms;
using GymClassBooking.SpotMe.Controls;
using GymClassBooking.SpotMe.Models;
using System.Linq;

namespace GymClassBooking.SpotMe.View
{
    public partial class TrainerDetailsForm : Form
    {
        private Trainer _trainer;

        // Color Palette
        private const int PRIMARY_HUE = 0x6F2C8C;      // Purple
        private const int GRAY_LIGHT = 0xF5F5F5;       // Light gray
        private const int GRAY_DARK = 0x666666;        // Dark gray
        private const int WHITE = 0xFFFFFF;            // White

        public TrainerDetailsForm(Trainer trainer)
        {
            InitializeComponent();
            _trainer = trainer;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Trainer Details";
            ApplyColorPalette();
            LoadTrainerDetails();
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

            lblDateOfBirthLabel.ForeColor = ColorFromHex(PRIMARY_HUE);
            lblDateOfBirth.ForeColor = ColorFromHex(GRAY_DARK);

            lblAddressLabel.ForeColor = ColorFromHex(PRIMARY_HUE);
            lblAddress.ForeColor = ColorFromHex(GRAY_DARK);

            lblSpecializationsLabel.ForeColor = ColorFromHex(PRIMARY_HUE);
            lblSpecializations.ForeColor = ColorFromHex(GRAY_DARK);

            btnBackToList.NormalColor = ColorFromHex(GRAY_LIGHT);
            btnBackToList.HoverColor = ColorFromHex(PRIMARY_HUE);
            btnBackToList.ForeColor = ColorFromHex(PRIMARY_HUE);

            btnDone.NormalColor = ColorFromHex(PRIMARY_HUE);
            btnDone.HoverColor = ColorFromHex(0x9B6BA6);
            btnDone.ForeColor = ColorFromHex(WHITE);
        }

        private void LoadTrainerDetails()
        {
            // Photo
            if (_trainer.Photo != null)
            {
                picTrainerPhoto.Image = _trainer.Photo;
            }
            else if (!string.IsNullOrEmpty(_trainer.PhotoPath) && System.IO.File.Exists(_trainer.PhotoPath))
            {
                try
                {
                    picTrainerPhoto.Image = Image.FromFile(_trainer.PhotoPath);
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
            gp.AddEllipse(0, 0, picTrainerPhoto.Width - 1, picTrainerPhoto.Height - 1);
            picTrainerPhoto.Region = new Region(gp);

            // Trainer details
            lblFullName.Text = _trainer.Name;
            lblEmail.Text = _trainer.Email;
            lblPhone.Text = _trainer.Phone;
            lblGender.Text = _trainer.Gender ?? "Not specified";
            lblDateOfBirth.Text = _trainer.DateOfBirth?.ToString("yyyy-MM-dd") ?? "Not specified";
            lblAddress.Text = string.IsNullOrEmpty(_trainer.Address) ? "Not specified" : _trainer.Address;

            // Specializations - join multiple if any
            string specialties = _trainer.Specializations != null && _trainer.Specializations.Any()
                ? string.Join(", ", _trainer.Specializations)
                : "Not specified";
            lblSpecializations.Text = specialties;
        }

        private void CreateDefaultPhoto()
        {
            Bitmap defaultImage = new Bitmap(120, 120);
            using (Graphics g = Graphics.FromImage(defaultImage))
            {
                g.Clear(ColorFromHex(PRIMARY_HUE));
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                string firstLetter = _trainer.Name.Length > 0 ? _trainer.Name.Substring(0, 1).ToUpper() : "?";
                Font font = new Font("Arial", 48, FontStyle.Bold);
                StringFormat format = new StringFormat();
                format.Alignment = StringAlignment.Center;
                format.LineAlignment = StringAlignment.Center;

                g.DrawString(firstLetter, font, Brushes.White, new RectangleF(0, 0, 120, 120), format);
            }
            picTrainerPhoto.Image = defaultImage;
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