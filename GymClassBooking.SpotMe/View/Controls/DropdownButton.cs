using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace GymClassBooking.SpotMe.Controls
{
    public class DropdownButton : Button
    {
        private ContextMenuStrip _menu = new ContextMenuStrip();
        private Color _normalColor = Color.White;
        private Color _hoverColor = Color.MediumPurple;
        private Color _normalTextColor = Color.Black;
        private Color _hoverTextColor = Color.White;

        public DropdownButton()
        {
            this.Text = "More";
            this.TextAlign = ContentAlignment.MiddleCenter;
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.BackColor = _normalColor;
            this.ForeColor = _normalTextColor;
            this.Font = new Font("Sitka Heading", 11.25F, FontStyle.Bold);
            this.Cursor = Cursors.Hand;

            this.Click += DropdownButton_Click;
            this.MouseEnter += DropdownButton_MouseEnter;
            this.MouseLeave += DropdownButton_MouseLeave;
        }

        [Category("Dropdown Settings")]
        [Description("The items shown in the dropdown menu")]
        public ContextMenuStrip Items
        {
            get { return _menu; }
            set { _menu = value; }
        }

        [Category("Appearance")]
        [Description("The background color when mouse hovers over the button")]
        public Color HoverColor
        {
            get { return _hoverColor; }
            set { _hoverColor = value; }
        }

        [Category("Appearance")]
        [Description("The normal background color of the button")]
        public Color NormalColor
        {
            get { return _normalColor; }
            set
            {
                _normalColor = value;
                this.BackColor = value;
            }
        }

        [Category("Appearance")]
        [Description("The text color when mouse hovers over the button")]
        public Color HoverTextColor
        {
            get { return _hoverTextColor; }
            set { _hoverTextColor = value; }
        }

        [Category("Appearance")]
        [Description("The normal text color of the button")]
        public Color NormalTextColor
        {
            get { return _normalTextColor; }
            set
            {
                _normalTextColor = value;
                this.ForeColor = value;
            }
        }

        private void DropdownButton_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = _hoverColor;
            this.ForeColor = _hoverTextColor;
        }

        private void DropdownButton_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = _normalColor;
            this.ForeColor = _normalTextColor;
        }

        private void DropdownButton_Click(object sender, EventArgs e)
        {
            _menu.Show(this, new Point(0, this.Height));
        }
    }
}