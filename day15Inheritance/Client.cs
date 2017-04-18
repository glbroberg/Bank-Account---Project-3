using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day15Inheritance
{
    class Client
    {
        // Fields
        private string name;
        private string phoneNum;
        private string email;
        private string checkAccntNum;
        private string saveAccntNum;

        // Constructor
        public Client(string name, string phoneNum, string email, string checkAccntNum, string saveAccntNum)
        {
            this.name = name;            
            this.phoneNum = phoneNum;
            this.email = email;
            this.checkAccntNum = checkAccntNum;
            this.saveAccntNum = saveAccntNum;
        }

    //************** Properties *****************

        // Name Property
        public string getName
        {
            get { return this.name; }
        }

        // Checking Account Property
        public string getCheckAccntNum
        {
            get { return this.checkAccntNum; }
        }

        // Savings Account Prperty
        public string getSaveAccntNum
        {
            get { return this.saveAccntNum; }
        }


    //************** Methods ********************

        // Print Client Info Method 
        public void ClientInfoPrint()
        {
            Console.WriteLine("Name: "+name+"\nPhone Number: "+phoneNum+"\nEmail Address: "+email+
                "\nChecking Account Number: "+checkAccntNum+ "\nSavings Account Number: "+saveAccntNum);
            return;
        }


    }
}
