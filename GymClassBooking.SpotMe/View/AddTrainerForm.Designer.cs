namespace GymClassBooking.SpotMe.View
{
    partial class AddTrainerForm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnSave = new GymClassBooking.SpotMe.Controls.RoundedButton();
            this.btnCancel = new GymClassBooking.SpotMe.Controls.RoundedButton();
            this.picPreview = new GymClassBooking.SpotMe.Controls.CircularPictureBox();
            this.lblPersonalInfo = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.lblGender = new System.Windows.Forms.Label();
            this.cboGender = new System.Windows.Forms.ComboBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblProfessionalInfo = new System.Windows.Forms.Label();
            this.lblSpecializations = new System.Windows.Forms.Label();
            this.chkGeneralFitness = new System.Windows.Forms.CheckBox();
            this.chkYoga = new System.Windows.Forms.CheckBox();
            this.chkBoxing = new System.Windows.Forms.CheckBox();
            this.chkCrossFit = new System.Windows.Forms.CheckBox();
            this.chkPilates = new System.Windows.Forms.CheckBox();
            this.chkWeightTraining = new System.Windows.Forms.CheckBox();
            this.chkCardio = new System.Windows.Forms.CheckBox();
            this.chkZumba = new System.Windows.Forms.CheckBox();
            this.lblPhoto = new System.Windows.Forms.Label();
            this.btnChoosePhoto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Sitka Heading", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.Purple;
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(250, 35);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Add New Trainer";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(44)))), ((int)(((byte)(140)))));
            this.btnSave.BorderRadius = 10;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(80)))), ((int)(((byte)(180)))));
            this.btnSave.Location = new System.Drawing.Point(140, 530);
            this.btnSave.Name = "btnSave";
            this.btnSave.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(44)))), ((int)(((byte)(140)))));
            this.btnSave.Size = new System.Drawing.Size(100, 35);
            this.btnSave.TabIndex = 27;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(44)))), ((int)(((byte)(140)))));
            this.btnCancel.BorderRadius = 10;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(80)))), ((int)(((byte)(180)))));
            this.btnCancel.Location = new System.Drawing.Point(260, 530);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(44)))), ((int)(((byte)(140)))));
            this.btnCancel.Size = new System.Drawing.Size(100, 35);
            this.btnCancel.TabIndex = 28;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // picPreview
            // 
            this.picPreview.BackColor = System.Drawing.Color.LightGray;
            this.picPreview.Location = new System.Drawing.Point(240, 75);
            this.picPreview.Name = "picPreview";
            this.picPreview.Size = new System.Drawing.Size(60, 50);
            this.picPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPreview.TabIndex = 4;
            this.picPreview.TabStop = false;
            // 
            // lblPersonalInfo
            // 
            this.lblPersonalInfo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblPersonalInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(44)))), ((int)(((byte)(140)))));
            this.lblPersonalInfo.Location = new System.Drawing.Point(20, 60);
            this.lblPersonalInfo.Name = "lblPersonalInfo";
            this.lblPersonalInfo.Size = new System.Drawing.Size(200, 20);
            this.lblPersonalInfo.TabIndex = 1;
            this.lblPersonalInfo.Text = "Personal Information";
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblName.Location = new System.Drawing.Point(30, 135);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(80, 15);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(120, 132);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(250, 20);
            this.txtName.TabIndex = 6;
            // 
            // lblEmail
            // 
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblEmail.Location = new System.Drawing.Point(30, 167);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(80, 15);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(120, 164);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(250, 20);
            this.txtEmail.TabIndex = 8;
            // 
            // lblPhone
            // 
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPhone.Location = new System.Drawing.Point(30, 199);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(80, 15);
            this.lblPhone.TabIndex = 9;
            this.lblPhone.Text = "Phone:";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(120, 196);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(250, 20);
            this.txtPhone.TabIndex = 10;
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDateOfBirth.Location = new System.Drawing.Point(30, 231);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(90, 15);
            this.lblDateOfBirth.TabIndex = 11;
            this.lblDateOfBirth.Text = "Date of Birth:";
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateOfBirth.Location = new System.Drawing.Point(120, 228);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(120, 20);
            this.dtpDateOfBirth.TabIndex = 12;
            // 
            // lblGender
            // 
            this.lblGender.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblGender.Location = new System.Drawing.Point(250, 231);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(60, 15);
            this.lblGender.TabIndex = 13;
            this.lblGender.Text = "Gender:";
            // 
            // cboGender
            // 
            this.cboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.cboGender.Location = new System.Drawing.Point(310, 228);
            this.cboGender.Name = "cboGender";
            this.cboGender.Size = new System.Drawing.Size(100, 21);
            this.cboGender.TabIndex = 14;
            // 
            // lblAddress
            // 
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblAddress.Location = new System.Drawing.Point(30, 263);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(80, 15);
            this.lblAddress.TabIndex = 15;
            this.lblAddress.Text = "Address:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(120, 260);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(330, 20);
            this.txtAddress.TabIndex = 16;
            // 
            // lblProfessionalInfo
            // 
            this.lblProfessionalInfo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblProfessionalInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(44)))), ((int)(((byte)(140)))));
            this.lblProfessionalInfo.Location = new System.Drawing.Point(20, 310);
            this.lblProfessionalInfo.Name = "lblProfessionalInfo";
            this.lblProfessionalInfo.Size = new System.Drawing.Size(200, 20);
            this.lblProfessionalInfo.TabIndex = 17;
            this.lblProfessionalInfo.Text = "Professional Information";
            // 
            // lblSpecializations
            // 
            this.lblSpecializations.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSpecializations.Location = new System.Drawing.Point(30, 340);
            this.lblSpecializations.Name = "lblSpecializations";
            this.lblSpecializations.Size = new System.Drawing.Size(100, 15);
            this.lblSpecializations.TabIndex = 18;
            this.lblSpecializations.Text = "Specializations:";
            // 
            // chkGeneralFitness
            // 
            this.chkGeneralFitness.Location = new System.Drawing.Point(40, 365);
            this.chkGeneralFitness.Name = "chkGeneralFitness";
            this.chkGeneralFitness.Size = new System.Drawing.Size(120, 20);
            this.chkGeneralFitness.TabIndex = 19;
            this.chkGeneralFitness.Text = "General Fitness";
            // 
            // chkYoga
            // 
            this.chkYoga.Location = new System.Drawing.Point(40, 390);
            this.chkYoga.Name = "chkYoga";
            this.chkYoga.Size = new System.Drawing.Size(120, 20);
            this.chkYoga.TabIndex = 20;
            this.chkYoga.Text = "Yoga";
            // 
            // chkBoxing
            // 
            this.chkBoxing.Location = new System.Drawing.Point(40, 415);
            this.chkBoxing.Name = "chkBoxing";
            this.chkBoxing.Size = new System.Drawing.Size(120, 20);
            this.chkBoxing.TabIndex = 21;
            this.chkBoxing.Text = "Boxing";
            // 
            // chkCrossFit
            // 
            this.chkCrossFit.Location = new System.Drawing.Point(40, 440);
            this.chkCrossFit.Name = "chkCrossFit";
            this.chkCrossFit.Size = new System.Drawing.Size(120, 20);
            this.chkCrossFit.TabIndex = 22;
            this.chkCrossFit.Text = "CrossFit";
            // 
            // chkPilates
            // 
            this.chkPilates.Location = new System.Drawing.Point(200, 365);
            this.chkPilates.Name = "chkPilates";
            this.chkPilates.Size = new System.Drawing.Size(120, 20);
            this.chkPilates.TabIndex = 23;
            this.chkPilates.Text = "Pilates";
            // 
            // chkWeightTraining
            // 
            this.chkWeightTraining.Location = new System.Drawing.Point(200, 390);
            this.chkWeightTraining.Name = "chkWeightTraining";
            this.chkWeightTraining.Size = new System.Drawing.Size(120, 20);
            this.chkWeightTraining.TabIndex = 24;
            this.chkWeightTraining.Text = "Weight Training";
            // 
            // chkCardio
            // 
            this.chkCardio.Location = new System.Drawing.Point(200, 415);
            this.chkCardio.Name = "chkCardio";
            this.chkCardio.Size = new System.Drawing.Size(120, 20);
            this.chkCardio.TabIndex = 25;
            this.chkCardio.Text = "Cardio";
            // 
            // chkZumba
            // 
            this.chkZumba.Location = new System.Drawing.Point(200, 440);
            this.chkZumba.Name = "chkZumba";
            this.chkZumba.Size = new System.Drawing.Size(120, 20);
            this.chkZumba.TabIndex = 26;
            this.chkZumba.Text = "Zumba";
            // 
            // lblPhoto
            // 
            this.lblPhoto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPhoto.Location = new System.Drawing.Point(30, 90);
            this.lblPhoto.Name = "lblPhoto";
            this.lblPhoto.Size = new System.Drawing.Size(80, 15);
            this.lblPhoto.TabIndex = 2;
            this.lblPhoto.Text = "Photo:";
            // 
            // btnChoosePhoto
            // 
            this.btnChoosePhoto.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnChoosePhoto.Location = new System.Drawing.Point(120, 85);
            this.btnChoosePhoto.Name = "btnChoosePhoto";
            this.btnChoosePhoto.Size = new System.Drawing.Size(100, 25);
            this.btnChoosePhoto.TabIndex = 3;
            this.btnChoosePhoto.Text = "Choose Photo";
            this.btnChoosePhoto.UseVisualStyleBackColor = true;
            this.btnChoosePhoto.Click += new System.EventHandler(this.btnChoosePhoto_Click);
            // 
            // AddTrainerForm
            // 
            this.ClientSize = new System.Drawing.Size(500, 600);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblPersonalInfo);
            this.Controls.Add(this.lblPhoto);
            this.Controls.Add(this.btnChoosePhoto);
            this.Controls.Add(this.picPreview);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblDateOfBirth);
            this.Controls.Add(this.dtpDateOfBirth);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.cboGender);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblProfessionalInfo);
            this.Controls.Add(this.lblSpecializations);
            this.Controls.Add(this.chkGeneralFitness);
            this.Controls.Add(this.chkYoga);
            this.Controls.Add(this.chkBoxing);
            this.Controls.Add(this.chkCrossFit);
            this.Controls.Add(this.chkPilates);
            this.Controls.Add(this.chkWeightTraining);
            this.Controls.Add(this.chkCardio);
            this.Controls.Add(this.chkZumba);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddTrainerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add New Trainer";
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblTitle;
        private Controls.RoundedButton btnSave;
        private Controls.RoundedButton btnCancel;
        private Controls.CircularPictureBox picPreview;

        // Personal Info
        private System.Windows.Forms.Label lblPersonalInfo;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.ComboBox cboGender;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;

        // Professional Info
        private System.Windows.Forms.Label lblProfessionalInfo;
        private System.Windows.Forms.Label lblSpecializations;

        // Specialization Checkboxes
        private System.Windows.Forms.CheckBox chkGeneralFitness;
        private System.Windows.Forms.CheckBox chkYoga;
        private System.Windows.Forms.CheckBox chkBoxing;
        private System.Windows.Forms.CheckBox chkCrossFit;
        private System.Windows.Forms.CheckBox chkPilates;
        private System.Windows.Forms.CheckBox chkWeightTraining;
        private System.Windows.Forms.CheckBox chkCardio;
        private System.Windows.Forms.CheckBox chkZumba;

        // Photo controls
        private System.Windows.Forms.Label lblPhoto;
        private System.Windows.Forms.Button btnChoosePhoto;
    }
}