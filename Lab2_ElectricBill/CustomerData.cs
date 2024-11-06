// Chris Ferguson - Rapid application development - Lab 2 - Nov 2024

using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lab2_ElectricBill
{   // Setting up our class 
    public class CustomerData
    {
    
        // Our account number to be incremented
        private int accountNo;
        //Instatntiates the string and Gets and sets for our first name 
        private string firstname; 
        //Instatntiates the string and Gets and sets for our last name 
        private string lastname;
        //Instatntiates the string and Gets and sets for our kwh 
        private decimal kwhUsed; 
        // Initiates the full tally of the bill totals
        private  decimal billAmount ;
        // Public static to be incremented starting at 100
        public static int nextAcct = 100;



        // Getters and setters 
        // Making these read only for testing purposes 
        public string FirstName
        {
            get 
            {
                return firstname;
            }
            // removed set to make the account number read only

        }
        public string LastName
        {
            get
            {
                return lastname;
            }
            // removed set to make the account number read only

        }
        public decimal KwhUsed
        {
            get
            {
                return kwhUsed;
            }
            // removed set to make the account number read only

        }

        public int AccountNo
        {   
            // Get for acctNo
            get
            {
                return accountNo;
            }
            // removed set to make the account number read only
        }
      
        public decimal BillAmount
        {
            get
            {
                return billAmount;
            }
            // removed set to make the account number read only
        }

        // Constructor for customers! Takes in first, last name and the used KWh
        public CustomerData(string fName, string lName, decimal kwh, decimal bill)
        {   
            // sets account number to the next acct and increments 1
            accountNo = nextAcct++;
            // sets the first name and trim extra space
            firstname = fName.Trim();
            // Sets the last name and trims spaces 
            lastname = lName.Trim();
            // sets the kwh used 
            kwhUsed = kwh;
            // calculates and store the bill ammt with admin fee 
            billAmount = bill;
         

        }
        public static decimal CalculateTotal(decimal kw, decimal TAX_RATE, decimal ADMIN_FEE)
        {   // Calculates with stated values for appropriate rates and fees
            decimal total = (kw * TAX_RATE) + ADMIN_FEE;
            //returns the total as a decimal
            return total;
        }

        // overrides our tostring to display
        public override string ToString() 
        {
            return $"Acct : {accountNo}, " +
                $" Name : {firstname.ToUpper()} " +
                $" {lastname.ToUpper()} ";
               
              
        }
    }
}
