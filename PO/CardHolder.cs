namespace RogerAtm
{
    public class CardHolder
    {
        private int CardNumber{ get; set;}
        private int Pin{get; set;}
        public string Username{ get; set;}
        public string FirstName{ get; set;}
        public string LastName{ get; set;}
        public double Balance{get; set;}
        static int id = 1; int myID;

        public CardHolder(){}
        
        public CardHolder(int CardNumber, int Pin, string Username, string FirstName, string LastName, double Balance)
        {
            this.CardNumber = CardNumber; //123
            this.Pin = Pin; // 4213
            this.Username = Username;
            this.FirstName = FirstName; //rogr
            this.LastName = LastName;//xyz
            this.Balance = Balance; //0
            this.myID = id; id++;
        }

        public void returnAccDetails(){ //toString() << usually handled by a Serializer (XML or JSON)
            Console.WriteLine(  "\nID: " + this.myID +
                                "\nCard Number: " + this.CardNumber +
                                "\nUsername: " + this.Username +
                                "\nName: " + this.FirstName + " " + this.LastName +
                                "\nBalance: " + this.Balance);
        }

        //implement deposit
        public void deposit(int amount){}

        //implement withdraw
        public void withdraw(int amount){}


        // private setter
        // public void setPin(){}

        /*
        access modifier : public private protected internal
        - determines what can access and methods
        */


        /*
        public string defaultWorks(){
            Helper.calculate(3,4);
            return "hi";
        }

        public int defaultEmpty(){
            return this.CardNumber;
        }
        */
    }
}
