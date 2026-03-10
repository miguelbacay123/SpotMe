namespace GymClassBooking.SpotMe
{
    partial class MainDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainDashboard));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
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
            this.panelActivityLogs = new System.Windows.Forms.Panel();
            this.panelActivityChart = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Home = new GymClassBooking.SpotMe.Controls.RoundedButton();
            this.ClassBooking = new GymClassBooking.SpotMe.Controls.RoundedButton();
            this.Trainers = new GymClassBooking.SpotMe.Controls.RoundedButton();
            this.SessionSchedule = new GymClassBooking.SpotMe.Controls.RoundedButton();
            this.Members = new GymClassBooking.SpotMe.Controls.RoundedButton();
            this.More = new GymClassBooking.SpotMe.Controls.RoundedButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelStats.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();

            // pictureBox1
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);

            // label1
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Subheading", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(44)))), ((int)(((byte)(140)))));
            this.label1.Location = new System.Drawing.Point(51, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "SpotMe";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Click += new System.EventHandler(this.label1_Click_1);

            // panel1
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(901, 50);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);

            // textBox1
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Sitka Heading", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(44)))), ((int)(((byte)(140)))));
            this.textBox1.Location = new System.Drawing.Point(30, 105);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(257, 52);
            this.textBox1.TabIndex = 19;
            this.textBox1.Text = "CAN STAND";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);

            // textBox2
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox2.Font = new System.Drawing.Font("Sitka Heading", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.textBox2.Location = new System.Drawing.Point(25, 60);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(257, 50);
            this.textBox2.TabIndex = 20;
            this.textBox2.Text = "YOUR BODY";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);

            // textBox3
            this.textBox3.BackColor = System.Drawing.Color.White;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Sitka Heading", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.textBox3.Location = new System.Drawing.Point(30, 150);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(257, 50);
            this.textBox3.TabIndex = 21;
            this.textBox3.Text = "ALMOST";
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);

            // textBox4
            this.textBox4.BackColor = System.Drawing.Color.White;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Sitka Heading", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(44)))), ((int)(((byte)(140)))));
            this.textBox4.Location = new System.Drawing.Point(24, 195);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(257, 54);
            this.textBox4.TabIndex = 22;
            this.textBox4.Text = "ANYTHING";
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);

            // richTextBox1
            this.richTextBox1.BackColor = System.Drawing.Color.White;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Sitka Small", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.richTextBox1.Location = new System.Drawing.Point(35, 255);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox1.Size = new System.Drawing.Size(440, 74);
            this.richTextBox1.TabIndex = 23;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged_1);

            // panelStats
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
            this.panelStats.Location = new System.Drawing.Point(30, 310);
            this.panelStats.Name = "panelStats";
            this.panelStats.Size = new System.Drawing.Size(445, 200);
            this.panelStats.TabIndex = 25;

            // lblTotalMembersNum
            this.lblTotalMembersNum.AutoSize = true;
            this.lblTotalMembersNum.Font = new System.Drawing.Font("Sitka Heading", 20F, System.Drawing.FontStyle.Bold);
            this.lblTotalMembersNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(44)))), ((int)(((byte)(140)))));
            this.lblTotalMembersNum.Location = new System.Drawing.Point(34, 10);
            this.lblTotalMembersNum.Name = "lblTotalMembersNum";
            this.lblTotalMembersNum.Size = new System.Drawing.Size(33, 39);
            this.lblTotalMembersNum.TabIndex = 0;
            this.lblTotalMembersNum.Text = "0";
            this.lblTotalMembersNum.Click += new System.EventHandler(this.lblTotalMembersNum_Click);

            // lblActiveMembersNum
            this.lblActiveMembersNum.AutoSize = true;
            this.lblActiveMembersNum.Font = new System.Drawing.Font("Sitka Heading", 20F, System.Drawing.FontStyle.Bold);
            this.lblActiveMembersNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(44)))), ((int)(((byte)(140)))));
            this.lblActiveMembersNum.Location = new System.Drawing.Point(162, 10);
            this.lblActiveMembersNum.Name = "lblActiveMembersNum";
            this.lblActiveMembersNum.Size = new System.Drawing.Size(33, 39);
            this.lblActiveMembersNum.TabIndex = 1;
            this.lblActiveMembersNum.Text = "0";
            this.lblActiveMembersNum.Click += new System.EventHandler(this.lblActiveMembersNum_Click);

            // lblTrainersNum
            this.lblTrainersNum.AutoSize = true;
            this.lblTrainersNum.Font = new System.Drawing.Font("Sitka Heading", 20F, System.Drawing.FontStyle.Bold);
            this.lblTrainersNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(44)))), ((int)(((byte)(140)))));
            this.lblTrainersNum.Location = new System.Drawing.Point(278, 10);
            this.lblTrainersNum.Name = "lblTrainersNum";
            this.lblTrainersNum.Size = new System.Drawing.Size(28, 39);
            this.lblTrainersNum.TabIndex = 2;
            this.lblTrainersNum.Text = "1";
            this.lblTrainersNum.Click += new System.EventHandler(this.lblTrainersNum_Click);

            // lblUpcomingNum
            this.lblUpcomingNum.AutoSize = true;
            this.lblUpcomingNum.Font = new System.Drawing.Font("Sitka Heading", 20F, System.Drawing.FontStyle.Bold);
            this.lblUpcomingNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(44)))), ((int)(((byte)(140)))));
            this.lblUpcomingNum.Location = new System.Drawing.Point(34, 70);
            this.lblUpcomingNum.Name = "lblUpcomingNum";
            this.lblUpcomingNum.Size = new System.Drawing.Size(33, 39);
            this.lblUpcomingNum.TabIndex = 3;
            this.lblUpcomingNum.Text = "0";
            this.lblUpcomingNum.Click += new System.EventHandler(this.lblUpcomingNum_Click);

            // lblOngoingNum
            this.lblOngoingNum.AutoSize = true;
            this.lblOngoingNum.Font = new System.Drawing.Font("Sitka Heading", 20F, System.Drawing.FontStyle.Bold);
            this.lblOngoingNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(44)))), ((int)(((byte)(140)))));
            this.lblOngoingNum.Location = new System.Drawing.Point(162, 70);
            this.lblOngoingNum.Name = "lblOngoingNum";
            this.lblOngoingNum.Size = new System.Drawing.Size(33, 39);
            this.lblOngoingNum.TabIndex = 4;
            this.lblOngoingNum.Text = "0";

            // lblCompletedNum
            this.lblCompletedNum.AutoSize = true;
            this.lblCompletedNum.Font = new System.Drawing.Font("Sitka Heading", 20F, System.Drawing.FontStyle.Bold);
            this.lblCompletedNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(44)))), ((int)(((byte)(140)))));
            this.lblCompletedNum.Location = new System.Drawing.Point(276, 70);
            this.lblCompletedNum.Name = "lblCompletedNum";
            this.lblCompletedNum.Size = new System.Drawing.Size(33, 39);
            this.lblCompletedNum.TabIndex = 5;
            this.lblCompletedNum.Text = "0";

            // lblTotalMembersText
            this.lblTotalMembersText.AutoSize = true;
            this.lblTotalMembersText.Font = new System.Drawing.Font("Sitka Small", 8F);
            this.lblTotalMembersText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.lblTotalMembersText.Location = new System.Drawing.Point(3, 49);
            this.lblTotalMembersText.Name = "lblTotalMembersText";
            this.lblTotalMembersText.Size = new System.Drawing.Size(104, 16);
            this.lblTotalMembersText.TabIndex = 6;
            this.lblTotalMembersText.Text = "TOTAL MEMBERS";

            // lblActiveMembersText
            this.lblActiveMembersText.AutoSize = true;
            this.lblActiveMembersText.Font = new System.Drawing.Font("Sitka Small", 8F);
            this.lblActiveMembersText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.lblActiveMembersText.Location = new System.Drawing.Point(125, 49);
            this.lblActiveMembersText.Name = "lblActiveMembersText";
            this.lblActiveMembersText.Size = new System.Drawing.Size(109, 16);
            this.lblActiveMembersText.TabIndex = 7;
            this.lblActiveMembersText.Text = "ACTIVE MEMBERS";

            // lblTrainersText
            this.lblTrainersText.AutoSize = true;
            this.lblTrainersText.Font = new System.Drawing.Font("Sitka Small", 8F);
            this.lblTrainersText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.lblTrainersText.Location = new System.Drawing.Point(260, 49);
            this.lblTrainersText.Name = "lblTrainersText";
            this.lblTrainersText.Size = new System.Drawing.Size(65, 16);
            this.lblTrainersText.TabIndex = 8;
            this.lblTrainersText.Text = "TRAINERS";

            // lblUpcomingText
            this.lblUpcomingText.AutoSize = true;
            this.lblUpcomingText.Font = new System.Drawing.Font("Sitka Small", 8F);
            this.lblUpcomingText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.lblUpcomingText.Location = new System.Drawing.Point(18, 109);
            this.lblUpcomingText.Name = "lblUpcomingText";
            this.lblUpcomingText.Size = new System.Drawing.Size(70, 16);
            this.lblUpcomingText.TabIndex = 9;
            this.lblUpcomingText.Text = "UPCOMING";

            // lblOngoingText
            this.lblOngoingText.AutoSize = true;
            this.lblOngoingText.Font = new System.Drawing.Font("Sitka Small", 8F);
            this.lblOngoingText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.lblOngoingText.Location = new System.Drawing.Point(147, 109);
            this.lblOngoingText.Name = "lblOngoingText";
            this.lblOngoingText.Size = new System.Drawing.Size(61, 16);
            this.lblOngoingText.TabIndex = 10;
            this.lblOngoingText.Text = "ONGOING";

            // lblCompletedText
            this.lblCompletedText.AutoSize = true;
            this.lblCompletedText.Font = new System.Drawing.Font("Sitka Small", 8F);
            this.lblCompletedText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.lblCompletedText.Location = new System.Drawing.Point(255, 109);
            this.lblCompletedText.Name = "lblCompletedText";
            this.lblCompletedText.Size = new System.Drawing.Size(76, 16);
            this.lblCompletedText.TabIndex = 11;
            this.lblCompletedText.Text = "COMPLETED";

            // btnGetStarted
            this.btnGetStarted.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(44)))), ((int)(((byte)(140)))));
            this.btnGetStarted.BorderRadius = 10;
            this.btnGetStarted.FlatAppearance.BorderSize = 0;
            this.btnGetStarted.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetStarted.Font = new System.Drawing.Font("Sitka Heading", 11F, System.Drawing.FontStyle.Bold);
            this.btnGetStarted.ForeColor = System.Drawing.Color.White;
            this.btnGetStarted.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(80)))), ((int)(((byte)(180)))));
            this.btnGetStarted.Location = new System.Drawing.Point(30, 151);
            this.btnGetStarted.Name = "btnGetStarted";
            this.btnGetStarted.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(44)))), ((int)(((byte)(140)))));
            this.btnGetStarted.Size = new System.Drawing.Size(120, 35);
            this.btnGetStarted.TabIndex = 12;
            this.btnGetStarted.Text = "Get Started";
            this.btnGetStarted.UseVisualStyleBackColor = false;
            this.btnGetStarted.Click += new System.EventHandler(this.btnGetStarted_Click);

            // btnExploreMore
            this.btnExploreMore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(44)))), ((int)(((byte)(140)))));
            this.btnExploreMore.BorderRadius = 10;
            this.btnExploreMore.FlatAppearance.BorderSize = 0;
            this.btnExploreMore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExploreMore.Font = new System.Drawing.Font("Sitka Heading", 11F, System.Drawing.FontStyle.Bold);
            this.btnExploreMore.ForeColor = System.Drawing.Color.White;
            this.btnExploreMore.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(80)))), ((int)(((byte)(180)))));
            this.btnExploreMore.Location = new System.Drawing.Point(186, 151);
            this.btnExploreMore.Name = "btnExploreMore";
            this.btnExploreMore.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(44)))), ((int)(((byte)(140)))));
            this.btnExploreMore.Size = new System.Drawing.Size(120, 35);
            this.btnExploreMore.TabIndex = 13;
            this.btnExploreMore.Text = "Explore More";
            this.btnExploreMore.UseVisualStyleBackColor = false;
            this.btnExploreMore.Click += new System.EventHandler(this.btnExploreMore_Click);

            // panelActivityLogs
            this.panelActivityLogs.AutoScroll = true;
            this.panelActivityLogs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.panelActivityLogs.Location = new System.Drawing.Point(498, 56);
            this.panelActivityLogs.Name = "panelActivityLogs";
            this.panelActivityLogs.Size = new System.Drawing.Size(391, 454);
            this.panelActivityLogs.TabIndex = 26;
            this.panelActivityLogs.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelActivityLogs_Paint);

            // panelActivityChart
            this.panelActivityChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.panelActivityChart.Location = new System.Drawing.Point(12, 536);
            this.panelActivityChart.Name = "panelActivityChart";
            this.panelActivityChart.Size = new System.Drawing.Size(859, 371);
            this.panelActivityChart.TabIndex = 27;
            this.panelActivityChart.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelActivityChart_Paint);

            // panel2
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(498, 56);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(391, 454);
            this.panel2.TabIndex = 24;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);

            // pictureBox2
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(391, 454);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);

            // Home
            this.Home.BackColor = System.Drawing.Color.White;
            this.Home.BorderRadius = 10;
            this.Home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Home.FlatAppearance.BorderSize = 0;
            this.Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Home.Font = new System.Drawing.Font("Sitka Heading", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Home.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.Home.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(44)))), ((int)(((byte)(140)))));
            this.Home.Location = new System.Drawing.Point(141, 12);
            this.Home.Name = "Home";
            this.Home.NormalColor = System.Drawing.Color.White;
            this.Home.Size = new System.Drawing.Size(85, 31);
            this.Home.TabIndex = 15;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = false;
            this.Home.Click += new System.EventHandler(this.roundedButton1_Click);

            // ClassBooking
            this.ClassBooking.BackColor = System.Drawing.Color.White;
            this.ClassBooking.BorderRadius = 10;
            this.ClassBooking.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClassBooking.FlatAppearance.BorderSize = 0;
            this.ClassBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClassBooking.Font = new System.Drawing.Font("Sitka Heading", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClassBooking.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.ClassBooking.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(44)))), ((int)(((byte)(140)))));
            this.ClassBooking.Location = new System.Drawing.Point(467, 12);
            this.ClassBooking.Name = "ClassBooking";
            this.ClassBooking.NormalColor = System.Drawing.Color.White;
            this.ClassBooking.Size = new System.Drawing.Size(115, 30);
            this.ClassBooking.TabIndex = 12;
            this.ClassBooking.TabStop = false;
            this.ClassBooking.Text = "Class Booking";
            this.ClassBooking.UseVisualStyleBackColor = false;
            this.ClassBooking.Click += new System.EventHandler(this.roundedButton4_Click);

            // Trainers
            this.Trainers.BackColor = System.Drawing.Color.White;
            this.Trainers.BorderRadius = 10;
            this.Trainers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Trainers.FlatAppearance.BorderSize = 0;
            this.Trainers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Trainers.Font = new System.Drawing.Font("Sitka Heading", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Trainers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.Trainers.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(44)))), ((int)(((byte)(140)))));
            this.Trainers.Location = new System.Drawing.Point(364, 12);
            this.Trainers.Name = "Trainers";
            this.Trainers.NormalColor = System.Drawing.Color.White;
            this.Trainers.Size = new System.Drawing.Size(85, 31);
            this.Trainers.TabIndex = 11;
            this.Trainers.TabStop = false;
            this.Trainers.Text = "Trainers";
            this.Trainers.UseVisualStyleBackColor = false;
            this.Trainers.Click += new System.EventHandler(this.roundedButton3_Click);

            // SessionSchedule
            this.SessionSchedule.BackColor = System.Drawing.Color.White;
            this.SessionSchedule.BorderRadius = 10;
            this.SessionSchedule.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SessionSchedule.FlatAppearance.BorderSize = 0;
            this.SessionSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SessionSchedule.Font = new System.Drawing.Font("Sitka Heading", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SessionSchedule.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.SessionSchedule.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(44)))), ((int)(((byte)(140)))));
            this.SessionSchedule.Location = new System.Drawing.Point(598, 12);
            this.SessionSchedule.Name = "SessionSchedule";
            this.SessionSchedule.NormalColor = System.Drawing.Color.White;
            this.SessionSchedule.Size = new System.Drawing.Size(135, 30);
            this.SessionSchedule.TabIndex = 10;
            this.SessionSchedule.TabStop = false;
            this.SessionSchedule.Text = "Session Schedule";
            this.SessionSchedule.UseVisualStyleBackColor = false;
            this.SessionSchedule.Click += new System.EventHandler(this.roundedButton5_Click);

            // Members
            this.Members.BackColor = System.Drawing.Color.White;
            this.Members.BorderRadius = 10;
            this.Members.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Members.FlatAppearance.BorderSize = 0;
            this.Members.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Members.Font = new System.Drawing.Font("Sitka Heading", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Members.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.Members.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(44)))), ((int)(((byte)(140)))));
            this.Members.Location = new System.Drawing.Point(252, 12);
            this.Members.Name = "Members";
            this.Members.NormalColor = System.Drawing.Color.White;
            this.Members.Size = new System.Drawing.Size(85, 31);
            this.Members.TabIndex = 8;
            this.Members.TabStop = false;
            this.Members.Text = "Members";
            this.Members.UseVisualStyleBackColor = false;
            this.Members.Click += new System.EventHandler(this.roundedButton2_Click);

            // More
            this.More.BackColor = System.Drawing.Color.White;
            this.More.BorderRadius = 10;
            this.More.Cursor = System.Windows.Forms.Cursors.Hand;
            this.More.FlatAppearance.BorderSize = 0;
            this.More.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.More.Font = new System.Drawing.Font("Sitka Heading", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.More.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.More.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(44)))), ((int)(((byte)(140)))));
            this.More.Location = new System.Drawing.Point(753, 12);
            this.More.Name = "More";
            this.More.NormalColor = System.Drawing.Color.White;
            this.More.Size = new System.Drawing.Size(85, 31);
            this.More.TabIndex = 9;
            this.More.TabStop = false;
            this.More.Text = "More";
            this.More.UseVisualStyleBackColor = false;
            this.More.Click += new System.EventHandler(this.roundedButton6_Click);

            // MainDashboard
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.panelActivityChart);
            this.Controls.Add(this.panelActivityLogs);
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
            this.Controls.Add(this.More);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainDashboard";
            this.Text = "SpotMe - Dashboard";
            this.Load += new System.EventHandler(this.MainDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelStats.ResumeLayout(false);
            this.panelStats.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private Controls.RoundedButton Members;
        private Controls.RoundedButton More;
        private Controls.RoundedButton SessionSchedule;
        private Controls.RoundedButton Trainers;
        private Controls.RoundedButton ClassBooking;
        private Controls.RoundedButton Home;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.RichTextBox richTextBox1;

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

        private System.Windows.Forms.Panel panelActivityLogs;
        private System.Windows.Forms.Panel panelActivityChart;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}