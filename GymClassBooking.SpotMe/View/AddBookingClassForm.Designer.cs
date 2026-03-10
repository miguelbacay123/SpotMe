namespace GymClassBooking.SpotMe.View
{
    partial class AddBookingClassForm
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
            this.lblSessionInfo = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.lblTrainer = new System.Windows.Forms.Label();
            this.cboTrainer = new System.Windows.Forms.ComboBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblCapacity = new System.Windows.Forms.Label();
            this.nudCapacity = new System.Windows.Forms.NumericUpDown();
            this.lblDateAndTime = new System.Windows.Forms.Label();
            this.lblStartDateTime = new System.Windows.Forms.Label();
            this.lblEndDateTime = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.cboStartHour = new System.Windows.Forms.ComboBox();
            this.cboStartMinute = new System.Windows.Forms.ComboBox();
            this.cboStartAmPm = new System.Windows.Forms.ComboBox();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.cboEndHour = new System.Windows.Forms.ComboBox();
            this.cboEndMinute = new System.Windows.Forms.ComboBox();
            this.cboEndAmPm = new System.Windows.Forms.ComboBox();
            this.btnSave = new GymClassBooking.SpotMe.Controls.RoundedButton();
            this.btnCancel = new GymClassBooking.SpotMe.Controls.RoundedButton();
            ((System.ComponentModel.ISupportInitialize)(this.nudCapacity)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Sitka Heading", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.Purple;
            this.lblTitle.Location = new System.Drawing.Point(60, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(300, 40);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Create New Session";
            // 
            // lblSessionInfo
            // 
            this.lblSessionInfo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblSessionInfo.ForeColor = System.Drawing.Color.Purple;
            this.lblSessionInfo.Location = new System.Drawing.Point(60, 80);
            this.lblSessionInfo.Name = "lblSessionInfo";
            this.lblSessionInfo.Size = new System.Drawing.Size(200, 20);
            this.lblSessionInfo.TabIndex = 1;
            this.lblSessionInfo.Text = "Session Information";
            // 
            // lblCategory
            // 
            this.lblCategory.Location = new System.Drawing.Point(60, 115);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(80, 20);
            this.lblCategory.TabIndex = 2;
            this.lblCategory.Text = "Category:";
            // 
            // cboCategory
            // 
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(147, 113);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(220, 21);
            this.cboCategory.TabIndex = 3;
            // 
            // lblTrainer
            // 
            this.lblTrainer.Location = new System.Drawing.Point(410, 115);
            this.lblTrainer.Name = "lblTrainer";
            this.lblTrainer.Size = new System.Drawing.Size(80, 20);
            this.lblTrainer.TabIndex = 4;
            this.lblTrainer.Text = "Trainer:";
            // 
            // cboTrainer
            // 
            this.cboTrainer.FormattingEnabled = true;
            this.cboTrainer.Location = new System.Drawing.Point(497, 113);
            this.cboTrainer.Name = "cboTrainer";
            this.cboTrainer.Size = new System.Drawing.Size(210, 21);
            this.cboTrainer.TabIndex = 5;
            // 
            // lblDescription
            // 
            this.lblDescription.Location = new System.Drawing.Point(60, 155);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(80, 20);
            this.lblDescription.TabIndex = 6;
            this.lblDescription.Text = "Description:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(147, 155);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(560, 60);
            this.txtDescription.TabIndex = 7;
            // 
            // lblCapacity
            // 
            this.lblCapacity.Location = new System.Drawing.Point(60, 230);
            this.lblCapacity.Name = "lblCapacity";
            this.lblCapacity.Size = new System.Drawing.Size(80, 20);
            this.lblCapacity.TabIndex = 8;
            this.lblCapacity.Text = "Capacity:";
            // 
            // nudCapacity
            // 
            this.nudCapacity.Location = new System.Drawing.Point(147, 230);
            this.nudCapacity.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nudCapacity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCapacity.Name = "nudCapacity";
            this.nudCapacity.Size = new System.Drawing.Size(100, 20);
            this.nudCapacity.TabIndex = 9;
            this.nudCapacity.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // lblDateAndTime
            // 
            this.lblDateAndTime.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblDateAndTime.ForeColor = System.Drawing.Color.Purple;
            this.lblDateAndTime.Location = new System.Drawing.Point(60, 275);
            this.lblDateAndTime.Name = "lblDateAndTime";
            this.lblDateAndTime.Size = new System.Drawing.Size(200, 20);
            this.lblDateAndTime.TabIndex = 10;
            this.lblDateAndTime.Text = "Date & Time";
            // 
            // lblStartDateTime
            // 
            this.lblStartDateTime.Location = new System.Drawing.Point(60, 310);
            this.lblStartDateTime.Name = "lblStartDateTime";
            this.lblStartDateTime.Size = new System.Drawing.Size(150, 20);
            this.lblStartDateTime.TabIndex = 11;
            this.lblStartDateTime.Text = "Start Date & Time:";
            // 
            // lblEndDateTime
            // 
            this.lblEndDateTime.Location = new System.Drawing.Point(380, 310);
            this.lblEndDateTime.Name = "lblEndDateTime";
            this.lblEndDateTime.Size = new System.Drawing.Size(150, 20);
            this.lblEndDateTime.TabIndex = 16;
            this.lblEndDateTime.Text = "End Date & Time:";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDate.Location = new System.Drawing.Point(60, 335);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(110, 20);
            this.dtpStartDate.TabIndex = 12;
            // 
            // cboStartHour
            // 
            this.cboStartHour.FormattingEnabled = true;
            this.cboStartHour.Location = new System.Drawing.Point(180, 335);
            this.cboStartHour.Name = "cboStartHour";
            this.cboStartHour.Size = new System.Drawing.Size(50, 21);
            this.cboStartHour.TabIndex = 13;
            // 
            // cboStartMinute
            // 
            this.cboStartMinute.FormattingEnabled = true;
            this.cboStartMinute.Location = new System.Drawing.Point(235, 335);
            this.cboStartMinute.Name = "cboStartMinute";
            this.cboStartMinute.Size = new System.Drawing.Size(50, 21);
            this.cboStartMinute.TabIndex = 14;
            // 
            // cboStartAmPm
            // 
            this.cboStartAmPm.FormattingEnabled = true;
            this.cboStartAmPm.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.cboStartAmPm.Location = new System.Drawing.Point(290, 335);
            this.cboStartAmPm.Name = "cboStartAmPm";
            this.cboStartAmPm.Size = new System.Drawing.Size(60, 21);
            this.cboStartAmPm.TabIndex = 15;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndDate.Location = new System.Drawing.Point(380, 335);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(110, 20);
            this.dtpEndDate.TabIndex = 17;
            // 
            // cboEndHour
            // 
            this.cboEndHour.FormattingEnabled = true;
            this.cboEndHour.Location = new System.Drawing.Point(500, 335);
            this.cboEndHour.Name = "cboEndHour";
            this.cboEndHour.Size = new System.Drawing.Size(50, 21);
            this.cboEndHour.TabIndex = 18;
            // 
            // cboEndMinute
            // 
            this.cboEndMinute.FormattingEnabled = true;
            this.cboEndMinute.Location = new System.Drawing.Point(555, 335);
            this.cboEndMinute.Name = "cboEndMinute";
            this.cboEndMinute.Size = new System.Drawing.Size(50, 21);
            this.cboEndMinute.TabIndex = 19;
            // 
            // cboEndAmPm
            // 
            this.cboEndAmPm.FormattingEnabled = true;
            this.cboEndAmPm.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.cboEndAmPm.Location = new System.Drawing.Point(610, 335);
            this.cboEndAmPm.Name = "cboEndAmPm";
            this.cboEndAmPm.Size = new System.Drawing.Size(60, 21);
            this.cboEndAmPm.TabIndex = 20;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(44)))), ((int)(((byte)(140)))));
            this.btnSave.BorderRadius = 10;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(80)))), ((int)(((byte)(180)))));
            this.btnSave.Location = new System.Drawing.Point(485, 500);
            this.btnSave.Name = "btnSave";
            this.btnSave.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(44)))), ((int)(((byte)(140)))));
            this.btnSave.Size = new System.Drawing.Size(100, 45);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "Create";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(44)))), ((int)(((byte)(140)))));
            this.btnCancel.BorderRadius = 10;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(80)))), ((int)(((byte)(180)))));
            this.btnCancel.Location = new System.Drawing.Point(607, 500);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(44)))), ((int)(((byte)(140)))));
            this.btnCancel.Size = new System.Drawing.Size(100, 45);
            this.btnCancel.TabIndex = 22;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // AddBookingClassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 580);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblSessionInfo);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.cboCategory);
            this.Controls.Add(this.lblTrainer);
            this.Controls.Add(this.cboTrainer);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblCapacity);
            this.Controls.Add(this.nudCapacity);
            this.Controls.Add(this.lblDateAndTime);
            this.Controls.Add(this.lblStartDateTime);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.cboStartHour);
            this.Controls.Add(this.cboStartMinute);
            this.Controls.Add(this.cboStartAmPm);
            this.Controls.Add(this.lblEndDateTime);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.cboEndHour);
            this.Controls.Add(this.cboEndMinute);
            this.Controls.Add(this.cboEndAmPm);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddBookingClassForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create New Session";
            ((System.ComponentModel.ISupportInitialize)(this.nudCapacity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSessionInfo;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.Label lblTrainer;
        private System.Windows.Forms.ComboBox cboTrainer;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblCapacity;
        private System.Windows.Forms.NumericUpDown nudCapacity;
        private System.Windows.Forms.Label lblDateAndTime;
        private System.Windows.Forms.Label lblStartDateTime;
        private System.Windows.Forms.Label lblEndDateTime;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.ComboBox cboStartHour;
        private System.Windows.Forms.ComboBox cboStartMinute;
        private System.Windows.Forms.ComboBox cboStartAmPm;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.ComboBox cboEndHour;
        private System.Windows.Forms.ComboBox cboEndMinute;
        private System.Windows.Forms.ComboBox cboEndAmPm;
        private GymClassBooking.SpotMe.Controls.RoundedButton btnSave;
        private GymClassBooking.SpotMe.Controls.RoundedButton btnCancel;
    }
}