using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using GymClassBooking.SpotMe.Controls;
using GymClassBooking.SpotMe.Models;
using System.IO;
using System.Linq;

namespace GymClassBooking.SpotMe.View
{
    public partial class AddTrainerForm : Form
    {
        // Color Palette
        private const int PRIMARY_HUE = 0x6F2C8C;      // Purple
        private const int GRAY_LIGHT = 0xF5F5F5;       // Light gray
        private const int GRAY_DARK = 0x666666;        // Dark gray
        private const int WHITE = 0xFFFFFF;            // White

        public string TrainerName { get; private set; }
        public string TrainerEmail { get; private set; }
        public string TrainerPhone { get; private set; }
        public DateTime? TrainerDateOfBirth { get; private set; }
        public string TrainerGender { get; private set; }
        public string TrainerAddress { get; private set; }
        public List<string> TrainerSpecializations { get; private set; }
        public Image TrainerPhoto { get; private set; }
        public string TrainerPhotoPath { get; private set; }
        public int TrainerId { get; private set; }
        public bool IsEditMode { get; private set; }

        // Store the original trainer for reference
        private Trainer _originalTrainer;
        private string _originalPhotoPath;
        private Image _originalPhoto;
        private List<CheckBox> specializationCheckBoxes = new List<CheckBox>();

        public AddTrainerForm()
        {
            InitializeComponent();
            ApplyColorPalette();
            this.Text = "Add New Trainer";
            IsEditMode = false;
            TrainerSpecializations = new List<string>();
            SetupSpecializationCheckBoxes();

            // Set button text for Add mode
            btnSave.Text = "Save";
        }

        public void LoadTrainerData(Trainer trainer)
        {
            IsEditMode = true;
            this.Text = "Edit Trainer - " + trainer.Name;

            // Change button text for Edit mode
            btnSave.Text = "Save";

            // Store the original trainer data
            _originalTrainer = trainer;
            _originalPhoto = trainer.Photo;
            _originalPhotoPath = trainer.PhotoPath;

            TrainerId = trainer.Id;
            txtName.Text = trainer.Name;
            txtEmail.Text = trainer.Email;
            txtPhone.Text = trainer.Phone;

            // Set date of birth if exists
            if (trainer.DateOfBirth.HasValue)
                dtpDateOfBirth.Value = trainer.DateOfBirth.Value;

            // Set gender in combo box
            if (!string.IsNullOrEmpty(trainer.Gender))
            {
                int index = cboGender.FindStringExact(trainer.Gender);
                if (index >= 0)
                    cboGender.SelectedIndex = index;
            }

            txtAddress.Text = trainer.Address;

            // Set specializations
            if (trainer.Specializations != null)
            {
                foreach (var checkBox in specializationCheckBoxes)
                {
                    checkBox.Checked = trainer.Specializations.Contains(checkBox.Text);
                }
            }

            // Load photo if exists
            if (trainer.Photo != null)
            {
                TrainerPhoto = trainer.Photo;
                picPreview.Image = trainer.Photo;
                TrainerPhotoPath = trainer.PhotoPath;
            }
            else if (!string.IsNullOrEmpty(trainer.PhotoPath) && File.Exists(trainer.PhotoPath))
            {
                try
                {
                    TrainerPhoto = Image.FromFile(trainer.PhotoPath);
                    TrainerPhotoPath = trainer.PhotoPath;
                    picPreview.Image = TrainerPhoto;
                }
                catch
                {
                    picPreview.Image = null;
                }
            }
        }

        private Color ColorFromHex(int hex)
        {
            return Color.FromArgb((hex >> 16) & 0xFF, (hex >> 8) & 0xFF, hex & 0xFF);
        }

