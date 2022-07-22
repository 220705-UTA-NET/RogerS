// See https://aka.ms/new-console-template for more information
using System;

namespace RogerAtm
{
    public class Program
    {
        //Is temporary. You will replace this with your DB
        private static List<CardHolder> cardholderList = new List<CardHolder>();

        /*
        Structure of a METHOD:

        [access level] [static/dynamic modifier] [return modifier] function_name (parameters){
            content
            - access level: public, private, protected, internal
            - static/dynamic typing: is either static / "" (nothing)
            - return modifiers: var_type (requires you to return the associated variable with the correct type) or void (void means there is no return type)

        }
        */

        //Helper Methods DONT DO ANYTHING ON THEIR OWN. THEY MUST BE CALLED
        private static string getInput(string prompt){
            Console.WriteLine("Enter the " + prompt + " of your User");
            string? input = Console.ReadLine();
            return input;
        }

        private static void insertCH(){
            Console.Clear();
            string FirstName = getInput("First Name");
            string LastName = getInput("Last Name");
            string Username = getInput("Username");
            int cardNumber = int.Parse(getInput("Card Number"));
            int pin = int.Parse(getInput("Pin"));
            int balance = int.Parse(getInput("Balance"));

            CardHolder ch = new CardHolder(cardNumber, pin, Username, FirstName, LastName, balance);
            cardholderList.Add(ch);

        }

        //Main method is the default method called when we run the program ("dotnet run")
        public static void Main()
        {
            insertCH();
            CardHolder ch1 = new CardHolder(45678456, 1234, "jwong", "Jimmy", "Wong", 123456);
            cardholderList.Add(ch1);
            CardHolder ch2 = new CardHolder(56785768, 2345, "dxie", "Derick", "Xie", 23434);
            cardholderList.Add(ch2);
            CardHolder ch3 = new CardHolder(98457893, 3456, "aacalosa", "Annie", "Arayon-Calosa", 2345);
            cardholderList.Add(ch3);
            //Person previously created an account
            //access his information if his pin is correct
            Console.Clear();
            /*foreach(CardHolder c in cardholderList){
                c.returnAccDetails();
            }*/


            string login = getInput("Login");
            bool accountFound = false;

            foreach(CardHolder c in cardholderList){
                //if(login.Equals(c.Username)){
                    c.returnAccDetails();
                    accountFound = true;
                //}
            }
            if(!accountFound){
                Console.WriteLine("Your account does not exist!");
            }

            /*After we login, we want to CREATE A MENU WITH MENU OPTIONS for the user we logged into, and allow the user to make any changes
                - Deposit
                - Withdraw
                - Check Balance
                - Sign Out // for the Sign Out, see if you can sign out, return to menu, and then sign in to a new account.
            */
        

            /*try
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
            }*/

        /*
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
        */

        //int1: 3 int2:5
        //calculate returns 3*5 + 3*4 + 3*3 + 3*2 + 3*1 = 15+12+9+6+3 = 45
        }
    } // end of Cardholder class. 
}

