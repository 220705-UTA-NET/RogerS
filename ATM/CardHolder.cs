namespace ATM
{
    public class CardHolder // This is our instance of our Object
    {
        /*
        We need Fields of data to store and manipulate for our Constructor and Methods
            - Cardholder : Name (first and last), Username, Pin, Balance, List<Requests>
        */
        public static int id = 1; //static variables are consistent throughout our code
        public int cardHolderID; //This is our CardHolder's unique ID to store the current value of our static id
        public string FirstName;
        public string LastName;
        public string Username { get; }
        private int Pin; //Optional Challenge: Force the Pin to be 4 numbers long
        public double Balance {get; set;}
        public List<Request> RequestList;
        /*
        Constructors are special. THEY HAVE TO HAVE THE SAME NAME AS YOUR CLASS
            - They do not have static/return typing
            - Constructors are implicitly dynamic, thus cannot be static
            - Constructors are not a method, so will never return anything by default
            - Essentially, Constructors don't "do" things. They are just a way to put data into your object.
        */
        public CardHolder(string FirstName, string LastName, string Username, int Pin)
        {
            //Console.WriteLine("Before CardHolder is: " + this.FirstName + " " + this.LastName);
            this.cardHolderID = id;
            id++;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Username = Username;
            this.Pin = Pin;
            this.Balance = 0;
            //Console.WriteLine("Created new CardHolder: " + this.FirstName + " " + this.LastName + " with ID: " + this.cardHolderID);
        }

        /*
        Methods CANNOT HAVE THE SAME NAME AS YOUR CLASS
            - Methods need to have their return type defined
            - Methods are initially dynamic, can be set to static
                - Constructor Methods are never static because Constructors are dynamic
            - Methods << (also commonly called functions) "do" things. They manipulate data within your class.
        */
        // checkPin returns true or false. True means correct, and false means incorrect
        public bool checkPin(int input) //where is the input/
        {
            if(input == this.Pin)//where is the input//
            {
                return true;
            }
            // always write default return
            return false;
        }

        public void Deposit()
        {
            Console.Clear();
            Console.WriteLine("How much to Deposit?");
            double amount = double.Parse(Console.ReadLine());
            this.Balance += amount;
            Console.WriteLine(amount + " was added to your Balance. New Balance:" + this.Balance);
        }
        public void Withdraw()
        {
            Console.Clear();
            Console.WriteLine("How much to Withdraw?");
            double amount = double.Parse( Console.ReadLine());
            if(amount > this.Balance)
            {
                Console.WriteLine("Insufficent Funds, Try Again");
                Withdraw();
            }
            else
            {
                this.Balance -= amount;
                Console.WriteLine(amount + " was withdrawn to your Balance. New Balance:" + this.Balance);
            }
        }
        public void checkBalance()
        {
            Console.Clear();
            Console.WriteLine("Your Current Balance is: " + this.Balance);
        }

        public void sendMoney()
        {
            //who are sending money to
            string user = Program.getInput("Who to send money to?\n");
            foreach (var cardHolder in Program.cardHolders)
            {   
                //check that whatever CardHolder ch has an Username user
                if(cardHolder.Username == user)
                {
                    //how much
                    Console.WriteLine("How much money to send?");
                    double amount = double.Parse(Console.ReadLine());
                    
                    if(amount > this.Balance)
                    {
                        Console.WriteLine("Insufficent Funds, Try Again");
                        sendMoney();
                    }
                    else
                    {
                        cardHolder.Balance += amount;
                        this.Balance -= amount;
                        Console.WriteLine("Sent " + cardHolder.Username + " $" + amount);
                        return;
                    }
                }
            }
            Console.WriteLine("No user " + user + " found");
        }

        public void requestMoney()
        {
            //who are we requesting money from
            string user = Program.getInput("Who to request money from?\n");
            foreach (var cardHolder in Program.cardHolders)
            {   
                //check that whatever CardHolder ch has an Username user
                if(cardHolder.Username == user)
                {
                    //how much
                    Console.WriteLine("How much money to request?");
                    double amount = double.Parse(Console.ReadLine());
                    Request request = new Request(this, cardHolder, amount);
                    return;
                }
            }
            Console.WriteLine("No user " + user + " found");
        }
    }
}