using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace GymClassBooking.SpotMe.Controls
{
    public class RoundedButton : Button
    {
        private int borderRadius = 15;
        private Color normalColor = Color.FromArgb(111, 44, 140);
        private Color hoverColor = Color.FromArgb(150, 80, 180);

        [Category("Appearance")]
        public int BorderRadius
        {
            get { return borderRadius; }
            set
            {
                borderRadius = value;
                UpdateRegion();
                this.Invalidate();
            }
        }

        [Category("Appearance")]
        public Color NormalColor
        {
            get { return normalColor; }
            set
            {
                normalColor = value;
                if (!isHovered)
                    this.BackColor = normalColor;
                this.Invalidate();
            }
        }

        [Category("Appearance")]
        public Color HoverColor
        {
            get { return hoverColor; }
            set { hoverColor = value; }
        }

        private bool isHovered = false;

        public RoundedButton()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.BackColor = normalColor;
            this.ForeColor = Color.White;
            this.Size = new Size(100, 40);
            this.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            UpdateRegion();
        }

        private void UpdateRegion()
        {
            if (this.Width > 0 && this.Height > 0)
            {
                using (GraphicsPath path = new GraphicsPath())
                {
                    path.AddArc(0, 0, borderRadius, borderRadius, 180, 90);
                    path.AddArc(this.Width - borderRadius, 0, borderRadius, borderRadius, 270, 90);
                    path.AddArc(this.Width - borderRadius, this.Height - borderRadius, borderRadius, borderRadius, 0, 90);
                    path.AddArc(0, this.Height - borderRadius, borderRadius, borderRadius, 90, 90);
                    path.CloseAllFigures();

                    this.Region = new Region(path);
                }
            }
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            isHovered = true;
            this.BackColor = hoverColor;
            base.OnMouseEnter(e);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            isHovered = false;
            this.BackColor = normalColor;
            base.OnMouseLeave(e);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            UpdateRegion();
        }
    }
}