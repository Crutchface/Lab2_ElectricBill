// Chris Ferguson - Rapid application development - Lab 2 - Nov 2024

using System.Security.Principal;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lab2_ElectricBill
{
    public partial class frmCustomerList : Form
    {   // Starts our list
        List<CustomerData> customers = new List<CustomerData>();
        public frmCustomerList()
        {
            InitializeComponent();
        }
        public decimal TAX_RATE = .07m;
        public decimal ADMIN_FEE = 12;


        private void frmCustomerList_Load(object sender, EventArgs e)
        {   // TESTING THE FORM
            //CustomerData test1 = new CustomerData("Steve", "Smith", 15);
            //CustomerData test2 = new CustomerData("Greg", "Plebb", 250);
            //customers.Add(test1);
            //customers.Add(test2);
            //foreach (CustomerData c in customers)
            //{
            //    lstCustomers.Items.Add(c);
            //}

        }
        // opens our second form frmaddcustomer when the add customer button is pressed 
        private void btnAddCust_Click(object sender, EventArgs e)
        {
            // Creates a new form as addcust 
            Form addCust = new frmAddCustomer();
            // shows the form created 
            DialogResult selectedButton = addCust.ShowDialog();
            // if the result of the frmaddcustomer comes back as OK 
            if (selectedButton == DialogResult.OK)
            {
                decimal bill = CalculateTotal(frmAddCustomer.kw);
                // creates a new customer using the constructor. Info is taken from stored strings on new cust form 
                CustomerData newcust = new CustomerData(frmAddCustomer.firstname, frmAddCustomer.lastname, frmAddCustomer.kw, bill);
                // adds the new customer to the customer list 
                customers.Add(newcust);
                // clears the item list 
                lstCustomers.Items.Clear();
                // repopulates form with new customers 
                foreach (CustomerData c in customers)
                {
                    // posts the user from list to the list 
                    lstCustomers.Items.Add(c);
                }
                // sets the textbox for the number of customers processed to the cust total 
                txtCustProcess.Text = newcust.TotalCustomers.ToString();
                // adds the total kw to the text box 
                txtKwh.Text = newcust.TotalKW.ToString();
                // calculates and places the avg bill vlue into the avg textbox  
                txtBillAvg.Text = (newcust.BillTotal / newcust.TotalCustomers).ToString("c");


            }





        }

        public decimal CalculateTotal(decimal kw)
        {
            decimal total = (kw * TAX_RATE) + ADMIN_FEE;
            return total;
        }

        private void btnShowDetails_Click(object sender, EventArgs e)
        {
            // Ensure an acount is selected 
            if (lstCustomers.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select an acount");
                lstCustomers.Focus();
            }
            // if an acount is selected 
            else
            {
                //Account account = lstAccounts.SelectedItem as Account;
                CustomerData customerSelected = customers[lstCustomers.SelectedIndex];
                txtFullName.Text = customerSelected.FirstName.ToString() + " " + customerSelected.LastName.ToString();
                txtKWHUsed.Text = customerSelected.KwhUsed.ToString();
                txtBill.Text = customerSelected.BillAmount.ToString("c");

            }
        }

       
    }
}
