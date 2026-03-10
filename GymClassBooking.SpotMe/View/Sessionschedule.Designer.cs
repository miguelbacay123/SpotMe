namespace GymClassBooking.SpotMe.View
{
    partial class Sessionschedule
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Controls.RoundedButton Home;
        private Controls.RoundedButton ClassBooking;
        private Controls.RoundedButton Trainers;
        private Controls.RoundedButton btnSessionSchedule;
        private Controls.RoundedButton More;
        private Controls.RoundedButton Members;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Label lblPageTitle;
        private System.Windows.Forms.Label lblPageSubtitle;
        private System.Windows.Forms.Panel panelSessionsContainer;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sessionschedule));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelContent = new System.Windows.Forms.Panel();
            this.lblPageTitle = new System.Windows.Forms.Label();
            this.lblPageSubtitle = new System.Windows.Forms.Label();
            this.panelSessionsContainer = new System.Windows.Forms.Panel();
            this.Home = new GymClassBooking.SpotMe.Controls.RoundedButton();
            this.ClassBooking = new GymClassBooking.SpotMe.Controls.RoundedButton();
            this.Trainers = new GymClassBooking.SpotMe.Controls.RoundedButton();
            this.btnSessionSchedule = new GymClassBooking.SpotMe.Controls.RoundedButton();
            this.More = new GymClassBooking.SpotMe.Controls.RoundedButton();
            this.Members = new GymClassBooking.SpotMe.Controls.RoundedButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Subheading", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(47, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 28);
            this.label1.TabIndex = 0;
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
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(893, 50);
            this.panel1.TabIndex = 25;
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.White;
            this.panelContent.Controls.Add(this.lblPageTitle);
            this.panelContent.Controls.Add(this.lblPageSubtitle);
            this.panelContent.Controls.Add(this.panelSessionsContainer);
            this.panelContent.Location = new System.Drawing.Point(12, 70);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(860, 480);
            this.panelContent.TabIndex = 32;
            // 
            // lblPageTitle
            // 
            this.lblPageTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblPageTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(44)))), ((int)(((byte)(140)))));
            this.lblPageTitle.Location = new System.Drawing.Point(15, 10);
            this.lblPageTitle.Name = "lblPageTitle";
            this.lblPageTitle.Size = new System.Drawing.Size(400, 30);
            this.lblPageTitle.TabIndex = 1;
            this.lblPageTitle.Text = "Member Sessions";
            // 
            // lblPageSubtitle
            // 
            this.lblPageSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPageSubtitle.ForeColor = System.Drawing.Color.Gray;
            this.lblPageSubtitle.Location = new System.Drawing.Point(15, 40);
            this.lblPageSubtitle.Name = "lblPageSubtitle";
            this.lblPageSubtitle.Size = new System.Drawing.Size(400, 20);
            this.lblPageSubtitle.TabIndex = 2;
            this.lblPageSubtitle.Text = "Session Valid For Manage Booking";
            // 
            // panelSessionsContainer
            // 
            this.panelSessionsContainer.AutoScroll = true;
            this.panelSessionsContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.panelSessionsContainer.Location = new System.Drawing.Point(0, 70);
            this.panelSessionsContainer.Name = "panelSessionsContainer";
            this.panelSessionsContainer.Size = new System.Drawing.Size(860, 410);
            this.panelSessionsContainer.TabIndex = 1;
            // 
            // Home
            // 
            this.Home.BackColor = System.Drawing.Color.White;
            this.Home.BorderRadius = 10;
            this.Home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Home.FlatAppearance.BorderSize = 0;
            this.Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Home.Font = new System.Drawing.Font("Sitka Heading", 11.25F, System.Drawing.FontStyle.Bold);
            this.Home.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Home.HoverColor = System.Drawing.Color.MediumPurple;
            this.Home.Location = new System.Drawing.Point(141, 12);
            this.Home.Name = "Home";
            this.Home.NormalColor = System.Drawing.Color.White;
            this.Home.Size = new System.Drawing.Size(85, 31);
            this.Home.TabIndex = 31;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = false;
            this.Home.Click += new System.EventHandler(this.roundedButton1_Click);
            // 
            // ClassBooking
            // 
            this.ClassBooking.BackColor = System.Drawing.Color.White;
            this.ClassBooking.BorderRadius = 10;
            this.ClassBooking.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClassBooking.FlatAppearance.BorderSize = 0;
            this.ClassBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClassBooking.Font = new System.Drawing.Font("Sitka Heading", 11.25F, System.Drawing.FontStyle.Bold);
            this.ClassBooking.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ClassBooking.HoverColor = System.Drawing.Color.MediumPurple;
            this.ClassBooking.Location = new System.Drawing.Point(467, 12);
            this.ClassBooking.Name = "ClassBooking";
            this.ClassBooking.NormalColor = System.Drawing.Color.White;
            this.ClassBooking.Size = new System.Drawing.Size(115, 30);
            this.ClassBooking.TabIndex = 30;
            this.ClassBooking.Text = "Class Booking";
            this.ClassBooking.UseVisualStyleBackColor = false;
            this.ClassBooking.Click += new System.EventHandler(this.roundedButton4_Click);
            // 
            // Trainers
            // 
            this.Trainers.BackColor = System.Drawing.Color.White;
            this.Trainers.BorderRadius = 10;
            this.Trainers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Trainers.FlatAppearance.BorderSize = 0;
            this.Trainers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Trainers.Font = new System.Drawing.Font("Sitka Heading", 11.25F, System.Drawing.FontStyle.Bold);
            this.Trainers.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Trainers.HoverColor = System.Drawing.Color.MediumPurple;
            this.Trainers.Location = new System.Drawing.Point(364, 12);
            this.Trainers.Name = "Trainers";
            this.Trainers.NormalColor = System.Drawing.Color.White;
            this.Trainers.Size = new System.Drawing.Size(85, 31);
            this.Trainers.TabIndex = 29;
            this.Trainers.Text = "Trainers";
            this.Trainers.UseVisualStyleBackColor = false;
            this.Trainers.Click += new System.EventHandler(this.roundedButton3_Click);
            // 
            // btnSessionSchedule
            // 
            this.btnSessionSchedule.BackColor = System.Drawing.Color.White;
            this.btnSessionSchedule.BorderRadius = 10;
            this.btnSessionSchedule.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSessionSchedule.FlatAppearance.BorderSize = 0;
            this.btnSessionSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSessionSchedule.Font = new System.Drawing.Font("Sitka Heading", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnSessionSchedule.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSessionSchedule.HoverColor = System.Drawing.Color.MediumPurple;
            this.btnSessionSchedule.Location = new System.Drawing.Point(598, 12);
            this.btnSessionSchedule.Name = "btnSessionSchedule";
            this.btnSessionSchedule.NormalColor = System.Drawing.Color.White;
            this.btnSessionSchedule.Size = new System.Drawing.Size(135, 30);
            this.btnSessionSchedule.TabIndex = 28;
            this.btnSessionSchedule.Text = "Session Schedule";
            this.btnSessionSchedule.UseVisualStyleBackColor = false;
            this.btnSessionSchedule.Click += new System.EventHandler(this.roundedButton5_Click);
            // 
            // More
            // 
            this.More.BackColor = System.Drawing.Color.White;
            this.More.BorderRadius = 10;
            this.More.Cursor = System.Windows.Forms.Cursors.Hand;
            this.More.FlatAppearance.BorderSize = 0;
            this.More.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.More.Font = new System.Drawing.Font("Sitka Heading", 11.25F, System.Drawing.FontStyle.Bold);
            this.More.ForeColor = System.Drawing.SystemColors.ControlText;
            this.More.HoverColor = System.Drawing.Color.MediumPurple;
            this.More.Location = new System.Drawing.Point(753, 12);
            this.More.Name = "More";
            this.More.NormalColor = System.Drawing.Color.White;
            this.More.Size = new System.Drawing.Size(85, 31);
            this.More.TabIndex = 27;
            this.More.Text = "More";
            this.More.UseVisualStyleBackColor = false;
            this.More.Click += new System.EventHandler(this.roundedButton6_Click);
            // 
            // Members
            // 
            this.Members.BackColor = System.Drawing.Color.White;
            this.Members.BorderRadius = 10;
            this.Members.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Members.FlatAppearance.BorderSize = 0;
            this.Members.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Members.Font = new System.Drawing.Font("Sitka Heading", 11.25F, System.Drawing.FontStyle.Bold);
            this.Members.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Members.HoverColor = System.Drawing.Color.MediumPurple;
            this.Members.Location = new System.Drawing.Point(252, 12);
            this.Members.Name = "Members";
            this.Members.NormalColor = System.Drawing.Color.White;
            this.Members.Size = new System.Drawing.Size(85, 31);
            this.Members.TabIndex = 26;
            this.Members.Text = "Members";
            this.Members.UseVisualStyleBackColor = false;
            this.Members.Click += new System.EventHandler(this.roundedButton2_Click);
            // 
            // Sessionschedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.ClassBooking);
            this.Controls.Add(this.Trainers);
            this.Controls.Add(this.btnSessionSchedule);
            this.Controls.Add(this.More);
            this.Controls.Add(this.Members);
            this.Controls.Add(this.panel1);
            this.Name = "Sessionschedule";
            this.Text = "Session Schedule";
            this.Load += new System.EventHandler(this.Sessionschedule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelContent.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}