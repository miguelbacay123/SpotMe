using System.Drawing;
using System.Windows.Forms;

namespace GymClassBooking.SpotMe.Controls
{
    public class SeparatorLine : Control
    {
        public SeparatorLine()
        {
            this.Height = 2;
            this.BackColor = Color.FromArgb(230, 230, 230);
            this.TabStop = false;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            using (Pen pen = new Pen(Color.FromArgb(200, 200, 200)))
            {
                e.Graphics.DrawLine(pen, 0, 1, this.Width, 1);
            }
        }
    }
}