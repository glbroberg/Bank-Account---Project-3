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
            Client clientInst = new Client("justin reed", "724-942-4858", "judge@gmail.com", "1234567", "7654321");
            SaveAccount clientInstSave = new SaveAccount(clientInst, 10000);
            CheckAccount clientInstCheck = new CheckAccount(clientInst, 5000);
         
            // Variables
            int menuSelect;
            
            // Introduction
            //Console.WriteLine("Please enter your name: ");
            //string accountName = Console.ReadLine();
            //Console.Clear();

            // Main Menu Loop
            do
            {
                // Main Menu                   
                Console.WriteLine("Hello +accountName"+"\n\n1. View Client Information \n2. View Account Balance"+ 
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
                                Console.WriteLine("Please pick a valid option.  Back to main menu.");
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

            } while (menuSelect != 5) ;
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

