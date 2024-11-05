namespace Lab2_ElectricBill
{
    partial class frmCustomerList
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lstCustomers = new ListBox();
            lblListBoxCust = new Label();
            btnAddCust = new Button();
            grpDetails = new GroupBox();
            txtBillAvg = new TextBox();
            lblAvg = new Label();
            txtKwh = new TextBox();
            lblkwh = new Label();
            txtCustProcess = new TextBox();
            lblCustTally = new Label();
            btnShowDetails = new Button();
            grpCustDetails = new GroupBox();
            txtKWHUsed = new TextBox();
            txtFullName = new TextBox();
            lblKWHUsed = new Label();
            label1 = new Label();
            txtBill = new TextBox();
            lblBill = new Label();
            lblOosdPower = new Label();
            grpDetails.SuspendLayout();
            grpCustDetails.SuspendLayout();
            SuspendLayout();
            // 
            // lstCustomers
            // 
            lstCustomers.BackColor = Color.White;
            lstCustomers.FormattingEnabled = true;
            lstCustomers.Location = new Point(24, 55);
            lstCustomers.Name = "lstCustomers";
            lstCustomers.Size = new Size(376, 224);
            lstCustomers.TabIndex = 0;
            // 
            // lblListBoxCust
            // 
            lblListBoxCust.AutoSize = true;
            lblListBoxCust.Location = new Point(24, 19);
            lblListBoxCust.Name = "lblListBoxCust";
            lblListBoxCust.Size = new Size(98, 20);
            lblListBoxCust.TabIndex = 1;
            lblListBoxCust.Text = "Customer List";
            // 
            // btnAddCust
            // 
            btnAddCust.Location = new Point(24, 285);
            btnAddCust.Name = "btnAddCust";
            btnAddCust.Size = new Size(285, 43);
            btnAddCust.TabIndex = 2;
            btnAddCust.Text = "Add Customer";
            btnAddCust.UseVisualStyleBackColor = true;
            btnAddCust.Click += btnAddCust_Click;
            // 
            // grpDetails
            // 
            grpDetails.Controls.Add(txtBillAvg);
            grpDetails.Controls.Add(lblAvg);
            grpDetails.Controls.Add(txtKwh);
            grpDetails.Controls.Add(lblkwh);
            grpDetails.Controls.Add(txtCustProcess);
            grpDetails.Controls.Add(lblCustTally);
            grpDetails.Location = new Point(24, 343);
            grpDetails.Name = "grpDetails";
            grpDetails.Size = new Size(285, 141);
            grpDetails.TabIndex = 3;
            grpDetails.TabStop = false;
            grpDetails.Text = "Details ";
            // 
            // txtBillAvg
            // 
            txtBillAvg.Location = new Point(204, 103);
            txtBillAvg.Name = "txtBillAvg";
            txtBillAvg.ReadOnly = true;
            txtBillAvg.Size = new Size(75, 27);
            txtBillAvg.TabIndex = 5;
            // 
            // lblAvg
            // 
            lblAvg.AutoSize = true;
            lblAvg.Location = new Point(6, 106);
            lblAvg.Name = "lblAvg";
            lblAvg.Size = new Size(89, 20);
            lblAvg.TabIndex = 4;
            lblAvg.Text = "Bill Average";
            // 
            // txtKwh
            // 
            txtKwh.Location = new Point(204, 70);
            txtKwh.Name = "txtKwh";
            txtKwh.ReadOnly = true;
            txtKwh.Size = new Size(75, 27);
            txtKwh.TabIndex = 3;
            // 
            // lblkwh
            // 
            lblkwh.AutoSize = true;
            lblkwh.Location = new Point(6, 73);
            lblkwh.Name = "lblkwh";
            lblkwh.Size = new Size(75, 20);
            lblkwh.TabIndex = 2;
            lblkwh.Text = "kWh Total";
            // 
            // txtCustProcess
            // 
            txtCustProcess.Location = new Point(204, 37);
            txtCustProcess.Name = "txtCustProcess";
            txtCustProcess.ReadOnly = true;
            txtCustProcess.Size = new Size(75, 27);
            txtCustProcess.TabIndex = 1;
            // 
            // lblCustTally
            // 
            lblCustTally.AutoSize = true;
            lblCustTally.Location = new Point(6, 40);
            lblCustTally.Name = "lblCustTally";
            lblCustTally.Size = new Size(152, 20);
            lblCustTally.TabIndex = 0;
            lblCustTally.Text = "Customers Processed ";
            // 
            // btnShowDetails
            // 
            btnShowDetails.Location = new Point(442, 285);
            btnShowDetails.Name = "btnShowDetails";
            btnShowDetails.Size = new Size(285, 43);
            btnShowDetails.TabIndex = 4;
            btnShowDetails.Text = "Show Bill";
            btnShowDetails.UseVisualStyleBackColor = true;
            btnShowDetails.Click += btnShowDetails_Click;
            // 
            // grpCustDetails
            // 
            grpCustDetails.Controls.Add(txtKWHUsed);
            grpCustDetails.Controls.Add(txtFullName);
            grpCustDetails.Controls.Add(lblKWHUsed);
            grpCustDetails.Controls.Add(label1);
            grpCustDetails.Controls.Add(txtBill);
            grpCustDetails.Controls.Add(lblBill);
            grpCustDetails.Location = new Point(442, 55);
            grpCustDetails.Name = "grpCustDetails";
            grpCustDetails.Size = new Size(279, 224);
            grpCustDetails.TabIndex = 5;
            grpCustDetails.TabStop = false;
            grpCustDetails.Text = "Customer Details";
            // 
            // txtKWHUsed
            // 
            txtKWHUsed.Location = new Point(148, 101);
            txtKWHUsed.Name = "txtKWHUsed";
            txtKWHUsed.ReadOnly = true;
            txtKWHUsed.Size = new Size(125, 27);
            txtKWHUsed.TabIndex = 5;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(148, 47);
            txtFullName.Name = "txtFullName";
            txtFullName.ReadOnly = true;
            txtFullName.Size = new Size(125, 27);
            txtFullName.TabIndex = 4;
            // 
            // lblKWHUsed
            // 
            lblKWHUsed.AutoSize = true;
            lblKWHUsed.Location = new Point(8, 104);
            lblKWHUsed.Name = "lblKWHUsed";
            lblKWHUsed.Size = new Size(83, 20);
            lblKWHUsed.TabIndex = 3;
            lblKWHUsed.Text = "KWH Used:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 50);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 2;
            label1.Text = "Name:";
            // 
            // txtBill
            // 
            txtBill.Location = new Point(148, 152);
            txtBill.Name = "txtBill";
            txtBill.ReadOnly = true;
            txtBill.Size = new Size(125, 27);
            txtBill.TabIndex = 1;
            // 
            // lblBill
            // 
            lblBill.AutoSize = true;
            lblBill.Location = new Point(8, 159);
            lblBill.Name = "lblBill";
            lblBill.Size = new Size(37, 20);
            lblBill.TabIndex = 0;
            lblBill.Text = "Bill: ";
            // 
            // lblOosdPower
            // 
            lblOosdPower.AutoSize = true;
            lblOosdPower.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOosdPower.ForeColor = Color.Green;
            lblOosdPower.Location = new Point(320, 430);
            lblOosdPower.Name = "lblOosdPower";
            lblOosdPower.Size = new Size(430, 54);
            lblOosdPower.TabIndex = 6;
            lblOosdPower.Text = "OOSD Power Company";
            // 
            // frmCustomerList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(762, 515);
            Controls.Add(lblOosdPower);
            Controls.Add(grpCustDetails);
            Controls.Add(btnShowDetails);
            Controls.Add(grpDetails);
            Controls.Add(btnAddCust);
            Controls.Add(lblListBoxCust);
            Controls.Add(lstCustomers);
            Name = "frmCustomerList";
            Text = "Electric Bill";
            Load += frmCustomerList_Load;
            grpDetails.ResumeLayout(false);
            grpDetails.PerformLayout();
            grpCustDetails.ResumeLayout(false);
            grpCustDetails.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstCustomers;
        private Label lblListBoxCust;
        private Button btnAddCust;
        private GroupBox grpDetails;
        private TextBox txtCustProcess;
        private Label lblCustTally;
        private TextBox txtKwh;
        private Label lblkwh;
        private TextBox txtBillAvg;
        private Label lblAvg;
        private Button btnShowDetails;
        private GroupBox grpCustDetails;
        private Label lblBill;
        private TextBox txtBill;
        private Label label1;
        private Label lblKWHUsed;
        private TextBox txtKWHUsed;
        private TextBox txtFullName;
        private Label lblOosdPower;
    }
}
