namespace Lab2_ElectricBill
{
    public partial class frmCustomerList : Form
    {
        List<CustomerData> customers = new List<CustomerData>();
        public frmCustomerList()
        {
            InitializeComponent();
        }


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

        private void btnAddCust_Click(object sender, EventArgs e)
        {
            Form addCust = new frmAddCustomer( );
            DialogResult selectedButton = addCust.ShowDialog();

            if (selectedButton == DialogResult.OK)
            {
                CustomerData newcust = new CustomerData(frmAddCustomer.firstname, frmAddCustomer.lastname, frmAddCustomer.kw);
                customers.Add(newcust);
                lstCustomers.Items.Clear();
                foreach (CustomerData c in customers)
                {
                    lstCustomers.Items.Add(c);
                }
                txtCustProcess.Text = newcust.TotalCustomers.ToString();
                txtKwh.Text = newcust.TotalKW.ToString();
                txtBillAvg.Text = (newcust.BillTotal / newcust.TotalCustomers).ToString();
                

            }

          



        }

      
    }
}
