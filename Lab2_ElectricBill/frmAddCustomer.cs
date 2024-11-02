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
{   // Creates 
    public partial class frmAddCustomer : Form
    {
 
        public frmAddCustomer()
        {
            InitializeComponent();

        }
        public static string firstname = "na";
        public static string lastname = "na";
        public static decimal kw;


        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                firstname = txtCustFName.Text;
                lastname = txtCustLName.Text;
                kw = Convert.ToDecimal(txtKWHused.Text);
                this.DialogResult = DialogResult.OK;
            }
            
            


    }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool IsValidData()
        {
            bool success = true;
            string errorMessage = "";
            if (string.IsNullOrWhiteSpace(txtCustFName.Text))
            {
                errorMessage += "You must enter a First Name.\n";
                success = false;
            }
            if (string.IsNullOrWhiteSpace(txtCustLName.Text))
            {
                errorMessage += "You must enter a Last Name.\n";
                success = false;
            }
            if (txtCustFName.Text.Any(char.IsDigit) || !Regex.IsMatch(txtCustFName.Text, @"^[a-zA-Z\s]+$"))
            {
                errorMessage += "You must enter a First Name without Numbers or Special Characters.\n";
                success = false;
            }
            if (txtCustLName.Text.Any(char.IsDigit) || !Regex.IsMatch(txtCustLName.Text, @"^[a-zA-Z\s]+$"))
            {
                errorMessage += "You must enter a Last Name without Numbers or Special Characters .\n";
                success = false;
            }
            if (string.IsNullOrWhiteSpace(txtKWHused.Text))
            {
                errorMessage += "You must enter kWh usage. \n";
                success = false;
            }
            if (!Regex.IsMatch(txtKWHused.Text, @"^\d+$"))
            {
                errorMessage += "You must enter numbers only for KW. \n";
                success = false;
            }

            if (errorMessage != "")
            {
                success = false;
                MessageBox.Show(errorMessage, "Entry Error");
            }

            return success;
        }
    }
}
