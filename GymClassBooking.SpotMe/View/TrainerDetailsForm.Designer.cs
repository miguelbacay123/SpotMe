namespace GymClassBooking.SpotMe.View
{
    partial class TrainerDetailsForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelMain = new System.Windows.Forms.Panel();
            this.picTrainerPhoto = new System.Windows.Forms.PictureBox();
            this.lblFullNameLabel = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblEmailLabel = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhoneLabel = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblGenderLabel = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblDateOfBirthLabel = new System.Windows.Forms.Label();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.lblAddressLabel = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblSpecializationsLabel = new System.Windows.Forms.Label();
            this.lblSpecializations = new System.Windows.Forms.Label();
            this.btnBackToList = new GymClassBooking.SpotMe.Controls.RoundedButton();
            this.btnDone = new GymClassBooking.SpotMe.Controls.RoundedButton();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTrainerPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.White;
            this.panelMain.Controls.Add(this.picTrainerPhoto);
            this.panelMain.Controls.Add(this.lblFullNameLabel);
            this.panelMain.Controls.Add(this.lblFullName);
            this.panelMain.Controls.Add(this.lblEmailLabel);
            this.panelMain.Controls.Add(this.lblEmail);
            this.panelMain.Controls.Add(this.lblPhoneLabel);
            this.panelMain.Controls.Add(this.lblPhone);
            this.panelMain.Controls.Add(this.lblGenderLabel);
            this.panelMain.Controls.Add(this.lblGender);
            this.panelMain.Controls.Add(this.lblDateOfBirthLabel);
            this.panelMain.Controls.Add(this.lblDateOfBirth);
            this.panelMain.Controls.Add(this.lblAddressLabel);
            this.panelMain.Controls.Add(this.lblAddress);
            this.panelMain.Controls.Add(this.lblSpecializationsLabel);
            this.panelMain.Controls.Add(this.lblSpecializations);
            this.panelMain.Controls.Add(this.btnBackToList);
            this.panelMain.Controls.Add(this.btnDone);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(500, 520);
            this.panelMain.TabIndex = 0;
            // 
            // picTrainerPhoto
            // 
            this.picTrainerPhoto.BackColor = System.Drawing.Color.LightGray;
            this.picTrainerPhoto.Location = new System.Drawing.Point(190, 30);
            this.picTrainerPhoto.Name = "picTrainerPhoto";
            this.picTrainerPhoto.Size = new System.Drawing.Size(120, 120);
            this.picTrainerPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTrainerPhoto.TabIndex = 0;
            this.picTrainerPhoto.TabStop = false;
            // 
            // lblFullNameLabel
            // 
            this.lblFullNameLabel.AutoSize = true;
            this.lblFullNameLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblFullNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(44)))), ((int)(((byte)(140)))));
            this.lblFullNameLabel.Location = new System.Drawing.Point(50, 180);
            this.lblFullNameLabel.Name = "lblFullNameLabel";
            this.lblFullNameLabel.Size = new System.Drawing.Size(80, 19);
            this.lblFullNameLabel.TabIndex = 1;
            this.lblFullNameLabel.Text = "Full Name:";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblFullName.ForeColor = System.Drawing.Color.Black;
            this.lblFullName.Location = new System.Drawing.Point(150, 180);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(88, 19);
            this.lblFullName.TabIndex = 2;
            this.lblFullName.Text = "Not specified";
            // 
            // lblEmailLabel
            // 
            this.lblEmailLabel.AutoSize = true;
            this.lblEmailLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblEmailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(44)))), ((int)(((byte)(140)))));
            this.lblEmailLabel.Location = new System.Drawing.Point(50, 220);
            this.lblEmailLabel.Name = "lblEmailLabel";
            this.lblEmailLabel.Size = new System.Drawing.Size(49, 19);
            this.lblEmailLabel.TabIndex = 3;
            this.lblEmailLabel.Text = "Email:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblEmail.ForeColor = System.Drawing.Color.Black;
            this.lblEmail.Location = new System.Drawing.Point(150, 220);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(88, 19);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Not specified";
            // 
            // lblPhoneLabel
            // 
            this.lblPhoneLabel.AutoSize = true;
            this.lblPhoneLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPhoneLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(44)))), ((int)(((byte)(140)))));
            this.lblPhoneLabel.Location = new System.Drawing.Point(50, 260);
            this.lblPhoneLabel.Name = "lblPhoneLabel";
            this.lblPhoneLabel.Size = new System.Drawing.Size(55, 19);
            this.lblPhoneLabel.TabIndex = 5;
            this.lblPhoneLabel.Text = "Phone:";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPhone.ForeColor = System.Drawing.Color.Black;
            this.lblPhone.Location = new System.Drawing.Point(150, 260);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(88, 19);
            this.lblPhone.TabIndex = 6;
            this.lblPhone.Text = "Not specified";
            // 
            // lblGenderLabel
            // 
            this.lblGenderLabel.AutoSize = true;
            this.lblGenderLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblGenderLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(44)))), ((int)(((byte)(140)))));
            this.lblGenderLabel.Location = new System.Drawing.Point(50, 300);
            this.lblGenderLabel.Name = "lblGenderLabel";
            this.lblGenderLabel.Size = new System.Drawing.Size(63, 19);
            this.lblGenderLabel.TabIndex = 7;
            this.lblGenderLabel.Text = "Gender:";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblGender.ForeColor = System.Drawing.Color.Black;
            this.lblGender.Location = new System.Drawing.Point(150, 300);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(88, 19);
            this.lblGender.TabIndex = 8;
            this.lblGender.Text = "Not specified";
            // 
            // lblDateOfBirthLabel
            // 
            this.lblDateOfBirthLabel.AutoSize = true;
            this.lblDateOfBirthLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblDateOfBirthLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(44)))), ((int)(((byte)(140)))));
            this.lblDateOfBirthLabel.Location = new System.Drawing.Point(50, 340);
            this.lblDateOfBirthLabel.Name = "lblDateOfBirthLabel";
            this.lblDateOfBirthLabel.Size = new System.Drawing.Size(80, 19);
            this.lblDateOfBirthLabel.TabIndex = 9;
            this.lblDateOfBirthLabel.Text = "Birth Date:";
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDateOfBirth.ForeColor = System.Drawing.Color.Black;
            this.lblDateOfBirth.Location = new System.Drawing.Point(150, 340);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(88, 19);
            this.lblDateOfBirth.TabIndex = 10;
            this.lblDateOfBirth.Text = "Not specified";
            // 
            // lblAddressLabel
            // 
            this.lblAddressLabel.AutoSize = true;
            this.lblAddressLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblAddressLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(44)))), ((int)(((byte)(140)))));
            this.lblAddressLabel.Location = new System.Drawing.Point(50, 380);
            this.lblAddressLabel.Name = "lblAddressLabel";
            this.lblAddressLabel.Size = new System.Drawing.Size(67, 19);
            this.lblAddressLabel.TabIndex = 11;
            this.lblAddressLabel.Text = "Address:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblAddress.ForeColor = System.Drawing.Color.Black;
            this.lblAddress.Location = new System.Drawing.Point(150, 380);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(88, 19);
            this.lblAddress.TabIndex = 12;
            this.lblAddress.Text = "Not specified";
            // 
            // lblSpecializationsLabel
            // 
            this.lblSpecializationsLabel.AutoSize = true;
            this.lblSpecializationsLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSpecializationsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(44)))), ((int)(((byte)(140)))));
            this.lblSpecializationsLabel.Location = new System.Drawing.Point(50, 420);
            this.lblSpecializationsLabel.Name = "lblSpecializationsLabel";
            this.lblSpecializationsLabel.Size = new System.Drawing.Size(84, 19);
            this.lblSpecializationsLabel.TabIndex = 13;
            this.lblSpecializationsLabel.Text = "Specialties:";
            // 
            // lblSpecializations
            // 
            this.lblSpecializations.AutoSize = true;
            this.lblSpecializations.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSpecializations.ForeColor = System.Drawing.Color.Black;
            this.lblSpecializations.Location = new System.Drawing.Point(150, 420);
            this.lblSpecializations.Name = "lblSpecializations";
            this.lblSpecializations.Size = new System.Drawing.Size(88, 19);
            this.lblSpecializations.TabIndex = 14;
            this.lblSpecializations.Text = "Not specified";
            // 
            // btnBackToList
            // 
            this.btnBackToList.BackColor = System.Drawing.Color.LightGray;
            this.btnBackToList.BorderRadius = 10;
            this.btnBackToList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackToList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackToList.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnBackToList.ForeColor = System.Drawing.Color.Black;
            this.btnBackToList.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(80)))), ((int)(((byte)(180)))));
            this.btnBackToList.Location = new System.Drawing.Point(100, 460);
            this.btnBackToList.Name = "btnBackToList";
            this.btnBackToList.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(44)))), ((int)(((byte)(140)))));
            this.btnBackToList.Size = new System.Drawing.Size(120, 40);
            this.btnBackToList.TabIndex = 15;
            this.btnBackToList.Text = "Back to List";
            this.btnBackToList.UseVisualStyleBackColor = false;
            this.btnBackToList.Click += new System.EventHandler(this.btnBackToList_Click);
            // 
            // btnDone
            // 
            this.btnDone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(44)))), ((int)(((byte)(140)))));
            this.btnDone.BorderRadius = 10;
            this.btnDone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDone.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDone.ForeColor = System.Drawing.Color.White;
            this.btnDone.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(80)))), ((int)(((byte)(180)))));
            this.btnDone.Location = new System.Drawing.Point(250, 460);
            this.btnDone.Name = "btnDone";
            this.btnDone.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(44)))), ((int)(((byte)(140)))));
            this.btnDone.Size = new System.Drawing.Size(120, 40);
            this.btnDone.TabIndex = 16;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = false;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // TrainerDetailsForm
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(500, 520);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TrainerDetailsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTrainerPhoto)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.PictureBox picTrainerPhoto;
        private System.Windows.Forms.Label lblFullNameLabel;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblEmailLabel;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhoneLabel;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblGenderLabel;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblDateOfBirthLabel;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.Label lblAddressLabel;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblSpecializationsLabel;
        private System.Windows.Forms.Label lblSpecializations;
        private Controls.RoundedButton btnBackToList;
        private Controls.RoundedButton btnDone;
    }
}