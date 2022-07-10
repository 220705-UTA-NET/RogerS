// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

public class cardholder
{
string CardNumber;
int Pin;
String FirstName;
String LastName;
Double Balance


Public cardholder(string CardNumber, Int Pin, String FirstName, String LastName, Double Balance)

string CardNumber;
this.int = Pin;
this.String = FirstName;
this.String = LastName;
this.Double = Balance


public string getNumber();
Return CardNumber; 

Public int getPIN();
Return Pin;

Public string getFirstName()
Return FirstName;

Public String getBalance()
Return Balance;


Public static void Main (String[]args)

void printOptions()

console.WriteLine("Choose from the following printOptions....");
console.WriteLine("1 Deposit")
console.WriteLine("2 Withdraw")
console.WriteLine("3 ShowBalance")
console.WriteLine("4 Exit")

void deposit (cardholder currentUser)
console. WriteLine( "How much do you want to deposit?");
Double deposit = double.parse(console.readline)
currentUser.setBalance(deposit)
console.WriteLine( "Thank for your Deposit. Your new balance" + currentUser.getBalance());

void Withdraw (cardholder currentUser)
console. WriteLine( "How much do you want to deposit?");
Double Withdraw = double.parse(console.readline)
currentUser.setBalance(Withdraw)
console.WriteLine( "Thank for your Deposit. Your new balance" + currentUser.getBalance());



}


using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");    
    }
  }
}