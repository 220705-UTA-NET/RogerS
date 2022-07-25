namespace ATM
{
    public class Program
    {
        public static List<CardHolder> cardHolders = new List<CardHolder>();
        /*
        Created our method: Main. Program.cs searches for Main when you type "dotnet run"
            - public denotes that the method can be accessed anywhere in our namespace "ATM"
            - static denotes that there is only going to be one copy of Main() inside our entire file
                - enforces that any variables/fields we create in Main() is static as well
            - void denotes a "void" or no return return type
            - Main is our call to our Main function, which accepts no parameters
        */
        public static void Main()
        {
                                // CardHolder(string fn, string ln, string u, int p)
            CardHolder lance = new CardHolder("Lance", "Gong", "lagong", 1234);
            cardHolders.Add(lance); //This is your database
            CardHolder roger = new CardHolder("Roger", "Ssozi", "rssozi", 0000);
            cardHolders.Add(roger);
            CardHolder derick = new CardHolder("Derick", "Xie", "dxie", 0000);
            cardHolders.Add(derick);
            loginMenu();

        }
        //Helper Method to display login
        private static void loginMenu()
        {
            /*Login
                User: someusername
                Pin: somepin
            */
            Console.Clear();
            Console.WriteLine("===LOGIN===");
            string user = getInput("User: ");
            foreach (var cardHolder in cardHolders)
            {   
                //check that whatever CardHolder ch has an Username user
                if(cardHolder.Username == user)
                {
                    //Challenge: Give them a limited number of tries to get their password to correct
                    bool passCorrect = false; 
                    while(!passCorrect)
                    {
                        int pin = int.Parse(getInput("Pin: "));
                        if(cardHolder.checkPin(pin))
                        {
                            passCorrect = true;
                            Console.WriteLine("Pin was Correct");
                            //gives access to Account Menu
                            Console.Clear();
                            accountMenu(cardHolder);
                            return;
                        }
                        else
                        {
                            Console.WriteLine("Pin was Incorrect");
                        }
                    }
                }
            }
            Console.WriteLine(  user + " not Found\n" +
                                "Would you like to create an account?\n" +
                                "Press ENTER to create");
            string temporary = Console.ReadLine();
            if(temporary == "") // User pressed ENTER
            {
                createCardHolder();
            }
            else
            {
                Console.WriteLine("Have a nice day!");
            }
        }

        //Helper Method that displays account options
        private static void accountMenu(CardHolder LoggedInUser)
        {
            Console.WriteLine(  "===ACCOUNT MENU===\n" + 
                                "1. Deposit\n" + 
                                "2. Withdraw\n" + 
                                "3. Check Balance\n" + 
                                "4. Log Out"
                                /*"4. Send Money\n" + 
                                "5. Request Money\n" + 
                                "6. Check Requests\n" +
                                "7. Log Out"*/);
            string input = Console.ReadLine();
            switch(input)
            {
                case "1":
                    LoggedInUser.Deposit();
                    accountMenu(LoggedInUser);
                    break;
                case "2":
                    LoggedInUser.Withdraw();
                    accountMenu(LoggedInUser);
                    break;
                case "3":
                    LoggedInUser.checkBalance();
                    accountMenu(LoggedInUser);
                    break;
                /*case "4":
                    LoggedInUser.sendMoney();
                    accountMenu(LoggedInUser);
                    break;
                case "5":
                    LoggedInUser.requestMoney();
                    accountMenu(LoggedInUser);
                    break;
                case "6":
                    LoggedInUser.checkRequests();
                    accountMenu(LoggedInUser);
                    break;
                case "7":
                    loginMenu();
                    break;*/
                case "4":
                    loginMenu();
                    break;
                default:
                    Console.WriteLine("Invalid input, please select among our menu options");
                    accountMenu(LoggedInUser);
                    break;
            }
        }

        //Helper Method that allows us to ask for the user inputs to create a new CardHolder
        private static void createCardHolder()
        {
            Console.Clear();
            Console.WriteLine("===CREATE NEW ACCOUNT===");
            string FirstName = getInput("First Name: ");
            string LastName = getInput("Last Name: ");
            string Username = getInput("Username: ");
            int Pin = int.Parse(getInput("Pin: "));
            CardHolder ch = new CardHolder(FirstName, LastName, Username, Pin);
            cardHolders.Add(ch);
            loginMenu();
        }

        //Helper Method to get the input from the user
        public static string getInput(string prompt)
        {
            Console.Write(prompt);
            string input = Console.ReadLine();
            return input;
        }

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
            }*/
       
    }
}
