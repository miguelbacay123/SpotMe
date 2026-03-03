namespace GymClassBooking.SpotMe.View
{
    partial class AddMemberForm
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
            this.btnSave = new GymClassBooking.SpotMe.Controls.RoundedButton();
            this.btnCancel = new GymClassBooking.SpotMe.Controls.RoundedButton();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.cboGender = new System.Windows.Forms.ComboBox();
            this.lblPhoto = new System.Windows.Forms.Label();
            this.btnChoosePhoto = new System.Windows.Forms.Button();
            this.picPreview = new GymClassBooking.SpotMe.Controls.CircularPictureBox();

            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).BeginInit();
            this.SuspendLayout();

            // Form Settings
            this.Text = "Add New Member";
            this.ClientSize = new System.Drawing.Size(500, 450);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            // Title
            this.lblTitle.Text = "Add New Member";
            this.lblTitle.Font = new System.Drawing.Font("Sitka Heading", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.Purple;
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Size = new System.Drawing.Size(250, 35);

            // Photo
            this.lblPhoto.Text = "Photo:";
            this.lblPhoto.Location = new System.Drawing.Point(30, 80);
            this.lblPhoto.Size = new System.Drawing.Size(80, 25);

            this.btnChoosePhoto.Text = "Choose Photo";
            this.btnChoosePhoto.Location = new System.Drawing.Point(120, 80);
            this.btnChoosePhoto.Size = new System.Drawing.Size(100, 30);
            this.btnChoosePhoto.UseVisualStyleBackColor = true;
            this.btnChoosePhoto.Click += new System.EventHandler(this.btnChoosePhoto_Click);

            this.picPreview.BackColor = System.Drawing.Color.LightGray;
            this.picPreview.Location = new System.Drawing.Point(240, 65);
            this.picPreview.Size = new System.Drawing.Size(70, 70);
            this.picPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;

            // Name
            this.lblName.Text = "Name:";
            this.lblName.Location = new System.Drawing.Point(30, 150);
            this.lblName.Size = new System.Drawing.Size(80, 25);

            this.txtName.Location = new System.Drawing.Point(120, 150);
            this.txtName.Size = new System.Drawing.Size(250, 25);

            // Email
            this.lblEmail.Text = "Email:";
            this.lblEmail.Location = new System.Drawing.Point(30, 190);
            this.lblEmail.Size = new System.Drawing.Size(80, 25);

            this.txtEmail.Location = new System.Drawing.Point(120, 190);
            this.txtEmail.Size = new System.Drawing.Size(250, 25);

            // Phone
            this.lblPhone.Text = "Phone:";
            this.lblPhone.Location = new System.Drawing.Point(30, 230);
            this.lblPhone.Size = new System.Drawing.Size(80, 25);

            this.txtPhone.Location = new System.Drawing.Point(120, 230);
            this.txtPhone.Size = new System.Drawing.Size(250, 25);

            // Gender
            this.lblGender.Text = "Gender:";
            this.lblGender.Location = new System.Drawing.Point(30, 270);
            this.lblGender.Size = new System.Drawing.Size(80, 25);

            this.cboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGender.Items.AddRange(new object[] { "Male", "Female", "Other" });
            this.cboGender.Location = new System.Drawing.Point(120, 270);
            this.cboGender.Size = new System.Drawing.Size(250, 25);

            // Buttons
            this.btnSave.Text = "Save";
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(111, 44, 140);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(150, 330);
            this.btnSave.Size = new System.Drawing.Size(100, 35);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            this.btnCancel.Text = "Cancel";
            this.btnCancel.BackColor = System.Drawing.Color.LightGray;
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(270, 330);
            this.btnCancel.Size = new System.Drawing.Size(100, 35);
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            // Add controls to form
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblPhoto);
            this.Controls.Add(this.btnChoosePhoto);
            this.Controls.Add(this.picPreview);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.cboGender);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);

            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblTitle;
        private Controls.RoundedButton btnSave;
        private Controls.RoundedButton btnCancel;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.ComboBox cboGender;
        private System.Windows.Forms.Label lblPhoto;
        private System.Windows.Forms.Button btnChoosePhoto;
        private Controls.CircularPictureBox picPreview;
    }
}