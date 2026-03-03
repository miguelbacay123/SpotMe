namespace GymClassBooking.SpotMe
{
    partial class MainDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainDashboard));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dropdownButton1 = new GymClassBooking.SpotMe.Controls.DropdownButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelStats = new System.Windows.Forms.Panel();
            this.lblTotalMembersNum = new System.Windows.Forms.Label();
            this.lblActiveMembersNum = new System.Windows.Forms.Label();
            this.lblTrainersNum = new System.Windows.Forms.Label();
            this.lblUpcomingNum = new System.Windows.Forms.Label();
            this.lblOngoingNum = new System.Windows.Forms.Label();
            this.lblCompletedNum = new System.Windows.Forms.Label();
            this.lblTotalMembersText = new System.Windows.Forms.Label();
            this.lblActiveMembersText = new System.Windows.Forms.Label();
            this.lblTrainersText = new System.Windows.Forms.Label();
            this.lblUpcomingText = new System.Windows.Forms.Label();
            this.lblOngoingText = new System.Windows.Forms.Label();
            this.lblCompletedText = new System.Windows.Forms.Label();
            this.btnGetStarted = new GymClassBooking.SpotMe.Controls.RoundedButton();
            this.btnExploreMore = new GymClassBooking.SpotMe.Controls.RoundedButton();
            this.Donations = new System.Windows.Forms.ToolStripMenuItem();
            this.Partnerships = new System.Windows.Forms.ToolStripMenuItem();
            this.ManageStaff = new System.Windows.Forms.ToolStripMenuItem();
            this.Logout = new System.Windows.Forms.ToolStripMenuItem();
            this.Home = new GymClassBooking.SpotMe.Controls.RoundedButton();
            this.ClassBooking = new GymClassBooking.SpotMe.Controls.RoundedButton();
            this.Trainers = new GymClassBooking.SpotMe.Controls.RoundedButton();
            this.SessionSchedule = new GymClassBooking.SpotMe.Controls.RoundedButton();
            this.Members = new GymClassBooking.SpotMe.Controls.RoundedButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelStats.SuspendLayout();
            this.SuspendLayout();
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
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Subheading", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(48, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "SpotMe";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.dropdownButton1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(894, 50);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dropdownButton1
            // 
            this.dropdownButton1.BackColor = System.Drawing.Color.White;
            this.dropdownButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.dropdownButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dropdownButton1.FlatAppearance.BorderSize = 0;
            this.dropdownButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dropdownButton1.Font = new System.Drawing.Font("Sitka Heading", 11.25F, System.Drawing.FontStyle.Bold);
            this.dropdownButton1.Location = new System.Drawing.Point(767, 12);
            this.dropdownButton1.Name = "dropdownButton1";
            this.dropdownButton1.Size = new System.Drawing.Size(85, 31);
            this.dropdownButton1.TabIndex = 1;
            this.dropdownButton1.Text = "More";
            this.dropdownButton1.UseVisualStyleBackColor = false;
            this.dropdownButton1.Click += new System.EventHandler(this.dropdownButton1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Sitka Heading", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.MediumPurple;
            this.textBox1.Location = new System.Drawing.Point(12, 105);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(257, 52);
            this.textBox1.TabIndex = 19;
            this.textBox1.Text = "CAN STAND";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox2.Font = new System.Drawing.Font("Sitka Heading", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.Black;
            this.textBox2.Location = new System.Drawing.Point(7, 60);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(257, 50);
            this.textBox2.TabIndex = 20;
            this.textBox2.Text = "YOUR BODY";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.White;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Sitka Heading", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.Black;
            this.textBox3.Location = new System.Drawing.Point(12, 150);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(257, 50);
            this.textBox3.TabIndex = 21;
            this.textBox3.Text = "ALMOST";
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.White;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Sitka Heading", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.Color.MediumPurple;
            this.textBox4.Location = new System.Drawing.Point(7, 195);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(257, 54);
            this.textBox4.TabIndex = 22;
            this.textBox4.Text = "ANYTHING";
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.White;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Sitka Small", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.richTextBox1.Location = new System.Drawing.Point(17, 255);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox1.Size = new System.Drawing.Size(440, 74);
            this.richTextBox1.TabIndex = 23;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged_1);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(463, 56);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(417, 502);
            this.panel2.TabIndex = 24;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(417, 502);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // panelStats
            // 
            this.panelStats.BackColor = System.Drawing.Color.Transparent;
            this.panelStats.Controls.Add(this.lblTotalMembersNum);
            this.panelStats.Controls.Add(this.lblActiveMembersNum);
            this.panelStats.Controls.Add(this.lblTrainersNum);
            this.panelStats.Controls.Add(this.lblUpcomingNum);
            this.panelStats.Controls.Add(this.lblOngoingNum);
            this.panelStats.Controls.Add(this.lblCompletedNum);
            this.panelStats.Controls.Add(this.lblTotalMembersText);
            this.panelStats.Controls.Add(this.lblActiveMembersText);
            this.panelStats.Controls.Add(this.lblTrainersText);
            this.panelStats.Controls.Add(this.lblUpcomingText);
            this.panelStats.Controls.Add(this.lblOngoingText);
            this.panelStats.Controls.Add(this.lblCompletedText);
            this.panelStats.Controls.Add(this.btnGetStarted);
            this.panelStats.Controls.Add(this.btnExploreMore);
            this.panelStats.Location = new System.Drawing.Point(12, 318);
            this.panelStats.Name = "panelStats";
            this.panelStats.Size = new System.Drawing.Size(406, 200);
            this.panelStats.TabIndex = 25;
            // 
            // lblTotalMembersNum
            // 
            this.lblTotalMembersNum.AutoSize = true;
            this.lblTotalMembersNum.Font = new System.Drawing.Font("Sitka Heading", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalMembersNum.ForeColor = System.Drawing.Color.Black;
            this.lblTotalMembersNum.Location = new System.Drawing.Point(49, 14);
            this.lblTotalMembersNum.Name = "lblTotalMembersNum";
            this.lblTotalMembersNum.Size = new System.Drawing.Size(33, 39);
            this.lblTotalMembersNum.TabIndex = 0;
            this.lblTotalMembersNum.Text = "0";
            this.lblTotalMembersNum.Click += new System.EventHandler(this.lblTotalMembersNum_Click);
            // 
            // lblActiveMembersNum
            // 
            this.lblActiveMembersNum.AutoSize = true;
            this.lblActiveMembersNum.Font = new System.Drawing.Font("Sitka Heading", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActiveMembersNum.ForeColor = System.Drawing.Color.Black;
            this.lblActiveMembersNum.Location = new System.Drawing.Point(189, 14);
            this.lblActiveMembersNum.Name = "lblActiveMembersNum";
            this.lblActiveMembersNum.Size = new System.Drawing.Size(33, 39);
            this.lblActiveMembersNum.TabIndex = 1;
            this.lblActiveMembersNum.Text = "0";
            // 
            // lblTrainersNum
            // 
            this.lblTrainersNum.AutoSize = true;
            this.lblTrainersNum.Font = new System.Drawing.Font("Sitka Heading", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrainersNum.ForeColor = System.Drawing.Color.Black;
            this.lblTrainersNum.Location = new System.Drawing.Point(326, 14);
            this.lblTrainersNum.Name = "lblTrainersNum";
            this.lblTrainersNum.Size = new System.Drawing.Size(33, 39);
            this.lblTrainersNum.TabIndex = 2;
            this.lblTrainersNum.Text = "0";
            // 
            // lblUpcomingNum
            // 
            this.lblUpcomingNum.AutoSize = true;
            this.lblUpcomingNum.Font = new System.Drawing.Font("Sitka Heading", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpcomingNum.ForeColor = System.Drawing.Color.Black;
            this.lblUpcomingNum.Location = new System.Drawing.Point(49, 76);
            this.lblUpcomingNum.Name = "lblUpcomingNum";
            this.lblUpcomingNum.Size = new System.Drawing.Size(33, 39);
            this.lblUpcomingNum.TabIndex = 3;
            this.lblUpcomingNum.Text = "0";
            // 
            // lblOngoingNum
            // 
            this.lblOngoingNum.AutoSize = true;
            this.lblOngoingNum.Font = new System.Drawing.Font("Sitka Heading", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOngoingNum.ForeColor = System.Drawing.Color.Black;
            this.lblOngoingNum.Location = new System.Drawing.Point(189, 76);
            this.lblOngoingNum.Name = "lblOngoingNum";
            this.lblOngoingNum.Size = new System.Drawing.Size(33, 39);
            this.lblOngoingNum.TabIndex = 4;
            this.lblOngoingNum.Text = "0";
            // 
            // lblCompletedNum
            // 
            this.lblCompletedNum.AutoSize = true;
            this.lblCompletedNum.Font = new System.Drawing.Font("Sitka Heading", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompletedNum.ForeColor = System.Drawing.Color.Black;
            this.lblCompletedNum.Location = new System.Drawing.Point(326, 76);
            this.lblCompletedNum.Name = "lblCompletedNum";
            this.lblCompletedNum.Size = new System.Drawing.Size(33, 39);
            this.lblCompletedNum.TabIndex = 5;
            this.lblCompletedNum.Text = "0";
            // 
            // lblTotalMembersText
            // 
            this.lblTotalMembersText.AutoSize = true;
            this.lblTotalMembersText.Font = new System.Drawing.Font("Sitka Small", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalMembersText.ForeColor = System.Drawing.Color.DimGray;
            this.lblTotalMembersText.Location = new System.Drawing.Point(14, 60);
            this.lblTotalMembersText.Name = "lblTotalMembersText";
            this.lblTotalMembersText.Size = new System.Drawing.Size(104, 16);
            this.lblTotalMembersText.TabIndex = 6;
            this.lblTotalMembersText.Text = "TOTAL MEMBERS";
            // 
            // lblActiveMembersText
            // 
            this.lblActiveMembersText.AutoSize = true;
            this.lblActiveMembersText.Font = new System.Drawing.Font("Sitka Small", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActiveMembersText.ForeColor = System.Drawing.Color.DimGray;
            this.lblActiveMembersText.Location = new System.Drawing.Point(155, 60);
            this.lblActiveMembersText.Name = "lblActiveMembersText";
            this.lblActiveMembersText.Size = new System.Drawing.Size(109, 16);
            this.lblActiveMembersText.TabIndex = 7;
            this.lblActiveMembersText.Text = "ACTIVE MEMBERS";
            // 
            // lblTrainersText
            // 
            this.lblTrainersText.AutoSize = true;
            this.lblTrainersText.Font = new System.Drawing.Font("Sitka Small", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrainersText.ForeColor = System.Drawing.Color.DimGray;
            this.lblTrainersText.Location = new System.Drawing.Point(314, 60);
            this.lblTrainersText.Name = "lblTrainersText";
            this.lblTrainersText.Size = new System.Drawing.Size(65, 16);
            this.lblTrainersText.TabIndex = 8;
            this.lblTrainersText.Text = "TRAINERS";
            // 
            // lblUpcomingText
            // 
            this.lblUpcomingText.AutoSize = true;
            this.lblUpcomingText.Font = new System.Drawing.Font("Sitka Small", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpcomingText.ForeColor = System.Drawing.Color.DimGray;
            this.lblUpcomingText.Location = new System.Drawing.Point(29, 121);
            this.lblUpcomingText.Name = "lblUpcomingText";
            this.lblUpcomingText.Size = new System.Drawing.Size(70, 16);
            this.lblUpcomingText.TabIndex = 9;
            this.lblUpcomingText.Text = "UPCOMING";
            // 
            // lblOngoingText
            // 
            this.lblOngoingText.AutoSize = true;
            this.lblOngoingText.Font = new System.Drawing.Font("Sitka Small", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOngoingText.ForeColor = System.Drawing.Color.DimGray;
            this.lblOngoingText.Location = new System.Drawing.Point(175, 121);
            this.lblOngoingText.Name = "lblOngoingText";
            this.lblOngoingText.Size = new System.Drawing.Size(61, 16);
            this.lblOngoingText.TabIndex = 10;
            this.lblOngoingText.Text = "ONGOING";
            // 
            // lblCompletedText
            // 
            this.lblCompletedText.AutoSize = true;
            this.lblCompletedText.Font = new System.Drawing.Font("Sitka Small", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompletedText.ForeColor = System.Drawing.Color.DimGray;
            this.lblCompletedText.Location = new System.Drawing.Point(304, 121);
            this.lblCompletedText.Name = "lblCompletedText";
            this.lblCompletedText.Size = new System.Drawing.Size(76, 16);
            this.lblCompletedText.TabIndex = 11;
            this.lblCompletedText.Text = "COMPLETED";
            // 
            // btnGetStarted
            // 
            this.btnGetStarted.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(44)))), ((int)(((byte)(140)))));
            this.btnGetStarted.BorderRadius = 10;
            this.btnGetStarted.FlatAppearance.BorderSize = 0;
            this.btnGetStarted.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetStarted.Font = new System.Drawing.Font("Sitka Heading", 11F, System.Drawing.FontStyle.Bold);
            this.btnGetStarted.ForeColor = System.Drawing.Color.White;
            this.btnGetStarted.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(80)))), ((int)(((byte)(180)))));
            this.btnGetStarted.Location = new System.Drawing.Point(17, 150);
            this.btnGetStarted.Name = "btnGetStarted";
            this.btnGetStarted.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(44)))), ((int)(((byte)(140)))));
            this.btnGetStarted.Size = new System.Drawing.Size(120, 35);
            this.btnGetStarted.TabIndex = 12;
            this.btnGetStarted.Text = "Get Started";
            this.btnGetStarted.UseVisualStyleBackColor = false;
            this.btnGetStarted.Click += new System.EventHandler(this.btnGetStarted_Click);
            // 
            // btnExploreMore
            // 
            this.btnExploreMore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(44)))), ((int)(((byte)(140)))));
            this.btnExploreMore.BorderRadius = 15;
            this.btnExploreMore.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(44)))), ((int)(((byte)(140)))));
            this.btnExploreMore.FlatAppearance.BorderSize = 2;
            this.btnExploreMore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExploreMore.Font = new System.Drawing.Font("Sitka Heading", 11F, System.Drawing.FontStyle.Bold);
            this.btnExploreMore.ForeColor = System.Drawing.Color.White;
            this.btnExploreMore.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(80)))), ((int)(((byte)(180)))));
            this.btnExploreMore.Location = new System.Drawing.Point(158, 150);
            this.btnExploreMore.Name = "btnExploreMore";
            this.btnExploreMore.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(44)))), ((int)(((byte)(140)))));
            this.btnExploreMore.Size = new System.Drawing.Size(120, 35);
            this.btnExploreMore.TabIndex = 13;
            this.btnExploreMore.Text = "Explore More";
            this.btnExploreMore.UseVisualStyleBackColor = false;
            this.btnExploreMore.Click += new System.EventHandler(this.btnExploreMore_Click);
            // 
            // Donations
            // 
            this.Donations.Name = "Donations";
            this.Donations.Size = new System.Drawing.Size(144, 22);
            this.Donations.Text = "Donations";
            // 
            // Partnerships
            // 
            this.Partnerships.Name = "Partnerships";
            this.Partnerships.Size = new System.Drawing.Size(144, 22);
            this.Partnerships.Text = "Partnerships";
            // 
            // ManageStaff
            // 
            this.ManageStaff.Name = "ManageStaff";
            this.ManageStaff.Size = new System.Drawing.Size(144, 22);
            this.ManageStaff.Text = "Manage Staff";
            // 
            // Logout
            // 
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(144, 22);
            this.Logout.Text = "Logout";
            // 
            // Home
            // 
            this.Home.BackColor = System.Drawing.Color.White;
            this.Home.BorderRadius = 10;
            this.Home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Home.FlatAppearance.BorderSize = 0;
            this.Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Home.Font = new System.Drawing.Font("Sitka Heading", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Home.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Home.HoverColor = System.Drawing.Color.MediumPurple;
            this.Home.Location = new System.Drawing.Point(149, 11);
            this.Home.Name = "Home";
            this.Home.NormalColor = System.Drawing.Color.White;
            this.Home.Size = new System.Drawing.Size(85, 31);
            this.Home.TabIndex = 15;
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
            this.ClassBooking.Font = new System.Drawing.Font("Sitka Heading", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClassBooking.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ClassBooking.HoverColor = System.Drawing.Color.MediumPurple;
            this.ClassBooking.Location = new System.Drawing.Point(475, 11);
            this.ClassBooking.Name = "ClassBooking";
            this.ClassBooking.NormalColor = System.Drawing.Color.White;
            this.ClassBooking.Size = new System.Drawing.Size(115, 30);
            this.ClassBooking.TabIndex = 12;
            this.ClassBooking.TabStop = false;
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
            this.Trainers.Font = new System.Drawing.Font("Sitka Heading", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Trainers.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Trainers.HoverColor = System.Drawing.Color.MediumPurple;
            this.Trainers.Location = new System.Drawing.Point(372, 11);
            this.Trainers.Name = "Trainers";
            this.Trainers.NormalColor = System.Drawing.Color.White;
            this.Trainers.Size = new System.Drawing.Size(85, 31);
            this.Trainers.TabIndex = 11;
            this.Trainers.TabStop = false;
            this.Trainers.Text = "Trainers";
            this.Trainers.UseVisualStyleBackColor = false;
            this.Trainers.Click += new System.EventHandler(this.roundedButton3_Click);
            // 
            // SessionSchedule
            // 
            this.SessionSchedule.BackColor = System.Drawing.Color.White;
            this.SessionSchedule.BorderRadius = 10;
            this.SessionSchedule.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SessionSchedule.FlatAppearance.BorderSize = 0;
            this.SessionSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SessionSchedule.Font = new System.Drawing.Font("Sitka Heading", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SessionSchedule.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SessionSchedule.HoverColor = System.Drawing.Color.MediumPurple;
            this.SessionSchedule.Location = new System.Drawing.Point(606, 11);
            this.SessionSchedule.Name = "SessionSchedule";
            this.SessionSchedule.NormalColor = System.Drawing.Color.White;
            this.SessionSchedule.Size = new System.Drawing.Size(135, 30);
            this.SessionSchedule.TabIndex = 10;
            this.SessionSchedule.TabStop = false;
            this.SessionSchedule.Text = "Session Schedule";
            this.SessionSchedule.UseVisualStyleBackColor = false;
            this.SessionSchedule.Click += new System.EventHandler(this.roundedButton5_Click);
            // 
            // Members
            // 
            this.Members.BackColor = System.Drawing.Color.White;
            this.Members.BorderRadius = 10;
            this.Members.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Members.FlatAppearance.BorderSize = 0;
            this.Members.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Members.Font = new System.Drawing.Font("Sitka Heading", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Members.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Members.HoverColor = System.Drawing.Color.MediumPurple;
            this.Members.Location = new System.Drawing.Point(260, 11);
            this.Members.Name = "Members";
            this.Members.NormalColor = System.Drawing.Color.White;
            this.Members.Size = new System.Drawing.Size(85, 31);
            this.Members.TabIndex = 8;
            this.Members.TabStop = false;
            this.Members.Text = "Members";
            this.Members.UseVisualStyleBackColor = false;
            this.Members.Click += new System.EventHandler(this.roundedButton2_Click);
            // 
            // MainDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.panelStats);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.ClassBooking);
            this.Controls.Add(this.Trainers);
            this.Controls.Add(this.SessionSchedule);
            this.Controls.Add(this.Members);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainDashboard";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelStats.ResumeLayout(false);
            this.panelStats.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private Controls.RoundedButton Members;
        private Controls.RoundedButton SessionSchedule;
        private Controls.RoundedButton Trainers;
        private Controls.RoundedButton ClassBooking;
        private Controls.RoundedButton Home;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;

        // NEW CONTROLS
        private System.Windows.Forms.Panel panelStats;
        private System.Windows.Forms.Label lblTotalMembersNum;
        private System.Windows.Forms.Label lblActiveMembersNum;
        private System.Windows.Forms.Label lblTrainersNum;
        private System.Windows.Forms.Label lblUpcomingNum;
        private System.Windows.Forms.Label lblOngoingNum;
        private System.Windows.Forms.Label lblCompletedNum;
        private System.Windows.Forms.Label lblTotalMembersText;
        private System.Windows.Forms.Label lblActiveMembersText;
        private System.Windows.Forms.Label lblTrainersText;
        private System.Windows.Forms.Label lblUpcomingText;
        private System.Windows.Forms.Label lblOngoingText;
        private System.Windows.Forms.Label lblCompletedText;
        private Controls.RoundedButton btnGetStarted;
        private Controls.RoundedButton btnExploreMore;
        private Controls.DropdownButton dropdownButton1;
        private System.Windows.Forms.ToolStripMenuItem Donations;
        private System.Windows.Forms.ToolStripMenuItem Partnerships;
        private System.Windows.Forms.ToolStripMenuItem ManageStaff;
        private System.Windows.Forms.ToolStripMenuItem Logout;
    }
}