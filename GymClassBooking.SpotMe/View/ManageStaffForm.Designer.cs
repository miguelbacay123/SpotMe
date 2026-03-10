namespace GymClassBooking.SpotMe.View
{
    partial class ManageStaffForm
    {
        private System.ComponentModel.IContainer components = null;

        public System.Windows.Forms.Label lblTitle;
        public System.Windows.Forms.Label lblSubtitle;
        public System.Windows.Forms.Button btnAddStaff;
        public System.Windows.Forms.Panel pnlHeader;

        public System.Windows.Forms.Label lblHeaderEmail;
        public System.Windows.Forms.Label lblHeaderUsername;
        public System.Windows.Forms.Label lblHeaderActions;
        public System.Windows.Forms.Panel pnlTableHeader;

        public System.Windows.Forms.Panel pnlContent;
        public System.Windows.Forms.Label lblEmpty;

        public System.Windows.Forms.Button btnBack;

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
            this.btnAddStaff = new System.Windows.Forms.Button();
            this.pnlTableHeader = new System.Windows.Forms.Panel();
            this.lblHeaderEmail = new System.Windows.Forms.Label();
            this.lblHeaderUsername = new System.Windows.Forms.Label();
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
            this.pnlHeader.Controls.Add(this.btnAddStaff);
            this.pnlHeader.Location = new System.Drawing.Point(12, 12);
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
            this.lblTitle.Size = new System.Drawing.Size(220, 45);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Manage Staff";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.White;
            this.lblSubtitle.Location = new System.Drawing.Point(20, 60);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(250, 19);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Staff members that manage the system";
            // 
            // btnAddStaff
            // 
            this.btnAddStaff.BackColor = System.Drawing.Color.White;
            this.btnAddStaff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddStaff.FlatAppearance.BorderSize = 0;
            this.btnAddStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStaff.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddStaff.ForeColor = System.Drawing.Color.Black;
            this.btnAddStaff.Location = new System.Drawing.Point(740, 28);
            this.btnAddStaff.Name = "btnAddStaff";
            this.btnAddStaff.Size = new System.Drawing.Size(110, 38);
            this.btnAddStaff.TabIndex = 2;
            this.btnAddStaff.Text = "+ Add Staff";
            this.btnAddStaff.UseVisualStyleBackColor = false;
            this.btnAddStaff.Click += new System.EventHandler(this.BtnAddStaff_Click);
            // 
            // pnlTableHeader
            // 
            this.pnlTableHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.pnlTableHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTableHeader.Controls.Add(this.lblHeaderEmail);
            this.pnlTableHeader.Controls.Add(this.lblHeaderUsername);
            this.pnlTableHeader.Controls.Add(this.lblHeaderActions);
            this.pnlTableHeader.Location = new System.Drawing.Point(12, 113);
            this.pnlTableHeader.Name = "pnlTableHeader";
            this.pnlTableHeader.Size = new System.Drawing.Size(860, 40);
            this.pnlTableHeader.TabIndex = 1;
            // 
            // lblHeaderEmail
            // 
            this.lblHeaderEmail.AutoSize = true;
            this.lblHeaderEmail.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblHeaderEmail.Location = new System.Drawing.Point(25, 10);
            this.lblHeaderEmail.Name = "lblHeaderEmail";
            this.lblHeaderEmail.Size = new System.Drawing.Size(50, 19);
            this.lblHeaderEmail.TabIndex = 0;
            this.lblHeaderEmail.Text = "EMAIL";
            // 
            // lblHeaderUsername
            // 
            this.lblHeaderUsername.AutoSize = true;
            this.lblHeaderUsername.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblHeaderUsername.Location = new System.Drawing.Point(370, 10);
            this.lblHeaderUsername.Name = "lblHeaderUsername";
            this.lblHeaderUsername.Size = new System.Drawing.Size(84, 19);
            this.lblHeaderUsername.TabIndex = 1;
            this.lblHeaderUsername.Text = "USERNAME";
            // 
            // lblHeaderActions
            // 
            this.lblHeaderActions.AutoSize = true;
            this.lblHeaderActions.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblHeaderActions.Location = new System.Drawing.Point(750, 10);
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
            this.pnlContent.Location = new System.Drawing.Point(12, 159);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(860, 310);
            this.pnlContent.TabIndex = 2;
            // 
            // lblEmpty
            // 
            this.lblEmpty.AutoSize = true;
            this.lblEmpty.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Italic);
            this.lblEmpty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.lblEmpty.Location = new System.Drawing.Point(305, 115);
            this.lblEmpty.Name = "lblEmpty";
            this.lblEmpty.Size = new System.Drawing.Size(320, 20);
            this.lblEmpty.TabIndex = 0;
            this.lblEmpty.Text = "No staff members added yet.";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(44)))), ((int)(((byte)(140)))));
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(12, 475);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(860, 40);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back to Dashboard";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // ManageStaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlTableHeader);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.btnBack);
            this.Name = "ManageStaffForm";
            this.Text = "Manage Staff";
            this.Load += new System.EventHandler(this.ManageStaffForm_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlTableHeader.ResumeLayout(false);
            this.pnlTableHeader.PerformLayout();
            this.ResumeLayout(false);

        }
    }
}