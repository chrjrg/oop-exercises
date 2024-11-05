class Item
{
    public string name;
    public double price;

    // Constructor initializes name and price
    public Item(string nameValue, double priceValue)
    {
        name = nameValue;
        price = priceValue;
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
    public string[] materials;

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
