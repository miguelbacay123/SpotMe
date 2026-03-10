namespace GymClassBooking.SpotMe.View
{
    partial class TrainerManagement
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrainerManagement));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelContent = new System.Windows.Forms.Panel();
            this.btnAddTrainer = new GymClassBooking.SpotMe.Controls.RoundedButton();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblHeaderPhoto = new System.Windows.Forms.Label();
            this.lblHeaderName = new System.Windows.Forms.Label();
            this.lblHeaderEmail = new System.Windows.Forms.Label();
            this.lblHeaderPhone = new System.Windows.Forms.Label();
            this.lblHeaderSpecialties = new System.Windows.Forms.Label();
            this.lblHeaderAction = new System.Windows.Forms.Label();
            this.panelRowsContainer = new System.Windows.Forms.Panel();
            this.roundedButton7 = new GymClassBooking.SpotMe.Controls.RoundedButton();
            this.roundedButton6 = new GymClassBooking.SpotMe.Controls.RoundedButton();
            this.roundedButton5 = new GymClassBooking.SpotMe.Controls.RoundedButton();
            this.roundedButton4 = new GymClassBooking.SpotMe.Controls.RoundedButton();
            this.roundedButton3 = new GymClassBooking.SpotMe.Controls.RoundedButton();
            this.roundedButton1 = new GymClassBooking.SpotMe.Controls.RoundedButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Subheading", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(47, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "SpotMe";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(893, 50);
            this.panel1.TabIndex = 25;
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.White;
            this.panelContent.Controls.Add(this.btnAddTrainer);
            this.panelContent.Controls.Add(this.panelHeader);
            this.panelContent.Controls.Add(this.panelRowsContainer);
            this.panelContent.Location = new System.Drawing.Point(12, 70);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(860, 480);
            this.panelContent.TabIndex = 32;
            // 
            // btnAddTrainer
            // 
            this.btnAddTrainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(44)))), ((int)(((byte)(140)))));
            this.btnAddTrainer.BorderRadius = 10;
            this.btnAddTrainer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddTrainer.FlatAppearance.BorderSize = 0;
            this.btnAddTrainer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTrainer.Font = new System.Drawing.Font("Sitka Heading", 11F, System.Drawing.FontStyle.Bold);
            this.btnAddTrainer.ForeColor = System.Drawing.Color.White;
            this.btnAddTrainer.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(80)))), ((int)(((byte)(180)))));
            this.btnAddTrainer.Location = new System.Drawing.Point(706, 19);
            this.btnAddTrainer.Name = "btnAddTrainer";
            this.btnAddTrainer.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(44)))), ((int)(((byte)(140)))));
            this.btnAddTrainer.Size = new System.Drawing.Size(120, 35);
            this.btnAddTrainer.TabIndex = 0;
            this.btnAddTrainer.Text = "+ Add Trainer";
            this.btnAddTrainer.UseVisualStyleBackColor = false;
            this.btnAddTrainer.Click += new System.EventHandler(this.btnAddTrainer_Click);
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.White;
            this.panelHeader.Controls.Add(this.lblHeaderPhoto);
            this.panelHeader.Controls.Add(this.lblHeaderName);
            this.panelHeader.Controls.Add(this.lblHeaderEmail);
            this.panelHeader.Controls.Add(this.lblHeaderPhone);
            this.panelHeader.Controls.Add(this.lblHeaderSpecialties);
            this.panelHeader.Controls.Add(this.lblHeaderAction);
            this.panelHeader.Location = new System.Drawing.Point(15, 60);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(830, 35);
            this.panelHeader.TabIndex = 1;
            // 
            // lblHeaderPhoto
            // 
            this.lblHeaderPhoto.AutoSize = true;
            this.lblHeaderPhoto.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblHeaderPhoto.ForeColor = System.Drawing.Color.Black;
            this.lblHeaderPhoto.Location = new System.Drawing.Point(25, 8);
            this.lblHeaderPhoto.Name = "lblHeaderPhoto";
            this.lblHeaderPhoto.Size = new System.Drawing.Size(49, 19);
            this.lblHeaderPhoto.TabIndex = 0;
            this.lblHeaderPhoto.Text = "Photo";
            // 
            // lblHeaderName
            // 
            this.lblHeaderName.AutoSize = true;
            this.lblHeaderName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblHeaderName.ForeColor = System.Drawing.Color.Black;
            this.lblHeaderName.Location = new System.Drawing.Point(132, 8);
            this.lblHeaderName.Name = "lblHeaderName";
            this.lblHeaderName.Size = new System.Drawing.Size(49, 19);
            this.lblHeaderName.TabIndex = 1;
            this.lblHeaderName.Text = "Name";
            // 
            // lblHeaderEmail
            // 
            this.lblHeaderEmail.AutoSize = true;
            this.lblHeaderEmail.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblHeaderEmail.ForeColor = System.Drawing.Color.Black;
            this.lblHeaderEmail.Location = new System.Drawing.Point(250, 8);
            this.lblHeaderEmail.Name = "lblHeaderEmail";
            this.lblHeaderEmail.Size = new System.Drawing.Size(45, 19);
            this.lblHeaderEmail.TabIndex = 2;
            this.lblHeaderEmail.Text = "Email";
            // 
            // lblHeaderPhone
            // 
            this.lblHeaderPhone.AutoSize = true;
            this.lblHeaderPhone.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblHeaderPhone.ForeColor = System.Drawing.Color.Black;
            this.lblHeaderPhone.Location = new System.Drawing.Point(425, 8);
            this.lblHeaderPhone.Name = "lblHeaderPhone";
            this.lblHeaderPhone.Size = new System.Drawing.Size(51, 19);
            this.lblHeaderPhone.TabIndex = 4;
            this.lblHeaderPhone.Text = "Phone";
            // 
            // lblHeaderSpecialties
            // 
            this.lblHeaderSpecialties.AutoSize = true;
            this.lblHeaderSpecialties.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblHeaderSpecialties.ForeColor = System.Drawing.Color.Black;
            this.lblHeaderSpecialties.Location = new System.Drawing.Point(555, 8);
            this.lblHeaderSpecialties.Name = "lblHeaderSpecialties";
            this.lblHeaderSpecialties.Size = new System.Drawing.Size(80, 19);
            this.lblHeaderSpecialties.TabIndex = 5;
            this.lblHeaderSpecialties.Text = "Specialties";
            // 
            // lblHeaderAction
            // 
            this.lblHeaderAction.AutoSize = true;
            this.lblHeaderAction.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblHeaderAction.ForeColor = System.Drawing.Color.Black;
            this.lblHeaderAction.Location = new System.Drawing.Point(735, 8);
            this.lblHeaderAction.Name = "lblHeaderAction";
            this.lblHeaderAction.Size = new System.Drawing.Size(52, 19);
            this.lblHeaderAction.TabIndex = 6;
            this.lblHeaderAction.Text = "Action";
            // 
            // panelRowsContainer
            // 
            this.panelRowsContainer.AutoScroll = true;
            this.panelRowsContainer.Location = new System.Drawing.Point(15, 100);
            this.panelRowsContainer.Name = "panelRowsContainer";
            this.panelRowsContainer.Size = new System.Drawing.Size(830, 350);
            this.panelRowsContainer.TabIndex = 2;
            // 
            // roundedButton7
            // 
            this.roundedButton7.BackColor = System.Drawing.Color.White;
            this.roundedButton7.BorderRadius = 10;
            this.roundedButton7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roundedButton7.FlatAppearance.BorderSize = 0;
            this.roundedButton7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton7.Font = new System.Drawing.Font("Sitka Heading", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedButton7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.roundedButton7.HoverColor = System.Drawing.Color.MediumPurple;
            this.roundedButton7.Location = new System.Drawing.Point(141, 12);
            this.roundedButton7.Name = "roundedButton7";
            this.roundedButton7.NormalColor = System.Drawing.Color.White;
            this.roundedButton7.Size = new System.Drawing.Size(85, 31);
            this.roundedButton7.TabIndex = 31;
            this.roundedButton7.Text = "Home";
            this.roundedButton7.UseVisualStyleBackColor = false;
            this.roundedButton7.Click += new System.EventHandler(this.roundedButton1_Click);
            // 
            // roundedButton6
            // 
            this.roundedButton6.BackColor = System.Drawing.Color.White;
            this.roundedButton6.BorderRadius = 10;
            this.roundedButton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roundedButton6.FlatAppearance.BorderSize = 0;
            this.roundedButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton6.Font = new System.Drawing.Font("Sitka Heading", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedButton6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.roundedButton6.HoverColor = System.Drawing.Color.MediumPurple;
            this.roundedButton6.Location = new System.Drawing.Point(467, 12);
            this.roundedButton6.Name = "roundedButton6";
            this.roundedButton6.NormalColor = System.Drawing.Color.White;
            this.roundedButton6.Size = new System.Drawing.Size(115, 30);
            this.roundedButton6.TabIndex = 30;
            this.roundedButton6.TabStop = false;
            this.roundedButton6.Text = "Class Booking";
            this.roundedButton6.UseVisualStyleBackColor = false;
            this.roundedButton6.Click += new System.EventHandler(this.roundedButton4_Click);
            // 
            // roundedButton5
            // 
            this.roundedButton5.BackColor = System.Drawing.Color.White;
            this.roundedButton5.BorderRadius = 10;
            this.roundedButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roundedButton5.FlatAppearance.BorderSize = 0;
            this.roundedButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton5.Font = new System.Drawing.Font("Sitka Heading", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedButton5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.roundedButton5.HoverColor = System.Drawing.Color.MediumPurple;
            this.roundedButton5.Location = new System.Drawing.Point(364, 12);
            this.roundedButton5.Name = "roundedButton5";
            this.roundedButton5.NormalColor = System.Drawing.Color.White;
            this.roundedButton5.Size = new System.Drawing.Size(85, 31);
            this.roundedButton5.TabIndex = 29;
            this.roundedButton5.TabStop = false;
            this.roundedButton5.Text = "Trainers";
            this.roundedButton5.UseVisualStyleBackColor = false;
            this.roundedButton5.Click += new System.EventHandler(this.roundedButton3_Click);
            // 
            // roundedButton4
            // 
            this.roundedButton4.BackColor = System.Drawing.Color.White;
            this.roundedButton4.BorderRadius = 10;
            this.roundedButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roundedButton4.FlatAppearance.BorderSize = 0;
            this.roundedButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton4.Font = new System.Drawing.Font("Sitka Heading", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedButton4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.roundedButton4.HoverColor = System.Drawing.Color.MediumPurple;
            this.roundedButton4.Location = new System.Drawing.Point(598, 12);
            this.roundedButton4.Name = "roundedButton4";
            this.roundedButton4.NormalColor = System.Drawing.Color.White;
            this.roundedButton4.Size = new System.Drawing.Size(135, 30);
            this.roundedButton4.TabIndex = 28;
            this.roundedButton4.TabStop = false;
            this.roundedButton4.Text = "Session Schedule";
            this.roundedButton4.UseVisualStyleBackColor = false;
            this.roundedButton4.Click += new System.EventHandler(this.roundedButton5_Click);
            // 
            // roundedButton3
            // 
            this.roundedButton3.BackColor = System.Drawing.Color.White;
            this.roundedButton3.BorderRadius = 10;
            this.roundedButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roundedButton3.FlatAppearance.BorderSize = 0;
            this.roundedButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton3.Font = new System.Drawing.Font("Sitka Heading", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedButton3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.roundedButton3.HoverColor = System.Drawing.Color.MediumPurple;
            this.roundedButton3.Location = new System.Drawing.Point(753, 12);
            this.roundedButton3.Name = "roundedButton3";
            this.roundedButton3.NormalColor = System.Drawing.Color.White;
            this.roundedButton3.Size = new System.Drawing.Size(85, 31);
            this.roundedButton3.TabIndex = 27;
            this.roundedButton3.TabStop = false;
            this.roundedButton3.Text = "More";
            this.roundedButton3.UseVisualStyleBackColor = false;
            this.roundedButton3.Click += new System.EventHandler(this.roundedButton6_Click);
            // 
            // roundedButton1
            // 
            this.roundedButton1.BackColor = System.Drawing.Color.White;
            this.roundedButton1.BorderRadius = 10;
            this.roundedButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roundedButton1.FlatAppearance.BorderSize = 0;
            this.roundedButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton1.Font = new System.Drawing.Font("Sitka Heading", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedButton1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.roundedButton1.HoverColor = System.Drawing.Color.MediumPurple;
            this.roundedButton1.Location = new System.Drawing.Point(252, 12);
            this.roundedButton1.Name = "roundedButton1";
            this.roundedButton1.NormalColor = System.Drawing.Color.White;
            this.roundedButton1.Size = new System.Drawing.Size(85, 31);
            this.roundedButton1.TabIndex = 26;
            this.roundedButton1.TabStop = false;
            this.roundedButton1.Text = "Members";
            this.roundedButton1.UseVisualStyleBackColor = false;
            this.roundedButton1.Click += new System.EventHandler(this.roundedButton2_Click);
            // 
            // TrainerManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.roundedButton7);
            this.Controls.Add(this.roundedButton6);
            this.Controls.Add(this.roundedButton5);
            this.Controls.Add(this.roundedButton4);
            this.Controls.Add(this.roundedButton3);
            this.Controls.Add(this.roundedButton1);
            this.Controls.Add(this.panel1);
            this.Name = "TrainerManagement";
            this.Text = "Trainer Management";
            this.Load += new System.EventHandler(this.TrainerManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelContent.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Controls.RoundedButton roundedButton7;
        private Controls.RoundedButton roundedButton6;
        private Controls.RoundedButton roundedButton5;
        private Controls.RoundedButton roundedButton4;
        private Controls.RoundedButton roundedButton3;
        private Controls.RoundedButton roundedButton1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelContent;
        private Controls.RoundedButton btnAddTrainer;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblHeaderPhoto;
        private System.Windows.Forms.Label lblHeaderName;
        private System.Windows.Forms.Label lblHeaderEmail;
        private System.Windows.Forms.Label lblHeaderPhone;
        private System.Windows.Forms.Label lblHeaderSpecialties;
        private System.Windows.Forms.Label lblHeaderAction;
        private System.Windows.Forms.Panel panelRowsContainer;
    }
}