using System.Windows.Forms;

namespace Stall_Rental_Management_System.Helpers.DesignHelpers
{
    public static class FloatOrDecimalValidationHelper
    {
        public static void KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the key pressed is a control key (like backspace) or a digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // Check if the decimal point already exists
            if ((e.KeyChar == '.') && (((TextBox)sender).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}