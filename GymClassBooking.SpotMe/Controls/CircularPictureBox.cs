using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace GymClassBooking.SpotMe.Controls
{
    public class CircularPictureBox : PictureBox
    {
        public CircularPictureBox()
        {
            this.SizeMode = PictureBoxSizeMode.Zoom;
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(0, 0, this.Width - 1, this.Height - 1);
            this.Region = new Region(gp);
            base.OnPaint(pe);
        }
    }
}