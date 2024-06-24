using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Stall_Rental_Management_System.Helpers.DesignHelpers
{
    public static class PhoneNumberValidationHelper
    {
        public static void ValidateKeypress(TextBox textBox, KeyPressEventArgs e)
        {
            var regex = new Regex(@"^\d+$"); // Regular expression for digits only

            // Check if the pressed key is a digit and if the length is less than 20
            if (!char.IsControl(e.KeyChar) && (!regex.IsMatch(e.KeyChar.ToString()) || textBox.Text.Length >= 20))
            {
                e.Handled = true; // Suppress the event
            }
        }
        
        public static void ValidatePaste(TextBox textBox)
        {
            var regex = new Regex(@"[^\d]");
            textBox.Text = regex.Replace(textBox.Text, ""); // Remove non-digit characters

            // If the text length exceeds 20 characters, truncate it
            if (textBox.Text.Length > 20)
            {
                textBox.Text = textBox.Text.Substring(0, 20);
            }

            // Set the cursor to the end of the text
            textBox.SelectionStart = textBox.Text.Length;
        }
    }
}