using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_ElectricBill
{
    public static class ValidatorFn1
    {   /// <summary>
        ///  Tests if there is any input from the user
        /// </summary>
        /// <param name="textbox"> Name of the textbox we are validating</param>
        /// <returns>true if it has content false if its empty</returns>
        public static bool IsPresent(TextBox textbox)
        {
            bool isValid = true;
            if (textbox.Text == "") // Checks if there is any info in the box
            {
                isValid = false;
                MessageBox.Show($"{textbox.Tag} field is Empty");
                // Places the cursor on the problematic text box
                textbox.Focus();
            }
            return isValid;
        }


        public static bool IsDouble(TextBox textbox)
        {
            bool isValid = true;
            //double output;
            // Tries to parse or connvert the input textbox to decimal
            if (!Double.TryParse(textbox.Text, out double output))
            {
                isValid = false;
                MessageBox.Show($"{textbox.Tag} field contains non numeric characters ");
                textbox.SelectAll();
                textbox.Focus();
            }

            return isValid;
        }

        public static bool IsInRange(TextBox textbox)
        {
            bool isValid = true;
            if (Convert.ToInt32(textbox.Text) < 0 || Convert.ToInt32(textbox.Text) >12)
            {
                isValid = false;
                MessageBox.Show($"{textbox.Tag} must be between 0 and 12");
                textbox.SelectAll();
                textbox.Focus();


            }
            return isValid;
        }

        public static bool IsNonNegative(TextBox textBox)

        {

            bool isValid = true;
            //double output
            //tries to parse or convert text box input to decimal
            if (!double.TryParse(textBox.Text, out double output))
            {

                isValid = false;

                MessageBox.Show($"{textBox.Tag} Field contains non-numeric characters");

                textBox.SelectAll();

                textBox.Focus();

            }

            else if (output < 0)

            {

                isValid = false;

                MessageBox.Show($"{textBox.Tag} Field must be a non-negative number");

                textBox.SelectAll();

                textBox.Focus();

            }

            return isValid;



        }

        public static bool IsNonNegativeDouble(TextBox textbox)
        {
            bool isValid = true;
            if (!Double.TryParse(textbox.Text, out double output))
            {
                isValid = false;
                MessageBox.Show($"{textbox.Tag} must be between 0 and 12");
                textbox.SelectAll();
                textbox.Focus();


            }
            else if (output < 0)
            {
                isValid = false;
                MessageBox.Show($"{textbox.Tag} must be over 0");
                textbox.SelectAll();
                textbox.Focus();
            }
            return isValid;

        }
        public static bool IsDoubleInRange(TextBox textbox, double min, double max)
        {
            bool isValid = true;
            //double output;
            // Tries to parse or connvert the input textbox to decimal
            if (!Double.TryParse(textbox.Text, out double output))
            {
                isValid = false;
                MessageBox.Show($"{textbox.Tag} field contains non numeric characters ");
                textbox.SelectAll();
                textbox.Focus();
            }
            else if (output < min || output > max)
            {
                isValid = false;
                MessageBox.Show($"{textbox.Tag} field shoule be withing range of {min} and {max} ");
                textbox.SelectAll();
                textbox.Focus();
            }

            return isValid;
        }
    }
}
