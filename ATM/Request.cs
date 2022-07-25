namespace ATM
{
    public class Request
    {
        public CardHolder requester {get;}
        public double amount {get;}
        public Request(CardHolder requester, double amount)
        {
            this.requester = requester;
            this.amount = amount;
        }

        public string listRequest()
        {
            return this.requester + " requested $" + amount + "\n";
        }
    }
}