using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day15Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            /**************************************************************************************************
             *                                                                                                *
             *************** MUST CHOOSE A NAME FROM THE FOLLOWING 'clientList' ARRAY *************************
             *                                                                                                *
             * ***********************************************************************************************/
            
            // Set Up User Array          
            string[,] clientList = new string[,]   {{ "Justin Reed", "724-344-8080", "jreed@gmail.com", "1234567", "2000", "7654321", "10000" },
                                                    { "Mary Goodge", "724-908-7087", "mgoodge@gmail.com", "1245679", "1000", "2356890", "5000"},
                                                    { "Lars Broberg", "724-344-5184", "lbroberg@gmail.com", "9865431", "1500", "2312563", "7000"},
                                                    { "Lebron James", "216-296-2345", "bronbron@ngmail.com", "7473921", "300000", "1212123", "5000000"},
                                                    { "Sherlock Holmes", "550-123-2575", "221b@bakerstreet.com", "7846533", "400", "4444333", "22000"},
                                                    { "Spike Spiegel", "111-222-3333", "viciousgonnagetit@gbebop.com", "8989898", "0", "0101010", "500"}};

            // Determine If User Log-in Is Legit
            int clientIndex = -1;
            while (clientIndex == -1)
            {
                Console.Write("Please enter a valid user name: ");
                string nameInput = Console.ReadLine();
                for (int i = 0; i < clientList.GetLength(0); i++)
                {
                    if (clientList[i, 0].ToLower() == nameInput.ToLower())
                    {
                        clientIndex = i;
                    }
                }
            }

            // Instantiate Proper Objects
            Client clientInst = new Client(clientList[clientIndex, 0], clientList[clientIndex, 1], clientList[clientIndex, 2], clientList[clientIndex, 3], clientList[clientIndex, 5]);
            SaveAccount clientInstSave = new SaveAccount(clientInst, decimal.Parse(clientList[clientIndex, 6]));
            CheckAccount clientInstCheck = new CheckAccount(clientInst, decimal.Parse(clientList[clientIndex, 4]));

            // Variables
            int menuSelect;

    //********* Main Menu Loop ***************
            do
            {
                // Main Menu  
                Console.Clear();
                Console.WriteLine("Hello " + clientList[clientIndex, 0] + "\n\n1. View Client Information \n2. View Account Balance" +
                                                            "\n3. Deposit Funds \n4. Withdraw Funds \n5. Exit");
                bool menuCheck = int.TryParse(Console.ReadLine(), out menuSelect);
                Console.WriteLine();

                switch (menuSelect)
                {
                    // Client Information
                    case 1:
                        Console.Clear();
                        clientInst.ClientInfoPrint();
                        FinishedPrompt();
                        Console.Clear();
                        break;

                    // Account Balance
                    case 2:
                        Console.Clear();
                        string accntType2 = AccountTypeSelect();
                        switch (accntType2)
                        {
                            // Checking Balance
                            case "1":
                                clientInstCheck.getBalance();
                                break;

                            // Savings Balance
                            case "2":
                                clientInstSave.getBalance();
                                break;

                            default:
                                Console.WriteLine("Please pick a valid option.  Back to main menu.");
                                break;
                        }
                        FinishedPrompt();
                        Console.Clear();
                        break;

                    // Deposit
                    case 3:
                        Console.Clear();
                        string accntType3 = AccountTypeSelect();
                        switch (accntType3)
                        {
                            // Checking Deposit
                            case "1":
                                clientInstCheck.Deposit();
                                break;

                            // Savings Deposit
                            case "2":
                                clientInstSave.Deposit();
                                break;

                            default:
                                Console.WriteLine("Please pick a valid option.  Back to main menu.");
                                break;
                        }
                        FinishedPrompt();
                        Console.Clear();
                        break;

                    // Withdraw
                    case 4:
                        Console.Clear();
                        string accntType4 = AccountTypeSelect();
                        switch (accntType4)
                        {
                            // Checking Withdrawal
                            case "1":
                                clientInstCheck.Withdraw();
                                break;

                            // Savings Withdrawal
                            case "2":
                                clientInstSave.Withdraw();
                                break;

                            default:
                                Console.WriteLine("Please pick a valid option.  Back to main menu.  ");
                                break;
                        }
                        FinishedPrompt();
                        Console.Clear();
                        break;

                    // Exit
                    case 5:
                        Console.WriteLine("Thank you and have a nice day.");
                        break;

                    // Main Menu Catch
                    default:
                        Console.WriteLine("Select a valid option");
                        break;
                }

            } while (menuSelect != 5);
        }

        
    //**************** Main Menu Navigation Methods *******************

        //Checking or Savings Account Selector 
        static string AccountTypeSelect()
        {
            Console.WriteLine("Please select account type: \n1. Checking\n2. Savings");
            string typeSelection = Console.ReadLine();
            Console.WriteLine();
            return typeSelection;
        }

        // Finished with Screen Prompt
        static void FinishedPrompt()
        {
            Console.WriteLine();
            Console.WriteLine("Please press enter to continue");
            string totsDoesntMatter = Console.ReadLine();
            Console.WriteLine();
        }


    }
}