        private void ApplyColorPalette()
        {
            this.BackColor = ColorFromHex(WHITE);

            lblTitle.ForeColor = ColorFromHex(PRIMARY_HUE);
            lblPersonalInfo.ForeColor = ColorFromHex(PRIMARY_HUE);
            lblProfessionalInfo.ForeColor = ColorFromHex(PRIMARY_HUE);

            lblPhoto.ForeColor = ColorFromHex(GRAY_DARK);
            lblName.ForeColor = ColorFromHex(GRAY_DARK);
            lblEmail.ForeColor = ColorFromHex(GRAY_DARK);
            lblPhone.ForeColor = ColorFromHex(GRAY_DARK);
            lblDateOfBirth.ForeColor = ColorFromHex(GRAY_DARK);
            lblGender.ForeColor = ColorFromHex(GRAY_DARK);
            lblAddress.ForeColor = ColorFromHex(GRAY_DARK);
            lblSpecializations.ForeColor = ColorFromHex(GRAY_DARK);

            btnChoosePhoto.BackColor = ColorFromHex(GRAY_LIGHT);
            btnChoosePhoto.ForeColor = ColorFromHex(GRAY_DARK);
            btnChoosePhoto.Cursor = Cursors.Hand;

            // Apply color to all checkboxes
            foreach (CheckBox chk in specializationCheckBoxes)
            {
                chk.ForeColor = ColorFromHex(GRAY_DARK);
            }

            btnSave.NormalColor = ColorFromHex(PRIMARY_HUE);
            btnSave.HoverColor = ColorFromHex(0x9B6BA6);
            btnSave.ForeColor = ColorFromHex(WHITE);

            btnCancel.NormalColor = ColorFromHex(GRAY_LIGHT);
            btnCancel.HoverColor = ColorFromHex(PRIMARY_HUE);
            btnCancel.ForeColor = ColorFromHex(GRAY_DARK);
        }

        private void SetupSpecializationCheckBoxes()
        {
            // Add all specialization checkboxes to the list
            specializationCheckBoxes.Clear();

            if (chkGeneralFitness != null) specializationCheckBoxes.Add(chkGeneralFitness);
            if (chkYoga != null) specializationCheckBoxes.Add(chkYoga);
            if (chkBoxing != null) specializationCheckBoxes.Add(chkBoxing);
            if (chkCrossFit != null) specializationCheckBoxes.Add(chkCrossFit);
            if (chkPilates != null) specializationCheckBoxes.Add(chkPilates);
            if (chkWeightTraining != null) specializationCheckBoxes.Add(chkWeightTraining);
            if (chkCardio != null) specializationCheckBoxes.Add(chkCardio);
            if (chkZumba != null) specializationCheckBoxes.Add(chkZumba);
        }

        private void btnChoosePhoto_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
                openFileDialog.Title = IsEditMode ? "Change Trainer Photo" : "Select Trainer Photo";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Dispose old image to prevent memory leaks
                        if (TrainerPhoto != null && TrainerPhoto != _originalPhoto)
                        {
                            TrainerPhoto.Dispose();
                        }

                        TrainerPhoto = Image.FromFile(openFileDialog.FileName);
                        TrainerPhotoPath = openFileDialog.FileName;
                        picPreview.Image = TrainerPhoto;
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

            // Get selected specializations
            TrainerSpecializations.Clear();
            foreach (var checkBox in specializationCheckBoxes)
            {
                if (checkBox.Checked)
                {
                    TrainerSpecializations.Add(checkBox.Text);
                }
            }

            // Set properties
            TrainerName = txtName.Text.Trim();
            TrainerEmail = txtEmail.Text.Trim();
            TrainerPhone = txtPhone.Text.Trim();
            TrainerDateOfBirth = dtpDateOfBirth.Checked ? dtpDateOfBirth.Value : (DateTime?)null;
            TrainerGender = cboGender.SelectedItem?.ToString();
            TrainerAddress = txtAddress.Text.Trim();

            // If no new photo was selected, keep the original
            if (TrainerPhoto == null && _originalPhoto != null)
            {
                TrainerPhoto = _originalPhoto;
                TrainerPhotoPath = _originalPhotoPath;
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