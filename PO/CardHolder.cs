namespace RogerAtm{ 
    

    
    public string CardNumber{ get; set;}
    public int Pin{get; set;}
    public string FirstName{ get; set;}
    public string LastName{ get; set;}
    public double Balance{get; set;}

    public CardHolder(string CardNumber, int Pin, string FirstName, string LastName, double Balance)
    {
        this.CardNumber = CardNumber; //123
        this.Pin = Pin; // 4213
        this.FirstName = FirstName; //rogr
        this.LastName = LastName;//xyz
        this.Balance = Balance; //0
    }
}
