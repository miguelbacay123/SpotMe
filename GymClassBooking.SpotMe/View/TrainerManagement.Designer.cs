namespace GymClassBooking.SpotMe
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
            this.Home = new GymClassBooking.SpotMe.Controls.RoundedButton();
            this.ClassBooking = new GymClassBooking.SpotMe.Controls.RoundedButton();
            this.Trainers = new GymClassBooking.SpotMe.Controls.RoundedButton();
            this.SessionSchedule = new GymClassBooking.SpotMe.Controls.RoundedButton();
            this.More = new GymClassBooking.SpotMe.Controls.RoundedButton();
            this.Members = new GymClassBooking.SpotMe.Controls.RoundedButton();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
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
            // Home
            // 
            this.Home.BackColor = System.Drawing.Color.White;
            this.Home.BorderRadius = 10;
            this.Home.FlatAppearance.BorderSize = 0;
            this.Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Home.Font = new System.Drawing.Font("Sitka Heading", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.ClassBooking.FlatAppearance.BorderSize = 0;
            this.ClassBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClassBooking.Font = new System.Drawing.Font("Sitka Heading", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClassBooking.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ClassBooking.HoverColor = System.Drawing.Color.MediumPurple;
            this.ClassBooking.Location = new System.Drawing.Point(467, 12);
            this.ClassBooking.Name = "ClassBooking";
            this.ClassBooking.NormalColor = System.Drawing.Color.White;
            this.ClassBooking.Size = new System.Drawing.Size(115, 30);
            this.ClassBooking.TabIndex = 30;
            this.ClassBooking.TabStop = false;
            this.ClassBooking.Text = "Class Booking";
            this.ClassBooking.UseVisualStyleBackColor = false;
            this.ClassBooking.Click += new System.EventHandler(this.roundedButton4_Click);
            // 
            // Trainers
            // 
            this.Trainers.BackColor = System.Drawing.Color.White;
            this.Trainers.BorderRadius = 10;
            this.Trainers.FlatAppearance.BorderSize = 0;
            this.Trainers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Trainers.Font = new System.Drawing.Font("Sitka Heading", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Trainers.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Trainers.HoverColor = System.Drawing.Color.MediumPurple;
            this.Trainers.Location = new System.Drawing.Point(364, 12);
            this.Trainers.Name = "Trainers";
            this.Trainers.NormalColor = System.Drawing.Color.White;
            this.Trainers.Size = new System.Drawing.Size(85, 31);
            this.Trainers.TabIndex = 29;
            this.Trainers.TabStop = false;
            this.Trainers.Text = "Trainers";
            this.Trainers.UseVisualStyleBackColor = false;
            this.Trainers.Click += new System.EventHandler(this.roundedButton3_Click);
            // 
            // SessionSchedule
            // 
            this.SessionSchedule.BackColor = System.Drawing.Color.White;
            this.SessionSchedule.BorderRadius = 10;
            this.SessionSchedule.FlatAppearance.BorderSize = 0;
            this.SessionSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SessionSchedule.Font = new System.Drawing.Font("Sitka Heading", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SessionSchedule.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SessionSchedule.HoverColor = System.Drawing.Color.MediumPurple;
            this.SessionSchedule.Location = new System.Drawing.Point(598, 12);
            this.SessionSchedule.Name = "SessionSchedule";
            this.SessionSchedule.NormalColor = System.Drawing.Color.White;
            this.SessionSchedule.Size = new System.Drawing.Size(135, 30);
            this.SessionSchedule.TabIndex = 28;
            this.SessionSchedule.TabStop = false;
            this.SessionSchedule.Text = "Session Schedule";
            this.SessionSchedule.UseVisualStyleBackColor = false;
            this.SessionSchedule.Click += new System.EventHandler(this.roundedButton5_Click);
            // 
            // More
            // 
            this.More.BackColor = System.Drawing.Color.White;
            this.More.BorderRadius = 10;
            this.More.Cursor = System.Windows.Forms.Cursors.Hand;
            this.More.FlatAppearance.BorderSize = 0;
            this.More.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.More.Font = new System.Drawing.Font("Sitka Heading", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.More.ForeColor = System.Drawing.SystemColors.ControlText;
            this.More.HoverColor = System.Drawing.Color.MediumPurple;
            this.More.Location = new System.Drawing.Point(753, 12);
            this.More.Name = "More";
            this.More.NormalColor = System.Drawing.Color.White;
            this.More.Size = new System.Drawing.Size(85, 31);
            this.More.TabIndex = 27;
            this.More.TabStop = false;
            this.More.Text = "More";
            this.More.UseVisualStyleBackColor = false;
            this.More.Click += new System.EventHandler(this.roundedButton6_Click);
            // 
            // Members
            // 
            this.Members.BackColor = System.Drawing.Color.White;
            this.Members.BorderRadius = 10;
            this.Members.FlatAppearance.BorderSize = 0;
            this.Members.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Members.Font = new System.Drawing.Font("Sitka Heading", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Members.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Members.HoverColor = System.Drawing.Color.MediumPurple;
            this.Members.Location = new System.Drawing.Point(252, 12);
            this.Members.Name = "Members";
            this.Members.NormalColor = System.Drawing.Color.White;
            this.Members.Size = new System.Drawing.Size(85, 31);
            this.Members.TabIndex = 26;
            this.Members.TabStop = false;
            this.Members.Text = "Members";
            this.Members.UseVisualStyleBackColor = false;
            this.Members.Click += new System.EventHandler(this.roundedButton2_Click);
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
            // TrainerManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.ClassBooking);
            this.Controls.Add(this.Trainers);
            this.Controls.Add(this.SessionSchedule);
            this.Controls.Add(this.More);
            this.Controls.Add(this.Members);
            this.Controls.Add(this.panel1);
            this.Name = "TrainerManagement";
            this.Text = "Trainer Management";
            this.Load += new System.EventHandler(this.TrainerManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Controls.RoundedButton Home;
        private Controls.RoundedButton ClassBooking;
        private Controls.RoundedButton Trainers;
        private Controls.RoundedButton SessionSchedule;
        private Controls.RoundedButton More;
        private Controls.RoundedButton Members;
        private System.Windows.Forms.Panel panel1;
    }
}