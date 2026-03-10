namespace GymClassBooking.SpotMe.View
{
    partial class MemberDetailsForm
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
            this.picMemberPhoto = new System.Windows.Forms.PictureBox();
            this.lblFullNameLabel = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblEmailLabel = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhoneLabel = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblGenderLabel = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblFitnessGoalLabel = new System.Windows.Forms.Label();
            this.lblFitnessGoal = new System.Windows.Forms.Label();
            this.btnBackToList = new GymClassBooking.SpotMe.Controls.RoundedButton();
            this.btnDone = new GymClassBooking.SpotMe.Controls.RoundedButton();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMemberPhoto)).BeginInit();
            this.SuspendLayout();

            // panelMain
            this.panelMain.BackColor = System.Drawing.Color.White;
            this.panelMain.Controls.Add(this.picMemberPhoto);
            this.panelMain.Controls.Add(this.lblFullNameLabel);
            this.panelMain.Controls.Add(this.lblFullName);
            this.panelMain.Controls.Add(this.lblEmailLabel);
            this.panelMain.Controls.Add(this.lblEmail);
            this.panelMain.Controls.Add(this.lblPhoneLabel);
            this.panelMain.Controls.Add(this.lblPhone);
            this.panelMain.Controls.Add(this.lblGenderLabel);
            this.panelMain.Controls.Add(this.lblGender);
            this.panelMain.Controls.Add(this.lblFitnessGoalLabel);
            this.panelMain.Controls.Add(this.lblFitnessGoal);
            this.panelMain.Controls.Add(this.btnBackToList);
            this.panelMain.Controls.Add(this.btnDone);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(500, 520);
            this.panelMain.TabIndex = 0;

            // picMemberPhoto
            this.picMemberPhoto.BackColor = System.Drawing.Color.LightGray;
            this.picMemberPhoto.Location = new System.Drawing.Point(190, 30);
            this.picMemberPhoto.Name = "picMemberPhoto";
            this.picMemberPhoto.Size = new System.Drawing.Size(120, 120);
            this.picMemberPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMemberPhoto.TabIndex = 0;
            this.picMemberPhoto.TabStop = false;

            // lblFullNameLabel
            this.lblFullNameLabel.AutoSize = true;
            this.lblFullNameLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblFullNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(44)))), ((int)(((byte)(140)))));
            this.lblFullNameLabel.Location = new System.Drawing.Point(50, 180);
            this.lblFullNameLabel.Name = "lblFullNameLabel";
            this.lblFullNameLabel.Size = new System.Drawing.Size(80, 19);
            this.lblFullNameLabel.TabIndex = 1;
            this.lblFullNameLabel.Text = "Full Name:";

            // lblFullName
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblFullName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.lblFullName.Location = new System.Drawing.Point(150, 180);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(88, 19);
            this.lblFullName.TabIndex = 2;
            this.lblFullName.Text = "Not specified";

            // lblEmailLabel
            this.lblEmailLabel.AutoSize = true;
            this.lblEmailLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblEmailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(44)))), ((int)(((byte)(140)))));
            this.lblEmailLabel.Location = new System.Drawing.Point(50, 220);
            this.lblEmailLabel.Name = "lblEmailLabel";
            this.lblEmailLabel.Size = new System.Drawing.Size(49, 19);
            this.lblEmailLabel.TabIndex = 3;
            this.lblEmailLabel.Text = "Email:";

            // lblEmail
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.lblEmail.Location = new System.Drawing.Point(150, 220);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(88, 19);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Not specified";

            // lblPhoneLabel
            this.lblPhoneLabel.AutoSize = true;
            this.lblPhoneLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPhoneLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(44)))), ((int)(((byte)(140)))));
            this.lblPhoneLabel.Location = new System.Drawing.Point(50, 260);
            this.lblPhoneLabel.Name = "lblPhoneLabel";
            this.lblPhoneLabel.Size = new System.Drawing.Size(55, 19);
            this.lblPhoneLabel.TabIndex = 5;
            this.lblPhoneLabel.Text = "Phone:";

            // lblPhone
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.lblPhone.Location = new System.Drawing.Point(150, 260);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(88, 19);
            this.lblPhone.TabIndex = 6;
            this.lblPhone.Text = "Not specified";

            // lblGenderLabel
            this.lblGenderLabel.AutoSize = true;
            this.lblGenderLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblGenderLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(44)))), ((int)(((byte)(140)))));
            this.lblGenderLabel.Location = new System.Drawing.Point(50, 300);
            this.lblGenderLabel.Name = "lblGenderLabel";
            this.lblGenderLabel.Size = new System.Drawing.Size(63, 19);
            this.lblGenderLabel.TabIndex = 7;
            this.lblGenderLabel.Text = "Gender:";

            // lblGender
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.lblGender.Location = new System.Drawing.Point(150, 300);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(88, 19);
            this.lblGender.TabIndex = 8;
            this.lblGender.Text = "Not specified";

            // lblFitnessGoalLabel
            this.lblFitnessGoalLabel.AutoSize = true;
            this.lblFitnessGoalLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblFitnessGoalLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(44)))), ((int)(((byte)(140)))));
            this.lblFitnessGoalLabel.Location = new System.Drawing.Point(50, 340);
            this.lblFitnessGoalLabel.Name = "lblFitnessGoalLabel";
            this.lblFitnessGoalLabel.Size = new System.Drawing.Size(100, 19);
            this.lblFitnessGoalLabel.TabIndex = 9;
            this.lblFitnessGoalLabel.Text = "Fitness Goal:";

            // lblFitnessGoal
            this.lblFitnessGoal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFitnessGoal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.lblFitnessGoal.Location = new System.Drawing.Point(50, 359);
            this.lblFitnessGoal.Name = "lblFitnessGoal";
            this.lblFitnessGoal.Size = new System.Drawing.Size(400, 60);
            this.lblFitnessGoal.TabIndex = 10;
            this.lblFitnessGoal.Text = "Not specified";

            // btnBackToList
            this.btnBackToList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.btnBackToList.BorderRadius = 10;
            this.btnBackToList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackToList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackToList.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnBackToList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(44)))), ((int)(((byte)(140)))));
            this.btnBackToList.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(80)))), ((int)(((byte)(180)))));
            this.btnBackToList.Location = new System.Drawing.Point(100, 440);
            this.btnBackToList.Name = "btnBackToList";
            this.btnBackToList.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.btnBackToList.Size = new System.Drawing.Size(120, 40);
            this.btnBackToList.TabIndex = 11;
            this.btnBackToList.Text = "Back to List";
            this.btnBackToList.UseVisualStyleBackColor = false;
            this.btnBackToList.Click += new System.EventHandler(this.btnBackToList_Click);

            // btnDone
            this.btnDone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(44)))), ((int)(((byte)(140)))));
            this.btnDone.BorderRadius = 10;
            this.btnDone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDone.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDone.ForeColor = System.Drawing.Color.White;
            this.btnDone.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(80)))), ((int)(((byte)(180)))));
            this.btnDone.Location = new System.Drawing.Point(250, 440);
            this.btnDone.Name = "btnDone";
            this.btnDone.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(44)))), ((int)(((byte)(140)))));
            this.btnDone.Size = new System.Drawing.Size(120, 40);
            this.btnDone.TabIndex = 12;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = false;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);

            // MemberDetailsForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(500, 520);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MemberDetailsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Member Details";
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMemberPhoto)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.PictureBox picMemberPhoto;
        private System.Windows.Forms.Label lblFullNameLabel;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblEmailLabel;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhoneLabel;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblGenderLabel;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblFitnessGoalLabel;
        private System.Windows.Forms.Label lblFitnessGoal;
        private GymClassBooking.SpotMe.Controls.RoundedButton btnBackToList;
        private GymClassBooking.SpotMe.Controls.RoundedButton btnDone;
    }
}