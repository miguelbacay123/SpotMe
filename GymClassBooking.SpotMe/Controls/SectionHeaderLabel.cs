using System.Drawing;
using System.Windows.Forms;

namespace GymClassBooking.SpotMe.Controls
{
    public class SectionHeaderLabel : Label
    {
        public SectionHeaderLabel()
        {
            this.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            this.ForeColor = Color.FromArgb(111, 44, 140);
            this.AutoSize = true;
            this.Padding = new Padding(0, 15, 0, 5);
        }
    }
}