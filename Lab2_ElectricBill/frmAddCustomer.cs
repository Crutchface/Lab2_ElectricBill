// Chris Ferguson - Rapid application development - Lab 2 - Nov 2024

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;


namespace Lab2_ElectricBill
{   // Creates the form 
    public partial class frmAddCustomer : Form
    {   
        //Creates a new form from main form 
        public frmAddCustomer()
        {
            InitializeComponent();

        }

        // initialize public static strings to grab via form 1 to add to class and update list. Acts as storage 
        public static string firstname = "";
        public static string lastname = "";
        public static decimal kw;

        // Adds a fucntion for our add customer button click 
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {   // performs our entry form validation 
            if (IsValidData())
            {   // if its valid do this and store the text forms in a string 
                firstname = txtCustFName.Text;
                lastname = txtCustLName.Text;
                // converts our form entry to a stored decimal 
                kw = Convert.ToDecimal(txtKWHused.Text);
                // returns the result from the window back to form 1 to add customer and update list 
                this.DialogResult = DialogResult.OK;
            }
    }
        // adds a function to our cancel button 
        private void btnCancel_Click(object sender, EventArgs e)
        {   // closes the window without doing anything
            this.Close();   
        }
        // Function for our form validation 
        private bool IsValidData()
        {   // sets a default status of true 
            bool success = true;
            // starts storage of our error messge popup
            string errorMessage = "";
            // makes sure the first name isnt empty 
            if (string.IsNullOrWhiteSpace(txtCustFName.Text))
            {   
                // adds to our message and changes success bool to false 
                errorMessage += "You must enter a First Name.\n";
                success = false;
            }
            // Make sure last name isnt empty 
            if (string.IsNullOrWhiteSpace(txtCustLName.Text))
            {
                // adds to our message and changes success bool to false 
                errorMessage += "You must enter a Last Name.\n";
                success = false;
            }
            // makes sure that the name doesnt contain numbers or special characters 
            if (txtCustFName.Text.Any(char.IsDigit) || !Regex.IsMatch(txtCustFName.Text, @"^[a-zA-Z\s]+$"))
            {
                // adds to our message and changes success bool to false 
                errorMessage += "You must enter a First Name without Numbers or Special Characters.\n";
                success = false;
            }
            // makes sure that the name doesnt contain numbers or special characters 
            if (txtCustLName.Text.Any(char.IsDigit) || !Regex.IsMatch(txtCustLName.Text, @"^[a-zA-Z\s]+$"))
            {
                // adds to our message and changes success bool to false 
                errorMessage += "You must enter a Last Name without Numbers or Special Characters .\n";
                success = false;
            }
            // makes sure kwh isnt blank 
            if (string.IsNullOrWhiteSpace(txtKWHused.Text))
            {
                // adds to our message and changes success bool to false 
                errorMessage += "You must enter kWh usage. \n";
                success = false;
            }
            // checks for any letters etc 
            if (!Regex.IsMatch(txtKWHused.Text, @"^\d+$"))
            {
                // adds to our message and changes success bool to false 
                errorMessage += "You must enter numbers only for KW. \n";
                success = false;
            }
            // shows are error message if our string doesnt remain blank 
            if (errorMessage != "")
            {   
                // sets success to false and pops up msg box 
                success = false;

                MessageBox.Show(errorMessage, "Entry Error");
                
            }
            // returns our final success result 
            return success;
        }
    }
}
