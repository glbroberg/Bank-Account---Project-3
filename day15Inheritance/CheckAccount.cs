using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day15Inheritance
{
    class CheckAccount : Account
    {    

        public CheckAccount(Client clientSelect, decimal balance)
        {
            this.owner = clientSelect.getName;
            this.accntType = "Checking Account";
            this.accntNum = clientSelect.getCheckAccntNum;
            this.balance = balance;
        }


    //*************** Methods *****************************

        // Checking Withdrawal Method
        public override void Withdraw()
        {
            Console.WriteLine(accntType + "\nAccount #: " + accntNum + "\n");
            Console.Write("Please enter withdrawal amount: ");
            decimal withAmnt = decimal.Parse(Console.ReadLine());

            if (balance >= withAmnt)
            {
                this.balance -= withAmnt;
            }

            else
            {
                Console.WriteLine("Error: Insufficient Funds");
            }

            Console.WriteLine(string.Format("Remaining balance: {0:C}", this.balance));
        }

        // Checking Deposit Method
        public override void Deposit()
        {           
            base.Deposit();
        }


    //***************** Properties *******************************

        // Checking Balance Property
        public decimal getCheckBalance
        {
            get { return this.balance; }
        }



    }
}
