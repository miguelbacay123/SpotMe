namespace GymClassBooking.SpotMe.View
{
    partial class SessionMembersForm
    {
        private System.ComponentModel.IContainer components = null;

        public System.Windows.Forms.Label lblTitle;
        public System.Windows.Forms.Label lblSubtitle;
        public System.Windows.Forms.Button btnNewBooking;
        public System.Windows.Forms.Panel pnlHeader;

        public System.Windows.Forms.Label lblHeaderMember;
        public System.Windows.Forms.Label lblHeaderDate;
        public System.Windows.Forms.Label lblHeaderActions;
        public System.Windows.Forms.Panel pnlTableHeader;

        public System.Windows.Forms.Panel pnlContent;
        public System.Windows.Forms.Label lblEmpty;

        public System.Windows.Forms.Button btnBack;
        public System.Windows.Forms.Label label1;

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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.btnNewBooking = new System.Windows.Forms.Button();
            this.pnlTableHeader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblHeaderMember = new System.Windows.Forms.Label();
            this.lblHeaderDate = new System.Windows.Forms.Label();
            this.lblHeaderActions = new System.Windows.Forms.Label();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.lblEmpty = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.pnlTableHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(44)))), ((int)(((byte)(140)))));
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.lblSubtitle);
            this.pnlHeader.Controls.Add(this.btnNewBooking);
            this.pnlHeader.Location = new System.Drawing.Point(12, 42);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(860, 95);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(281, 45);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Session Members";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.White;
            this.lblSubtitle.Location = new System.Drawing.Point(20, 60);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(247, 19);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Members That Already Booked Session";
            // 
            // btnNewBooking
            // 
            this.btnNewBooking.BackColor = System.Drawing.Color.White;
            this.btnNewBooking.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewBooking.FlatAppearance.BorderSize = 0;
            this.btnNewBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewBooking.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnNewBooking.ForeColor = System.Drawing.Color.Black;
            this.btnNewBooking.Location = new System.Drawing.Point(740, 28);
            this.btnNewBooking.Name = "btnNewBooking";
            this.btnNewBooking.Size = new System.Drawing.Size(110, 38);
            this.btnNewBooking.TabIndex = 2;
            this.btnNewBooking.Text = "New Booking";
            this.btnNewBooking.UseVisualStyleBackColor = false;
            this.btnNewBooking.Click += new System.EventHandler(this.BtnNewBooking_Click);
            // 
            // pnlTableHeader
            // 
            this.pnlTableHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.pnlTableHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTableHeader.Controls.Add(this.label1);
            this.pnlTableHeader.Controls.Add(this.lblHeaderMember);
            this.pnlTableHeader.Controls.Add(this.lblHeaderDate);
            this.pnlTableHeader.Controls.Add(this.lblHeaderActions);
            this.pnlTableHeader.Location = new System.Drawing.Point(12, 143);
            this.pnlTableHeader.Name = "pnlTableHeader";
            this.pnlTableHeader.Size = new System.Drawing.Size(860, 40);
            this.pnlTableHeader.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(446, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "STATUS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblHeaderMember
            // 
            this.lblHeaderMember.AutoSize = true;
            this.lblHeaderMember.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblHeaderMember.Location = new System.Drawing.Point(25, 10);
            this.lblHeaderMember.Name = "lblHeaderMember";
            this.lblHeaderMember.Size = new System.Drawing.Size(67, 19);
            this.lblHeaderMember.TabIndex = 0;
            this.lblHeaderMember.Text = "MEMBER";
            // 
            // lblHeaderDate
            // 
            this.lblHeaderDate.AutoSize = true;
            this.lblHeaderDate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblHeaderDate.Location = new System.Drawing.Point(201, 10);
            this.lblHeaderDate.Name = "lblHeaderDate";
            this.lblHeaderDate.Size = new System.Drawing.Size(112, 19);
            this.lblHeaderDate.TabIndex = 1;
            this.lblHeaderDate.Text = "BOOKING DATE";
            this.lblHeaderDate.Click += new System.EventHandler(this.lblHeaderDate_Click);
            // 
            // lblHeaderActions
            // 
            this.lblHeaderActions.AutoSize = true;
            this.lblHeaderActions.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblHeaderActions.Location = new System.Drawing.Point(677, 10);
            this.lblHeaderActions.Name = "lblHeaderActions";
            this.lblHeaderActions.Size = new System.Drawing.Size(70, 19);
            this.lblHeaderActions.TabIndex = 2;
            this.lblHeaderActions.Text = "ACTIONS";
            // 
            // pnlContent
            // 
            this.pnlContent.AutoScroll = true;
            this.pnlContent.BackColor = System.Drawing.Color.White;
            this.pnlContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlContent.Location = new System.Drawing.Point(12, 189);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(860, 250);
            this.pnlContent.TabIndex = 2;
            // 
            // lblEmpty
            // 
            this.lblEmpty.AutoSize = true;
            this.lblEmpty.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Italic);
            this.lblEmpty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.lblEmpty.Location = new System.Drawing.Point(305, 115);
            this.lblEmpty.Name = "lblEmpty";
            this.lblEmpty.Size = new System.Drawing.Size(380, 20);
            this.lblEmpty.TabIndex = 0;
            this.lblEmpty.Text = "No members booked for this session yet.";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(44)))), ((int)(((byte)(140)))));
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(12, 445);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(860, 40);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back to List";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // SessionMembersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlTableHeader);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.btnBack);
            this.Name = "SessionMembersForm";
            this.Text = "Session Members";
            this.Load += new System.EventHandler(this.SessionMembersForm_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlTableHeader.ResumeLayout(false);
            this.pnlTableHeader.PerformLayout();
            this.ResumeLayout(false);

        }
    }
}