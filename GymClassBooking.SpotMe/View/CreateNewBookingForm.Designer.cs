namespace GymClassBooking.SpotMe.View
{
    partial class CreateNewBookingForm
    {
        private System.ComponentModel.IContainer components = null;

        public System.Windows.Forms.Label lblTitle;
        public System.Windows.Forms.Panel pnlMain;
        public System.Windows.Forms.Label lblBookingInfo;
        public System.Windows.Forms.Label lblMember;
        public System.Windows.Forms.ComboBox cbMembers;
        public System.Windows.Forms.Button btnCreate;
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.lblBookingInfo = new System.Windows.Forms.Label();
            this.lblMember = new System.Windows.Forms.Label();
            this.cbMembers = new System.Windows.Forms.ComboBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(30, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(280, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Create New Booking";
            // 
            // pnlMain
            // 
            this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMain.Controls.Add(this.lblBookingInfo);
            this.pnlMain.Controls.Add(this.lblMember);
            this.pnlMain.Controls.Add(this.cbMembers);
            this.pnlMain.Controls.Add(this.btnCreate);
            this.pnlMain.Controls.Add(this.btnBack);
            this.pnlMain.Location = new System.Drawing.Point(30, 65);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(640, 200);
            this.pnlMain.TabIndex = 1;
            // 
            // lblBookingInfo
            // 
            this.lblBookingInfo.AutoSize = true;
            this.lblBookingInfo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblBookingInfo.Location = new System.Drawing.Point(20, 15);
            this.lblBookingInfo.Name = "lblBookingInfo";
            this.lblBookingInfo.Size = new System.Drawing.Size(156, 20);
            this.lblBookingInfo.TabIndex = 0;
            this.lblBookingInfo.Text = "Booking Information";
            // 
            // lblMember
            // 
            this.lblMember.AutoSize = true;
            this.lblMember.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblMember.Location = new System.Drawing.Point(20, 55);
            this.lblMember.Name = "lblMember";
            this.lblMember.Size = new System.Drawing.Size(61, 19);
            this.lblMember.TabIndex = 1;
            this.lblMember.Text = "Member";
            // 
            // cbMembers
            // 
            this.cbMembers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMembers.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbMembers.FormattingEnabled = true;
            this.cbMembers.Location = new System.Drawing.Point(20, 77);
            this.cbMembers.Name = "cbMembers";
            this.cbMembers.Size = new System.Drawing.Size(600, 25);
            this.cbMembers.TabIndex = 2;
            this.cbMembers.SelectedIndexChanged += new System.EventHandler(this.cbMembers_SelectedIndexChanged);
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(44)))), ((int)(((byte)(140)))));
            this.btnCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreate.FlatAppearance.BorderSize = 0;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCreate.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCreate.Location = new System.Drawing.Point(20, 140);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(160, 40);
            this.btnCreate.TabIndex = 3;
            this.btnCreate.Text = "Create Booking";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(188, 140);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(160, 40);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back to List";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // CreateNewBookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 450);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pnlMain);
            this.Name = "CreateNewBookingForm";
            this.Text = "Create New Booking";
            this.Load += new System.EventHandler(this.CreateNewBookingForm_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}