using System;
using System.Drawing;
using System.Windows.Forms;
using GymClassBooking.SpotMe.Controls;
using System.IO;

namespace GymClassBooking.SpotMe.View
{
    public partial class AddMemberForm : Form
    {
        public string MemberName { get; private set; }
        public string MemberEmail { get; private set; }
        public string MemberPhone { get; private set; }
        public string MemberGender { get; private set; }
        public Image MemberPhoto { get; private set; }
        public string MemberPhotoPath { get; private set; }

        public AddMemberForm()
        {
            InitializeComponent();
        }

        private void btnChoosePhoto_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
                openFileDialog.Title = "Select Member Photo";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Load image
                        MemberPhoto = Image.FromFile(openFileDialog.FileName);
                        MemberPhotoPath = openFileDialog.FileName;

                        // Display in preview
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