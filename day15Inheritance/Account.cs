using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day15Inheritance
{
    abstract class Account
    {
        // Fields
        protected string owner;
        protected string accntNum;
        protected decimal balance;               
        protected string accntType;


    //******************* Methods *************************

        // Constructor - Default
        public Account()
        {

        }

        // Constructor
        public Account(Client clientSelect, decimal balance)
        {
            this.owner = clientSelect.getName;
            this.balance = balance;
        }


        // Withdraw Method (Abstract)
        public abstract void Withdraw();

        // Deposit Method (Virtual)
        public virtual void Deposit()
        {
            Console.WriteLine(accntType + "\nAccount #: " + accntNum);
            Console.Write("Please enter deposit amount: ");
            decimal depositAmnt = decimal.Parse(Console.ReadLine());
            this.balance += depositAmnt;
            Console.WriteLine(string.Format("Updated balance: {0:C}", this.balance));
        }

        // Balance Inquiry Method
        public void getBalance()
        {
            Console.WriteLine(accntType + "\nAccount #: " + accntNum);
            Console.WriteLine(string.Format("Current balance: {0:C}", this.balance));
        }
       
    }
}
