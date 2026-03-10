using System.Drawing;
using System.Windows.Forms;

namespace GymClassBooking.SpotMe.Controls
{
    public class CheckBoxWithText : CheckBox
    {
        public CheckBoxWithText()
        {
            this.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            this.ForeColor = Color.Black;
            this.AutoSize = true;
            this.Text = "Cancel";
        }
    }
}