using System;
using System.Drawing;
using System.Windows.Forms;
using GymClassBooking.SpotMe.Controls;
using GymClassBooking.SpotMe.Models;
using System.IO;

namespace GymClassBooking.SpotMe.View
{
    public partial class AddMemberForm : Form
    {
        public string MemberName { get; private set; }
        public string MemberEmail { get; private set; }
        public string MemberPhone { get; private set; }
        public string MemberGender { get; private set; }
        public string MemberFitnessGoal { get; private set; }
        public Image MemberPhoto { get; private set; }
        public string MemberPhotoPath { get; private set; }
        public int MemberId { get; private set; }
        public bool IsEditMode { get; private set; }
        public bool IsDeleted { get; private set; }

        // Color Palette
        private const int PRIMARY_HUE = 0x6F2C8C;      // Purple
        private const int GRAY_LIGHT = 0xF5F5F5;       // Light gray
        private const int GRAY_DARK = 0x666666;        // Dark gray
        private const int WHITE = 0xFFFFFF;            // White

        // Store the original member for reference
        private Member _originalMember;
        private string _originalPhotoPath;
        private Image _originalPhoto;

        public AddMemberForm()
        {
            InitializeComponent();
            ApplyColorPalette();
            this.Text = "Add New Member";
            IsEditMode = false;
            IsDeleted = false;
        }

        private Color ColorFromHex(int hex)
        {
            return Color.FromArgb((hex >> 16) & 0xFF, (hex >> 8) & 0xFF, hex & 0xFF);
        }

        private void ApplyColorPalette()
        {
            this.BackColor = ColorFromHex(WHITE);

            lblTitle.ForeColor = ColorFromHex(PRIMARY_HUE);
            lblName.ForeColor = ColorFromHex(GRAY_DARK);
            lblEmail.ForeColor = ColorFromHex(GRAY_DARK);
            lblPhone.ForeColor = ColorFromHex(GRAY_DARK);
            lblGender.ForeColor = ColorFromHex(GRAY_DARK);
            lblPhoto.ForeColor = ColorFromHex(GRAY_DARK);
            lblFitnessGoal.ForeColor = ColorFromHex(GRAY_DARK);

            txtName.BackColor = ColorFromHex(WHITE);
            txtName.ForeColor = ColorFromHex(GRAY_DARK);
            txtName.BorderStyle = BorderStyle.FixedSingle;

            txtEmail.BackColor = ColorFromHex(WHITE);
            txtEmail.ForeColor = ColorFromHex(GRAY_DARK);
            txtEmail.BorderStyle = BorderStyle.FixedSingle;

            txtPhone.BackColor = ColorFromHex(WHITE);
            txtPhone.ForeColor = ColorFromHex(GRAY_DARK);
            txtPhone.BorderStyle = BorderStyle.FixedSingle;

            cboGender.BackColor = ColorFromHex(WHITE);
            cboGender.ForeColor = ColorFromHex(GRAY_DARK);

            txtFitnessGoal.BackColor = ColorFromHex(WHITE);
            txtFitnessGoal.ForeColor = ColorFromHex(GRAY_DARK);
            txtFitnessGoal.BorderStyle = BorderStyle.FixedSingle;

            btnChoosePhoto.BackColor = ColorFromHex(GRAY_LIGHT);
            btnChoosePhoto.ForeColor = ColorFromHex(GRAY_DARK);
            btnChoosePhoto.FlatStyle = FlatStyle.Flat;
            btnChoosePhoto.Cursor = Cursors.Hand;

            btnSave.NormalColor = ColorFromHex(PRIMARY_HUE);
            btnSave.HoverColor = ColorFromHex(0x9B6BA6);
            btnSave.ForeColor = ColorFromHex(WHITE);

            btnCancel.NormalColor = ColorFromHex(GRAY_LIGHT);
            btnCancel.HoverColor = ColorFromHex(PRIMARY_HUE);
            btnCancel.ForeColor = ColorFromHex(GRAY_DARK);
        }

        public void LoadMemberData(Member member)
        {
            IsEditMode = true;
            this.Text = "Edit Member - " + member.Name;

            // Store the original member data
            _originalMember = member;
            _originalPhoto = member.Photo;
            _originalPhotoPath = member.PhotoPath;

            MemberId = member.Id;
            txtName.Text = member.Name;
            txtEmail.Text = member.Email;
            txtPhone.Text = member.Phone;
            txtFitnessGoal.Text = member.FitnessGoal;

            // Set gender in combo box
            if (!string.IsNullOrEmpty(member.Gender))
            {
                int index = cboGender.FindStringExact(member.Gender);
                if (index >= 0)
                    cboGender.SelectedIndex = index;
            }

            // Load photo if exists
            if (member.Photo != null)
            {
                MemberPhoto = member.Photo;
                picPreview.Image = member.Photo;
                MemberPhotoPath = member.PhotoPath;
            }
            else if (!string.IsNullOrEmpty(member.PhotoPath) && File.Exists(member.PhotoPath))
            {
                try
                {
                    MemberPhoto = Image.FromFile(member.PhotoPath);
                    MemberPhotoPath = member.PhotoPath;
                    picPreview.Image = MemberPhoto;
                }
                catch
                {
                    picPreview.Image = null;
                }
            }
        }

        private void btnChoosePhoto_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
                openFileDialog.Title = IsEditMode ? "Change Member Photo" : "Select Member Photo";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Dispose old image to prevent memory leaks
                        if (MemberPhoto != null && MemberPhoto != _originalPhoto)
                        {
                            MemberPhoto.Dispose();
                        }

                        MemberPhoto = Image.FromFile(openFileDialog.FileName);
                        MemberPhotoPath = openFileDialog.FileName;
                        picPreview.Image = MemberPhoto;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error loading image: {ex.Message}", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Validate inputs
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Name is required.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Email is required.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Phone is required.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cboGender.SelectedItem == null)
            {
                MessageBox.Show("Please select a gender.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Set properties
            MemberName = txtName.Text.Trim();
            MemberEmail = txtEmail.Text.Trim();
            MemberPhone = txtPhone.Text.Trim();
            MemberGender = cboGender.SelectedItem.ToString();
            MemberFitnessGoal = txtFitnessGoal.Text.Trim();

            // If no new photo was selected, keep the original
            if (MemberPhoto == null && _originalPhoto != null)
            {
                MemberPhoto = _originalPhoto;
                MemberPhotoPath = _originalPhotoPath;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}