// See https://aka.ms/new-console-template for more information
using System;

namespace RogerAtm
{
    


    public class Program
    {

        static void Deposit(CardHolder CurrentUser)
        {
            Console.WriteLine("How much money would you like to deposit?");
            double deposit = Double.Parse(Console.ReadLine());// 20.53 --> string --> double
            double currentBalance = CurrentUser.getBalance(); // get current balance of current  user
            double updatedBalance = currentBalance + deposit;
            CurrentUser.setBalance(updatedBalance);
            Console.WriteLine("Thank you " + CurrentUser.getFirstName() + " for banking with us.Your new balance: " + CurrentUser.getBalance());
        }// end of deposit method

        static void Withdraw(CardHolder CurrentUser)
        {
            Console.WriteLine("How much money would you like to withdraw");
            double Withdraw = Double.Parse(Console.ReadLine());
            if (CurrentUser.getBalance() < Withdraw)
            {
                Console.WriteLine("Insufficent funds;(");

            }
            else
            {
                CurrentUser.setBalance(CurrentUser.getBalance() - Withdraw);
                Console.WriteLine("Thank you "+ CurrentUser.getFirstName() +"for banking with us.Your new balance: " + CurrentUser.getBalance());
            }
        }// end of withdraw method



        public static void Main()
        {
            try
            {
                //start of main method
                List<CardHolder> cardHolders = new List<CardHolder>();
                cardHolders.Add(new CardHolder("4534278650056315", 1234, "John", "Carter", 180.50));
                cardHolders.Add(new CardHolder("4534278650056316", 4567, "Peter", "Alvin", 180.50));
                cardHolders.Add(new CardHolder("4534278650056317", 8910, "Mark", "Bruce", 180.50));
                cardHolders.Add(new CardHolder("4534278650056318", 1132, "Filly", "Brian", 180.50));
                cardHolders.Add(new CardHolder("4534278650056319", 1432, "Paul", "Corner", 180.50));
                cardHolders.Add(new CardHolder("4534278650056320", 1332, "Roger", "Jackson", 180.50));

                bool loginFlag = false; // keep track of login (button on/off) on --> logged in true ; off --> logged out fals----->>>>>>>> not false --> true   ;;;;; not true --> false
                CardHolder LoggedInUser = null; //
                while (true) //infinte loop 
                {
                    if (!loginFlag)
                    {
                        Console.WriteLine("Enter the FirstName and pin");
                        string currentUser = Console.ReadLine(); //Mark
                        int pin = Int32.Parse(Console.ReadLine()); //8910

                        foreach (CardHolder user in cardHolders)
                        {
                            if (pin == user.getPin() && currentUser == user.getFirstName())
                            {
                                loginFlag = true;
                                LoggedInUser = user; // "4534278650056317", 8910, "Mark", "Bruce", 180.50
                                break;
                            }
                        }
                    }


                    if (loginFlag)
                    {
                        Console.WriteLine("You are successfully Logged In!");
                        Console.WriteLine("Welcome to Rogers ATM");
                        Console.WriteLine("Please choose from the following options");
                        Console.WriteLine("1 Deposit");
                        Console.WriteLine("2 Withdraw ");
                        Console.WriteLine("3 show balance ");
                        Console.WriteLine("4 logout ");
                        Console.WriteLine("exit");

                        int option = Int32.Parse(Console.ReadLine()); // parse int value used Int32.Parse()

                        if (option == 1) { Deposit(LoggedInUser); }
                        else if (option == 2) { Withdraw(LoggedInUser); }
                        else if (option == 3) { Console.WriteLine("Your Current Balance is: "+LoggedInUser.getBalance()); }
                        else if (option == 5)
                        {
                            Console.WriteLine("Please select among listed options");
                        }
                        else if(option == 4) {
                            Console.WriteLine("You are Logged Out "+LoggedInUser.getFirstName() +", Thanks for banking with us!");
                            loginFlag = false;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please check either username or password is wrong ;(");
                    }
                }//end of while
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    } // end of Cardholder class. 
}

