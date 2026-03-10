namespace GymClassBooking.SpotMe.View
{
    partial class BookingClassDetailsForm
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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.iconCategory = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconDuration = new System.Windows.Forms.Label();
            this.lblDurationLabel = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.lblDescriptionLabel = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.panelRow1 = new System.Windows.Forms.Panel();
            this.iconTrainer = new System.Windows.Forms.Label();
            this.lblTrainerLabel = new System.Windows.Forms.Label();
            this.lblTrainer = new System.Windows.Forms.Label();
            this.iconCapacity = new System.Windows.Forms.Label();
            this.lblCapacityLabel = new System.Windows.Forms.Label();
            this.lblCapacity = new System.Windows.Forms.Label();
            this.panelRow2 = new System.Windows.Forms.Panel();
            this.iconStartTime = new System.Windows.Forms.Label();
            this.lblStartTimeLabel = new System.Windows.Forms.Label();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.iconEndTime = new System.Windows.Forms.Label();
            this.lblEndTimeLabel = new System.Windows.Forms.Label();
            this.lblEndTime = new System.Windows.Forms.Label();
            this.btnBackToList = new GymClassBooking.SpotMe.Controls.RoundedButton();
            this.panelHeader.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelRow1.SuspendLayout();
            this.panelRow2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(44)))), ((int)(((byte)(140)))));
            this.panelHeader.Controls.Add(this.iconCategory);
            this.panelHeader.Controls.Add(this.lblCategory);
            this.panelHeader.Controls.Add(this.lblStatus);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(500, 107);
            this.panelHeader.TabIndex = 0;
            // 
            // iconCategory
            // 
            this.iconCategory.Font = new System.Drawing.Font("Segoe UI Symbol", 18F);
            this.iconCategory.ForeColor = System.Drawing.Color.White;
            this.iconCategory.Location = new System.Drawing.Point(30, 25);
            this.iconCategory.Name = "iconCategory";
            this.iconCategory.Size = new System.Drawing.Size(36, 37);
            this.iconCategory.TabIndex = 0;
            this.iconCategory.Text = "📅";
            // 
            // lblCategory
            // 
            this.lblCategory.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblCategory.ForeColor = System.Drawing.Color.White;
            this.lblCategory.Location = new System.Drawing.Point(64, 25);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(380, 35);
            this.lblCategory.TabIndex = 1;
            this.lblCategory.Text = "Yoga";
            this.lblCategory.AutoEllipsis = true;
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.Color.White;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblStatus.ForeColor = System.Drawing.Color.Black;
            this.lblStatus.Location = new System.Drawing.Point(35, 71);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(75, 20);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "UPCOMING";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.White;
            this.panelContent.Controls.Add(this.panel1);
            this.panelContent.Controls.Add(this.lblDescriptionLabel);
            this.panelContent.Controls.Add(this.lblDescription);
            this.panelContent.Controls.Add(this.panelRow1);
            this.panelContent.Controls.Add(this.panelRow2);
            this.panelContent.Controls.Add(this.btnBackToList);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 107);
            this.panelContent.Name = "panelContent";
            this.panelContent.Padding = new System.Windows.Forms.Padding(30);
            this.panelContent.Size = new System.Drawing.Size(500, 493);
            this.panelContent.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.iconDuration);
            this.panel1.Controls.Add(this.lblDurationLabel);
            this.panel1.Controls.Add(this.lblDuration);
            this.panel1.Location = new System.Drawing.Point(30, 253);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(440, 77);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // iconDuration
            // 
            this.iconDuration.Font = new System.Drawing.Font("Segoe UI Symbol", 16F);
            this.iconDuration.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.iconDuration.Location = new System.Drawing.Point(6, 10);
            this.iconDuration.Name = "iconDuration";
            this.iconDuration.Size = new System.Drawing.Size(33, 32);
            this.iconDuration.TabIndex = 5;
            this.iconDuration.Text = "⏱️";
            // 
            // lblDurationLabel
            // 
            this.lblDurationLabel.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblDurationLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblDurationLabel.Location = new System.Drawing.Point(42, 12);
            this.lblDurationLabel.Name = "lblDurationLabel";
            this.lblDurationLabel.Size = new System.Drawing.Size(65, 12);
            this.lblDurationLabel.TabIndex = 4;
            this.lblDurationLabel.Text = "DURATION";
            this.lblDurationLabel.Click += new System.EventHandler(this.lblDurationLabel_Click);
            // 
            // lblDuration
            // 
            this.lblDuration.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblDuration.ForeColor = System.Drawing.Color.Black;
            this.lblDuration.Location = new System.Drawing.Point(39, 24);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(135, 20);
            this.lblDuration.TabIndex = 6;
            this.lblDuration.Text = "1 Hours 0 Minutes";
            this.lblDuration.Click += new System.EventHandler(this.lblDuration_Click);
            // 
            // lblDescriptionLabel
            // 
            this.lblDescriptionLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDescriptionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblDescriptionLabel.Location = new System.Drawing.Point(30, 20);
            this.lblDescriptionLabel.Name = "lblDescriptionLabel";
            this.lblDescriptionLabel.Size = new System.Drawing.Size(100, 15);
            this.lblDescriptionLabel.TabIndex = 0;
            this.lblDescriptionLabel.Text = "DESCRIPTION";
            // 
            // lblDescription
            // 
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(44)))), ((int)(((byte)(140)))));
            this.lblDescription.Location = new System.Drawing.Point(30, 40);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(440, 50);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "Class description";
            // 
            // panelRow1
            // 
            this.panelRow1.BackColor = System.Drawing.Color.White;
            this.panelRow1.Controls.Add(this.iconTrainer);
            this.panelRow1.Controls.Add(this.lblTrainerLabel);
            this.panelRow1.Controls.Add(this.lblTrainer);
            this.panelRow1.Controls.Add(this.iconCapacity);
            this.panelRow1.Controls.Add(this.lblCapacityLabel);
            this.panelRow1.Controls.Add(this.lblCapacity);
            this.panelRow1.Location = new System.Drawing.Point(30, 93);
            this.panelRow1.Name = "panelRow1";
            this.panelRow1.Size = new System.Drawing.Size(440, 60);
            this.panelRow1.TabIndex = 2;
            this.panelRow1.Paint += new System.Windows.Forms.PaintEventHandler(this.panelRow1_Paint);
            // 
            // iconTrainer
            // 
            this.iconTrainer.Font = new System.Drawing.Font("Segoe UI Symbol", 16F);
            this.iconTrainer.Location = new System.Drawing.Point(3, 5);
            this.iconTrainer.Name = "iconTrainer";
            this.iconTrainer.Size = new System.Drawing.Size(33, 35);
            this.iconTrainer.TabIndex = 0;
            this.iconTrainer.Text = "👤";
            // 
            // lblTrainerLabel
            // 
            this.lblTrainerLabel.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblTrainerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblTrainerLabel.Location = new System.Drawing.Point(42, 5);
            this.lblTrainerLabel.Name = "lblTrainerLabel";
            this.lblTrainerLabel.Size = new System.Drawing.Size(59, 12);
            this.lblTrainerLabel.TabIndex = 1;
            this.lblTrainerLabel.Text = "TRAINER";
            // 
            // lblTrainer
            // 
            this.lblTrainer.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTrainer.ForeColor = System.Drawing.Color.Black;
            this.lblTrainer.Location = new System.Drawing.Point(39, 20);
            this.lblTrainer.Name = "lblTrainer";
            this.lblTrainer.Size = new System.Drawing.Size(150, 20);
            this.lblTrainer.TabIndex = 2;
            this.lblTrainer.Text = "Trainer Name";
            // 
            // iconCapacity
            // 
            this.iconCapacity.Font = new System.Drawing.Font("Segoe UI Symbol", 16F);
            this.iconCapacity.Location = new System.Drawing.Point(212, 5);
            this.iconCapacity.Name = "iconCapacity";
            this.iconCapacity.Size = new System.Drawing.Size(32, 35);
            this.iconCapacity.TabIndex = 3;
            this.iconCapacity.Text = "👥";
            // 
            // lblCapacityLabel
            // 
            this.lblCapacityLabel.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblCapacityLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblCapacityLabel.Location = new System.Drawing.Point(250, 5);
            this.lblCapacityLabel.Name = "lblCapacityLabel";
            this.lblCapacityLabel.Size = new System.Drawing.Size(60, 12);
            this.lblCapacityLabel.TabIndex = 4;
            this.lblCapacityLabel.Text = "CAPACITY";
            // 
            // lblCapacity
            // 
            this.lblCapacity.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCapacity.ForeColor = System.Drawing.Color.Black;
            this.lblCapacity.Location = new System.Drawing.Point(249, 20);
            this.lblCapacity.Name = "lblCapacity";
            this.lblCapacity.Size = new System.Drawing.Size(150, 20);
            this.lblCapacity.TabIndex = 5;
            this.lblCapacity.Text = "0/10 spots";
            // 
            // panelRow2
            // 
            this.panelRow2.BackColor = System.Drawing.Color.White;
            this.panelRow2.Controls.Add(this.iconStartTime);
            this.panelRow2.Controls.Add(this.lblStartTimeLabel);
            this.panelRow2.Controls.Add(this.lblStartTime);
            this.panelRow2.Controls.Add(this.iconEndTime);
            this.panelRow2.Controls.Add(this.lblEndTimeLabel);
            this.panelRow2.Controls.Add(this.lblEndTime);
            this.panelRow2.Location = new System.Drawing.Point(30, 170);
            this.panelRow2.Name = "panelRow2";
            this.panelRow2.Size = new System.Drawing.Size(440, 77);
            this.panelRow2.TabIndex = 3;
            // 
            // iconStartTime
            // 
            this.iconStartTime.Font = new System.Drawing.Font("Segoe UI Symbol", 16F);
            this.iconStartTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(44)))), ((int)(((byte)(140)))));
            this.iconStartTime.Location = new System.Drawing.Point(3, 5);
            this.iconStartTime.Name = "iconStartTime";
            this.iconStartTime.Size = new System.Drawing.Size(33, 32);
            this.iconStartTime.TabIndex = 0;
            this.iconStartTime.Text = "🕐";
            this.iconStartTime.Click += new System.EventHandler(this.iconStartTime_Click);
            // 
            // lblStartTimeLabel
            // 
            this.lblStartTimeLabel.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblStartTimeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblStartTimeLabel.Location = new System.Drawing.Point(42, 8);
            this.lblStartTimeLabel.Name = "lblStartTimeLabel";
            this.lblStartTimeLabel.Size = new System.Drawing.Size(80, 12);
            this.lblStartTimeLabel.TabIndex = 1;
            this.lblStartTimeLabel.Text = "START TIME";
            // 
            // lblStartTime
            // 
            this.lblStartTime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblStartTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(44)))), ((int)(((byte)(140)))));
            this.lblStartTime.Location = new System.Drawing.Point(40, 20);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(166, 20);
            this.lblStartTime.TabIndex = 2;
            this.lblStartTime.Text = "3/23/2026, 10:45:00 AM";
            // 
            // iconEndTime
            // 
            this.iconEndTime.Font = new System.Drawing.Font("Segoe UI Symbol", 16F);
            this.iconEndTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(44)))), ((int)(((byte)(140)))));
            this.iconEndTime.Location = new System.Drawing.Point(212, 5);
            this.iconEndTime.Name = "iconEndTime";
            this.iconEndTime.Size = new System.Drawing.Size(33, 32);
            this.iconEndTime.TabIndex = 3;
            this.iconEndTime.Text = "🕐";
            // 
            // lblEndTimeLabel
            // 
            this.lblEndTimeLabel.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblEndTimeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblEndTimeLabel.Location = new System.Drawing.Point(250, 5);
            this.lblEndTimeLabel.Name = "lblEndTimeLabel";
            this.lblEndTimeLabel.Size = new System.Drawing.Size(60, 12);
            this.lblEndTimeLabel.TabIndex = 4;
            this.lblEndTimeLabel.Text = "END TIME";
            // 
            // lblEndTime
            // 
            this.lblEndTime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblEndTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(44)))), ((int)(((byte)(140)))));
            this.lblEndTime.Location = new System.Drawing.Point(250, 20);
            this.lblEndTime.Name = "lblEndTime";
            this.lblEndTime.Size = new System.Drawing.Size(200, 20);
            this.lblEndTime.TabIndex = 5;
            this.lblEndTime.Text = "3/7/2026, 11:47:00 AM";
            // 
            // btnBackToList
            // 
            this.btnBackToList.BackColor = System.Drawing.Color.White;
            this.btnBackToList.BorderRadius = 10;
            this.btnBackToList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackToList.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(44)))), ((int)(((byte)(140)))));
            this.btnBackToList.FlatAppearance.BorderSize = 2;
            this.btnBackToList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackToList.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnBackToList.ForeColor = System.Drawing.Color.Black;
            this.btnBackToList.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(80)))), ((int)(((byte)(180)))));
            this.btnBackToList.Location = new System.Drawing.Point(30, 420);
            this.btnBackToList.Name = "btnBackToList";
            this.btnBackToList.NormalColor = System.Drawing.Color.White;
            this.btnBackToList.Size = new System.Drawing.Size(440, 40);
            this.btnBackToList.TabIndex = 7;
            this.btnBackToList.Text = "← Back to List";
            this.btnBackToList.UseVisualStyleBackColor = false;
            this.btnBackToList.Click += new System.EventHandler(this.btnBackToList_Click);
            // 
            // BookingClassDetailsForm
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(500, 600);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BookingClassDetailsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.panelHeader.ResumeLayout(false);
            this.panelContent.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panelRow1.ResumeLayout(false);
            this.panelRow2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label iconCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblStatus;

        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Label lblDescriptionLabel;
        private System.Windows.Forms.Label lblDescription;

        private System.Windows.Forms.Panel panelRow1;
        private System.Windows.Forms.Label iconTrainer;
        private System.Windows.Forms.Label lblTrainerLabel;
        private System.Windows.Forms.Label lblTrainer;
        private System.Windows.Forms.Label iconCapacity;
        private System.Windows.Forms.Label lblCapacityLabel;
        private System.Windows.Forms.Label lblCapacity;

        private System.Windows.Forms.Panel panelRow2;
        private System.Windows.Forms.Label iconStartTime;
        private System.Windows.Forms.Label lblStartTimeLabel;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.Label iconEndTime;
        private System.Windows.Forms.Label lblEndTimeLabel;
        private System.Windows.Forms.Label lblEndTime;

        private System.Windows.Forms.Label lblDurationLabel;
        private System.Windows.Forms.Label iconDuration;
        private System.Windows.Forms.Label lblDuration;

        private Controls.RoundedButton btnBackToList;
        private System.Windows.Forms.Panel panel1;
    }
}