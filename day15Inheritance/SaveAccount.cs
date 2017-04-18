using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day15Inheritance
{
    class SaveAccount : Account
    {
        // Variables
        protected decimal minBal = 500M;
    
    
    //*************** Methods *****************************
        
        // Constructor
        public SaveAccount(Client clientSelect, decimal balance)
        {
            this.owner = clientSelect.getName;
            this.accntType = "Savings Account";
            this.accntNum = clientSelect.getSaveAccntNum;
            this.balance = balance;
        }

        // Savings Withdrawal Method (Account Abstract)
        public override void Withdraw()
        {
            Console.WriteLine(accntType + "\nAccount #: " + accntNum + "\n");
            Console.WriteLine("** This account must maintain a minumum balance of "+ string.Format("{0:C}",minBal) + " **\n");
            Console.Write("Please enter withdrawal amount: ");
            decimal withAmnt = decimal.Parse(Console.ReadLine());
  
            if (minBal <= this.balance - withAmnt)
            {
                this.balance -= withAmnt;
            }

            else
            {
                Console.WriteLine("Error: Minum Balance Exception");
            }

            Console.WriteLine(string.Format("Remaining balance: {0:C}", this.balance));
        }

        // Savings Deposit Method (Account Virtual)
        public override void Deposit()
        {
            
            base.Deposit();
            Console.WriteLine("** This account must maintain a minumum balance of $"+minBal+" **");

        }


    //***************** Properties *******************************

        // Savings Balance Property
        public decimal getSaveBalance
        {
            get { return this.balance; }
        }
    }
}
