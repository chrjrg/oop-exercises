using System;

class Customer
{
   // declaring variables
   private string name;
   private int id;
   private double balance;

   // custructer using name and id as argument, and setting balance to 0
   public Customer (string inName, int inId)
   {
      name = inName;
      id = inId;
      balance = 0;
   }

   // custructer using name, id and balance as argument
   public Customer (string inName, int inId, double InBalance)
   {
      name = inName;
      id = inId;
      balance = InBalance;
   }



   // method that deposits, and therefor updates, amount into balance
   public void Deposit(double amount)
   {
      balance += amount;
   }

   // method that withdraws, and therefor updates, amount into balance
   public void Withdraw(double amount)
   {
      balance -= amount;
   }

      // method that gets balance from costumer (<cosumer object>.GetBalance())
   public double GetBalance()
   {
      return balance;
   }

}


class CustomerDatabase {

  Customer[] customers;

   public CustomerDatabase ()
   {
      customers = new Customer[9];
   }

   public void AddCustomer()
   {
      Console.WriteLine("hh");
   }


}


class Program {
public static void Main(string[] args) {

   // declaring variable as the type "Costumer"
   Customer aCostumer;

   // variable gets references to a new costumer object, which is an instance of the class "Customer"
   // because we made multible constructers, the input can vary depending on the constructers we made
   // in our instance we could name due with a name and an id argument, which default the balance to 0 (first constructer)
   // in the case we declare the balance aswell

   aCostumer = new Customer("Christian", 1, 100);

   // we use our methods and deposits 50, and withdraws 25, which means our total balance is 125
   aCostumer.Deposit(50);
   aCostumer.Withdraw(25);

   // we call the GetBalance method in Console.WriteLine and this returns the balance of our costumer "aCostumer"
   // Console.WriteLine(aCostumer.GetBalance());



   }
}



 

