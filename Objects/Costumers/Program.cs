using System;

class Customer
{
   // declaring variables
   public string name;
   public int id;
   public double balance;

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

   public int GetId()
   {
      return id;
   }
}

class CustomerDatabase {

   private Customer[] customers;    // Array of customers
   private int arrayIndex = 0;   // Tracks next available slot

   public CustomerDatabase()
   {
      customers = new Customer[10]; // Initialiserer arrayet med 10 pladser
   }


   public void AddCustomer(Customer customer)
   {
      if (arrayIndex < customers.Length)
      {
         customers[arrayIndex] = customer; // Gemmer kunden i arrayet
         arrayIndex++; // Opdaterer indekset for næste ledige plads
      }
      else
      {
         Console.WriteLine("Customer array is full"); // Hvis arrayet er fuldt
      }
    }

   
   public void RemoveCustomerById(int id)
   {
      for (int i = 0; i < customers.Length; i++)
      {
         if (customers[i] != null && customers[i].id == id)
         {
            customers[i] = null!; // Fjerner kunden ved at sætte instanten til null
            Console.WriteLine($"Customer with ID {id} removed");
            return;
         }
      }
        Console.WriteLine($"Customer with ID {id} not found");
   }

   public Customer[] GetAllCustomers()
   {
      return customers; // Returnerer hele arrayet
   }

   public void PrintCustomerNamesAndId()
   {
      Console.WriteLine("Customer names:");
      foreach (var customer in customers)
      {
         if (customer != null)
         {
            Console.WriteLine(customer.name + " " + customer.id); // writing customers name and id
         }
      }
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
   Console.WriteLine("The customers balance is: " + aCostumer.GetBalance());
   Console.WriteLine("The customers id is: " + aCostumer.GetId());
   Console.WriteLine(" ");

   // Creating a new customer database object
   CustomerDatabase database = new CustomerDatabase();
   
   // Adding several customers to the database using the AddCustomer method
   database.AddCustomer(new Customer("Jens", 1));
   database.AddCustomer(new Customer("Mads", 2));
   database.AddCustomer(new Customer("Julie", 3));
   database.AddCustomer(new Customer("Torben", 4));
   database.AddCustomer(new Customer("Anna", 5));
   database.AddCustomer(new Customer("Josefine", 6));
   database.AddCustomer(new Customer("Mads", 7));
   database.AddCustomer(new Customer("Anita", 8));
   database.AddCustomer(new Customer("Troels", 9));
   database.AddCustomer(new Customer("Kasper", 10));
   database.AddCustomer(new Customer("Lis", 11));

   // Removing a customer with ID 5 from the database
   database.RemoveCustomerById(5);
   
   // Trying to remove the same customer again (should show "not found")
   database.RemoveCustomerById(5);
   
   
   // Calling the method to print all customer names and IDs
   database.PrintCustomerNamesAndId();

   }
}
