using System.Drawing;
using System.Windows.Forms;

namespace GymClassBooking.SpotMe.Controls
{
    public class HintLabel : Label
    {
        public HintLabel()
        {
            this.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            this.ForeColor = Color.Gray;
            this.AutoSize = true;
            this.Padding = new Padding(0, 2, 0, 5);
        }
    }
}