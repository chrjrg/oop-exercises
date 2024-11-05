public class Item
{
    private string name;
    private double price;

    // Constructor initializes name and price
    public Item(string nameValue, double priceValue)
    {
        this.name = nameValue;
        this.price = priceValue;
    }

    // Returns item name
    public string GetName()
    {
        return name;
    }

    // Returns item price
    public double GetPrice()
    {
        return price;
    }
}

class FoodItem : Item
{
    private DateTime expiresAt;

    // Constructor initializes name, price, and expiration date, calling base constructor for name and price
    public FoodItem(string name, double price, DateTime expiresAtValue) : base(name, price)
    {
        expiresAt = expiresAtValue;
    }

    // Returns expiration date
    public DateTime GetExpiresAt()
    {
        return expiresAt;
    }

    // Provides a formatted string representation of FoodItem
    public override string ToString()
    {
        return "FoodItem name='" + GetName() + "'" +
               " price='" + GetPrice() + "'" +
               " expiresAt='" + GetExpiresAt() + "'";
    }

    // Uncomment to test FoodItem class functionality
    /*
    public static void Main(string[] args)
    {
        FoodItem[] items = new FoodItem[10];

        // Initialize items with incremental prices and expiration dates
        for (int i = 0; i < items.Length; i++)
        {
            items[i] = new FoodItem($"Item {i}", 12.3 * i, DateTime.Now.AddDays(i));
        }

        // Print each FoodItem in array
        foreach (FoodItem item in items)
        {
            Console.WriteLine(item);
        }
    }
    */
}

class NonFoodItem : Item
{
    private string[] materials;

    // Constructor initializes name, price, and materials, calling base constructor for name and price
    public NonFoodItem(string name, double price, string[] materialsValue) : base(name, price)
    {
        materials = materialsValue;
    }

    // Returns array of materials
    public string[] GetMaterials()
    {
        return materials;
    }

    // Provides a formatted string representation of NonFoodItem
    public override string ToString()
    {
        // Concatenate materials into a single string representation
        string m = "[";
        for (int i = 0; i < materials.Length; i++)
        {
            m += (i == 0 ? "" : ",") + materials[i];
        }
        m += "]";

        return "NonFoodItem name='" + GetName() + "'" +
               " price='" + GetPrice() + "'" +
               " materials='" + m + "'";
    }

    // Uncomment to test NonFoodItem class functionality
    /*
    public static void Main(string[] args)
    {
        /*
        NonFoodItem[] items = new NonFoodItem[10];

        // Initialize items with incremental prices and identical materials
        for (int i = 0; i < items.Length; i++)
        {
            items[i] = new NonFoodItem("Item " + i, 12.3 * i, new string[] { "butter", "cream" });
        }

        // Print each NonFoodItem in array
        foreach (NonFoodItem item in items)
        {
             Console.WriteLine(item);
        }
        


    }
    */
}

public class Inventory
{
    private Item[] items;

    private Inventory (Item[] items) 
    {
        this.items = items;
    }

    public Inventory () : this(new Item[0]) {}

    private bool Contains(Item[] items, Item item)
    {
        foreach (Item i in items)
        {
            if (i == item)
            {
                return true;
            }
        }
        return false;
    }

    public override string ToString()
    {
        return $"Inventory with {items.Length} items";
    }

    public void AddItem (Item item)    
    {
        if (!Contains(items, item)) 
        {
            Item[] newItems = new Item[items.Length+1];
            for (int i=0 ; i<items.Length ; i++) 
            {
                newItems[i] = items[i];
            }
            newItems[items.Length] = item;
            items = newItems;
        }
    }



    public void RemoveItem(Item item)
    {   
        if (Contains(items, item))
        {
            Item[] newItems = new Item[items.Length - 1]; // Create a new array with one less slot
            int i = 0;

            // First loop: Copy items up to the one we want to remove
            for (; items[i] != item; i++)
            {
                newItems[i] = items[i];
            }

            // Skip the item to remove, and continue copying the rest
            for (i++; i < items.Length; i++)
            {
                newItems[i - 1] = items[i]; // Shift elements one position back
            }

            // Replace the old array with the new one
            items = newItems;
        }
    }


    public double GetInventoryValue()
    {
        double total = 0.0;
        foreach (Item item in items)
        {
            total += item.GetPrice();
        }
        return total;
    }

    public void PrintInventory()
    {
        Console.WriteLine("Inventory:");
        foreach (Item item in items)
        {
            Console.WriteLine(item);
        }
    }
}

public class Test
{
    public static void Main(string[] args)
    {


        // Test 1, Init inventory and checking value and printing
        Console.WriteLine("Test 1:");
        Inventory inventory = new Inventory();
        Console.WriteLine("initializing Empty Inventory:");
        inventory.PrintInventory();
        Console.WriteLine($"Inventory Value: {inventory.GetInventoryValue()}"); // Expected: 0.0
        Console.WriteLine(" "); //space

        // Test 2: Adding asnd removing items
        Console.WriteLine("Test 2:");
        Item genericItem = new Item("Generic Item", 10.0);
        FoodItem foodItem = new FoodItem("Milk", 2.5, DateTime.Now.AddDays(7));
        NonFoodItem nonFoodItem = new NonFoodItem("Screwdriver", 15.0, new string[] { "metal", "plastic" });

        inventory.AddItem(genericItem);
        inventory.AddItem(foodItem);
        inventory.AddItem(nonFoodItem);

        // inventory after adding items..
        inventory.PrintInventory();
        Console.WriteLine(" "); //space
        
        // removing genericItem
        inventory.RemoveItem(genericItem); 

        // Test 3: Check Inventory Value Calculation
        Console.WriteLine("Test 3:");
        Console.WriteLine($"Total Inventory Value: {inventory.GetInventoryValue()}");
        // Expected:  2.5 + 15.0 = 17.5
        Console.WriteLine(" "); //space

        // Test 4: Attempt to Add a Duplicate Item
        Console.WriteLine("Test 4:");
        inventory.AddItem(foodItem); // Adding the same foodItem again
        inventory.PrintInventory(); // Expected: no duplicate of "food Item"
        Console.WriteLine($"Total Inventory Value (unchanged): {inventory.GetInventoryValue()}");
        Console.WriteLine(" "); //space

        // Test 5: Remove an Item and Check Inventory Value
        Console.WriteLine("Test 5:");
        inventory.RemoveItem(foodItem); // Removing "Milk"
        inventory.PrintInventory();
        Console.WriteLine($"Inventory Value after removal: {inventory.GetInventoryValue()}");
        // Expected Value: 15.0
        Console.WriteLine(" "); //space

        // Test 6: Remove an Item Not in Inventory
        Console.WriteLine("Test 6:");
        Item nonExistentItem = new Item("Nonexistent Item", 5.0);
        inventory.RemoveItem(nonExistentItem); // Attempting to remove an item not in inventory
        inventory.PrintInventory(); // Expected: no change
        Console.WriteLine($"Inventory Value (unchanged): {inventory.GetInventoryValue()}");
    }
}

 


    


