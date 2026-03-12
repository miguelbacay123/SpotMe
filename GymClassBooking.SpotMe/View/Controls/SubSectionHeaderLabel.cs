using System.Drawing;
using System.Windows.Forms;

namespace GymClassBooking.SpotMe.Controls
{
    public class SubSectionHeaderLabel : Label
    {
        public SubSectionHeaderLabel()
        {
            this.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.ForeColor = Color.Black;
            this.AutoSize = true;
            this.Padding = new Padding(0, 10, 0, 2);
        }
    }
}