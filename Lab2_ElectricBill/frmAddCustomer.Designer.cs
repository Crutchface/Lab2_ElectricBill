namespace Lab2_ElectricBill
{
    partial class frmAddCustomer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAddCustomer = new Button();
            btnCancel = new Button();
            lblFnameAdd = new Label();
            lblLnameAdd = new Label();
            txtCustFName = new TextBox();
            txtCustLName = new TextBox();
            txtKWHused = new TextBox();
            lblKwhUsed = new Label();
            SuspendLayout();
            // 
            // btnAddCustomer
            // 
            btnAddCustomer.Location = new Point(12, 147);
            btnAddCustomer.Name = "btnAddCustomer";
            btnAddCustomer.Size = new Size(147, 29);
            btnAddCustomer.TabIndex = 0;
            btnAddCustomer.Text = "Add Customer";
            btnAddCustomer.UseVisualStyleBackColor = true;
            btnAddCustomer.Click += btnAddCustomer_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(177, 147);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(125, 29);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblFnameAdd
            // 
            lblFnameAdd.AutoSize = true;
            lblFnameAdd.Location = new Point(12, 25);
            lblFnameAdd.Name = "lblFnameAdd";
            lblFnameAdd.Size = new Size(147, 20);
            lblFnameAdd.TabIndex = 2;
            lblFnameAdd.Text = "Customer First Name";
            // 
            // lblLnameAdd
            // 
            lblLnameAdd.AutoSize = true;
            lblLnameAdd.Location = new Point(12, 67);
            lblLnameAdd.Name = "lblLnameAdd";
            lblLnameAdd.Size = new Size(146, 20);
            lblLnameAdd.TabIndex = 3;
            lblLnameAdd.Text = "Customer Last Name";
            // 
            // txtCustFName
            // 
            txtCustFName.Location = new Point(177, 22);
            txtCustFName.Name = "txtCustFName";
            txtCustFName.Size = new Size(125, 27);
            txtCustFName.TabIndex = 4;
            // 
            // txtCustLName
            // 
            txtCustLName.Location = new Point(177, 64);
            txtCustLName.Name = "txtCustLName";
            txtCustLName.Size = new Size(125, 27);
            txtCustLName.TabIndex = 5;
            // 
            // txtKWHused
            // 
            txtKWHused.Location = new Point(177, 104);
            txtKWHused.Name = "txtKWHused";
            txtKWHused.Size = new Size(125, 27);
            txtKWHused.TabIndex = 6;
            // 
            // lblKwhUsed
            // 
            lblKwhUsed.AutoSize = true;
            lblKwhUsed.Location = new Point(12, 104);
            lblKwhUsed.Name = "lblKwhUsed";
            lblKwhUsed.Size = new Size(69, 20);
            lblKwhUsed.TabIndex = 7;
            lblKwhUsed.Text = "KW Used";
            // 
            // frmAddCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 203);
            Controls.Add(lblKwhUsed);
            Controls.Add(txtKWHused);
            Controls.Add(txtCustLName);
            Controls.Add(txtCustFName);
            Controls.Add(lblLnameAdd);
            Controls.Add(lblFnameAdd);
            Controls.Add(btnCancel);
            Controls.Add(btnAddCustomer);
            Name = "frmAddCustomer";
            Text = "Add New Customer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddCustomer;
        private Button btnCancel;
        private Label lblFnameAdd;
        private Label lblLnameAdd;
        private Label lblKwhUsed;
        public TextBox txtCustFName;
        public TextBox txtCustLName;
        public TextBox txtKWHused;
    }
}