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
        // states the rate of kwh
        private decimal KWHRate = .07m;
        // static decimal to be constantly iterated within the class
        private static decimal totalKW = 0;
        // starts our tally for customers served 
        private static int totalCustomers;
        // starts the customers bill total to be stored in object 
        private static decimal billTotal = 0;
        // states our admin fee to be charged on every bill
        private decimal adminFee = 12; 
        

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
        public decimal TotalKW
        {   // get for total kw 
            get
            {
                return totalKW;
            }
            // removed set to make the account number read only

        }
        // Total customer listing
        public int TotalCustomers
        {
            get
            {
                return totalCustomers;
            }
            // removed set to make the account number read only
        }
        // Can display bill total 
        public decimal BillTotal
        {
            get
            {
                return billTotal;
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
            // adds to the kwh total 
            totalKW += kwhUsed;
            // Increased the total customer list 
            totalCustomers++;
            // adds the bill to the bill total for averagin in the form 
            billTotal += billAmount;

        }

        // overrides our tostring to display
        public override string ToString() 
        {
            return $"Acct : {accountNo}, " +
                $" Name : {firstname.ToUpper()} " +
                $" {lastname.ToUpper()} ";
                //$" KW : {kwhUsed}";
                //$" Bill : {billAmount.ToString("c")}";
              
        }
    }
}
