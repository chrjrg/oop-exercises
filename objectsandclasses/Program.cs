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

   private Customer[] customers;
   private int arrayIndex = 0;

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
            customers[i] = null!; // Fjerner kunden ved at sætte referencen til null
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

   CustomerDatabase database = new CustomerDatabase();
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

   database.RemoveCustomerById(5);
   database.RemoveCustomerById(5);
   database.PrintCustomerNamesAndId();



   }
}

/*
chatgpt inline comments...
using System;

class Customer
{
   // Declaring public variables to store customer details
   public string name;   // Customer's name
   public int id;        // Customer's unique ID
   public double balance; // Customer's current balance

   // Constructor that takes name and id as parameters and sets balance to 0
   public Customer (string inName, int inId)
   {
      name = inName;  // Assigning input name to the customer's name
      id = inId;      // Assigning input ID to the customer's ID
      balance = 0;    // Setting the initial balance to 0
   }

   // Constructor that takes name, id, and balance as parameters
   public Customer (string inName, int inId, double inBalance)
   {
      name = inName;       // Assigning input name to the customer's name
      id = inId;           // Assigning input ID to the customer's ID
      balance = inBalance; // Assigning input balance to the customer's balance
   }

   // Method to deposit an amount into the customer's balance
   public void Deposit(double amount)
   {
      balance += amount;   // Adds the deposit amount to the balance
   }

   // Method to withdraw an amount from the customer's balance
   public void Withdraw(double amount)
   {
      balance -= amount;   // Subtracts the withdrawal amount from the balance
   }

   // Method to retrieve the customer's current balance
   public double GetBalance()
   {
      return balance;      // Returns the current balance of the customer
   }

   // Method to retrieve the customer's ID
   public int GetId()
   {
      return id;           // Returns the customer's ID
   }
}

class CustomerDatabase {

   // Declaring a fixed array of Customer objects with space for 10 customers
   private Customer[] customers;
   private int arrayIndex = 0; // Variable to keep track of the next available position in the array

   // Constructor that initializes the array with 10 customer slots
   public CustomerDatabase()
   {
      customers = new Customer[10]; // Creating an array to hold 10 customers
   }

   // Method to add a new customer to the database
   public void AddCustomer(Customer customer)
   {
      // Checking if there's space available in the array
      if (arrayIndex < customers.Length)
      {
         customers[arrayIndex] = customer; // Adding the customer at the next available index
         arrayIndex++; // Incrementing the index for the next customer
      }
      else
      {
         // If the array is full, display a message
         Console.WriteLine("Customer array is full");
      }
    }

   // Method to remove a customer by their ID
   public void RemoveCustomerById(int id)
   {
      // Loop through the array to find the customer with the matching ID
      for (int i = 0; i < customers.Length; i++)
      {
         // Checking if the customer exists and has the matching ID
         if (customers[i] != null && customers[i].id == id)
         {
            customers[i] = null; // Set the customer slot to null to remove them
            Console.WriteLine($"Customer with ID {id} removed");
            return; // Exit the method after removing the customer
         }
      }
      // If the customer with the given ID wasn't found, display a message
      Console.WriteLine($"Customer with ID {id} not found");
   }

   // Method to return all customers in the database
   public Customer[] GetAllCustomers()
   {
      return customers; // Returns the entire array of customers
   }

   // Method to print the names and IDs of all customers
   public void PrintCustomerNamesAndId()
   {
      Console.WriteLine("Customer names:");
      // Loop through each customer in the array
      foreach (var customer in customers)
      {
         // Check if the customer exists (is not null)
         if (customer != null)
         {
            // Print the customer's name and ID
            Console.WriteLine(customer.name + " " + customer.id);
         }
      }
   }
}

class Program {
   public static void Main(string[] args) {

      // Declaring a Customer variable
      Customer aCostumer;

      // Creating a new customer object using the constructor with name, ID, and balance
      aCostumer = new Customer("Christian", 1, 100);

      // Depositing 50 to the customer's balance
      aCostumer.Deposit(50);

      // Withdrawing 25 from the customer's balance
      aCostumer.Withdraw(25);

      // Displaying the customer's current balance (should be 125)
      Console.WriteLine("The customer's balance is: " + aCostumer.GetBalance());

      // Displaying the customer's ID
      Console.WriteLine("The customer's ID is: " + aCostumer.GetId());

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
      database.AddCustomer(new Customer("Lis", 11)); // This will show "Customer array is full"

      // Removing a customer with ID 5 from the database
      database.RemoveCustomerById(5);

      // Trying to remove the same customer again (should show "not found")
      database.RemoveCustomerById(5);

      // Calling the method to print all customer names and IDs
      database.PrintCustomerNamesAndId();
   }
}
*/



 

