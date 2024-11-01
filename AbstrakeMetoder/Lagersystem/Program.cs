using System;

public class Item
{
    private string name;
    private double price;

public Item(string name, double price)
    {
        this.name = name;
        this.price = price;
    }

    public string GetName() => name;
    public double GetPrice() => price;
}

class FoodItem : Item
{
    private DateTime expiresAt;

    public FoodItem(string name, double price, DateTime expiresAt) 
        : base(name, price)
    {
        this.expiresAt = expiresAt;
    }

    public DateTime GetExpiresAt() => expiresAt;

    public override string ToString() =>
        $"FoodItem name='{GetName()}' price='{GetPrice()}' expiresAt='{GetExpiresAt()}'";
}

class NonFoodItem : Item
{
    private string[] materials;

    public NonFoodItem(string name, double price, string[] materials) 
        : base(name, price)
    {
        this.materials = materials;
    }

    public string[] GetMaterials() => materials;

    public override string ToString()
    {
        string m = "[" + string.Join(",", materials) + "]";
        return $"NonFoodItem name='{GetName()}' price='{GetPrice()}' materials='{m}'";
    }
}

public class Inventory
{
    private Item[] items;

    public Inventory(Item[] items)
    {
        this.items = items;
    }

    public Inventory() : this(new Item[0]) {}

    public void AddItem(Item item)
    {
        if (!Contains(items, item))
        {
            Item[] newItems = new Item[items.Length + 1];
            for (int i = 0; i < items.Length; i++)
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
            Item[] newItems = new Item[items.Length - 1];
            int i = 0;
            for (; items[i] != item; i++)
            {
                newItems[i] = items[i];
            }
            for (i++; i < items.Length; i++)
            {
                newItems[i - 1] = items[i];
            }
            items = newItems;
        }
    }

    public double GetInventory()
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
            Console.WriteLine(" - " + item);
        }
    }

    private bool Contains(Item[] items, Item item)
    {
        foreach (Item candidateItem in items)
        {
            if (candidateItem == item) return true;
        }
        return false;
    }
}

// Test class for demonstration
public class Test
{
    public static void TestFoodItem()
    {
        FoodItem[] items = new FoodItem[10];
        for (int i = 0; i < items.Length; i++)
        {
            items[i] = new FoodItem($"Item {i}", 12.3 * i, DateTime.Now.AddDays(i));
        }
        foreach (FoodItem item in items)
        {
            Console.WriteLine(item);
        }
    }

    public static void TestNonFoodItem()
    {
        NonFoodItem[] items = new NonFoodItem[10];
        for (int i = 0; i < items.Length; i++)
        {
            items[i] = new NonFoodItem("Item " + i, 12.3 * i, new string[] { "butter", "cream" });
        }
        foreach (NonFoodItem item in items)
        {
            Console.WriteLine(item);
        }
    }

    public static void PrintStatus(Inventory inventory)
    {
        inventory.PrintInventory();
        Console.WriteLine("Total: " + inventory.GetInventory());
        Console.WriteLine();
    }

    public static void Main(string[] args)
    {
        Inventory inventory = new Inventory();
        Item i1 = new Item("chocolate", 19.95);
        Item i2 = new Item("coffee", 24.95);
        Item i3 = new FoodItem("Milk", 12.95, new DateTime());
        Item i4 = new NonFoodItem("USB Charger", 17.45, new string[] { "plastic", "stuff" });

        Item[] items = new Item[] { i1, i2, i3, i4 };

        PrintStatus(inventory);

        foreach (Item item in items)
        {
            inventory.AddItem(item);
            PrintStatus(inventory);
        }

        inventory.RemoveItem(i1);
        PrintStatus(inventory);
    }
}

