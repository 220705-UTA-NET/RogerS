using System;

public class CardHolder {
    string CardNumber;
    int Pin;
    string FirstName;
    string LastName;
    Double Balance;

    public CardHolder(string CardNumber, int Pin, string FirstName, string LastName,Double Balance)
    {
        this.CardNumber= CardNumber; //123
        this.Pin= Pin; // 4213
        this.FirstName= FirstName; //rogr
        this.LastName= LastName;//xyz
        this.Balance= Balance; //0
    }

        Public string getCardNumber()
        {
        return CardNumber;
        }

        Public int getPin()
        {
        return Pin;
        }

        Public string getFirstName()
        {
        return FirstName;
        }

        Public string getLastName()
        {
        return LastName;
        }

        Public Double getBalance(Balance)
        {
            return Balance;
        }

        Public string setCardNumber(CardNumber)
        {
            this.CardNumber = CardNumber;
        }

        Public int setPin(pin)
        {
            this.pin = pin;
        }

        Public string setFirstName(FirstName) //Roger
        {
            this.FirstName = FirstName;
        }

        Public string setLastName(LastName)
        {
            this.LastName = LastName;
        }

        Public Double setBalance(Balance)
        {
            this.Balance = Balance;
        }

        void Deposit(CardHolder CurrentUser){   
        console.WriteLine("How much money would you like to deposit?");
        double deposit = Double.Parse(Console.ReadLine());// 20.53 --> string --> double
        curentBalance = CurrentUser.getBalance(); // get current balance of current  user
        updatedBalance = currentBalanace + deposit;
        CurrentUser.setBalance(updatedBalance);
        console.WriteLine("Thank you"+ CurrentUser.getFirstName() +" for banking with us.Your new balance" + CurrentUser.getBalance() )
        }// end of deposit method

        void Withdraw(CardHolder CurrentUser){
            console.WriteLine("How much money would you like to withdraw");
            double Withdraw = Double.Parse(Console.ReadLine());
            if(CurrentUser.GetBalance()>withdraw)
            {
                Console.WriteLine("Insufficent funds;(") ;

            }
            else
            {
                CurrentUser.setBalance(CurrentUser.GetBalance()-withdraw);
                console.WriteLine("Thank you for banking with us.Your new balance" + CurrentUser.getBalance());
            }
        }// end of withdraw method

        void printOptions {
                Console.Writeline("Welcome to Rogers ATM");
                Console.Writeline("Please choose from the following options");
                Console.Writeline("1 Deposit");
                Console.Writeline("2 Withdraw ");
                Console.Writeline("show balance ");
                Console.Writeline("exit");
            }  
            
        public static void Main(){
        //start of main method
        List<CardHolder> cardHolders = new List<CardHolder>();
        cardHolders.Add(new CardHolder("4534278650056315",1234, "John", "Carter",180.50));
        cardHolders.Add(new CardHolder("4534278650056316",4567, "Peter", "Alvin",180.50));
        cardHolders.Add(new CardHolder("4534278650056317",8910, "Mark", "Bruce",180.50));
        cardHolders.Add(new CardHolder("4534278650056318",1132, "Filly", "Brian",180.50));
        cardHolders.Add(new CardHolder("4534278650056319",1432, "Paul", "Corner",180.50));
        cardHolders.Add(new CardHolder("4534278650056320",1332, "Roger", "Jackson",180.50));

        while(true){
            boolean loginFlag = false;
            
            Console.Writeline("Enter the FirstName and pin");
            CardHolder curentUser = Console.ReadLine();
            CardHolder pin = Integer.Parse(Console.ReadLine());

            foreach (CardHolder user in cardHolders)
            {
                if(pin == user.getPin() && curentUser == user.getFirstName()){
                    loginFlag = true;
                    break;
                }
            }

            if(loginFlag){
                Console.Writeline("You are successfully Logged In!");
                printOptions();
                int option = Integer.Parse(Console.ReadLine());
                        if(option==1) { Deposit(currentUser);}
                        else if(option==2) { Withdraw(currentUser);}
                        else if(option==3) { Console.Writeline(currentUser.getBalance());}
                        else if(option==4) {
                            Console.Writeline("Please select among listed options");
                            }
                        }
            }
            else{
                Console.Writeline("Please check either username or password is wrong ;(");
            }
        }//end of while
    }
} // end of Cardholder class
