using System.Drawing;
using System.Windows.Forms;

namespace GymClassBooking.SpotMe.Controls
{
    public class BulletPointLabel : Label
    {
        public BulletPointLabel()
        {
            this.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.ForeColor = Color.Black;
            this.AutoSize = true;
            this.Padding = new Padding(0, 5, 0, 0);
        }

        public void SetText(string text)
        {
            this.Text = "• " + text;
        }
    }
}