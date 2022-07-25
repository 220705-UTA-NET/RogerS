namespace ATM
{
    public class Request
    {
        CardHolder requester;
        CardHolder requestee;
        double amount;
        public Request(CardHolder requester, CardHolder requestee, double amount)
        {
            this.requester = requester;
            this.requestee = requestee;
            this.amount = amount;
        }
    }
}