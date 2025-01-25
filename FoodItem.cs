namespace Mission03;

public class FoodItem
{
    public string Name { get; private set; }
    public string Category { get; private set; }
    public int Quantity { get; private set; }
    public DateTime ExpirationDate { get; private set; }

    public FoodItem(string name, string category, int quantity, DateTime expirationDate)
    {
        Name = name;
        Category = category;
        Quantity = quantity;
        ExpirationDate = expirationDate;
    }

    public static FoodItem AddFoodItem()
    {
        Console.Write("Enter food item name: ");
        string name = Console.ReadLine();

        Console.Write("Enter food item category (e.g., 'Canned Goods', 'Dairy', 'Produce'): ");
        string category = Console.ReadLine();

        int quantity;
        while (true)
        {
            Console.Write("Enter food item quantity: ");
            if (int.TryParse(Console.ReadLine(), out quantity) && quantity >= 0)
            {
                break;
            }
            Console.WriteLine("Invalid quantity. Please enter a non-negative number.");
        }

        DateTime expirationDate;
        while (true)
        {
            Console.Write("Enter food item expiration date (YYYY-MM-DD): ");
            if (DateTime.TryParse(Console.ReadLine(), out expirationDate))
            {
                break;
            }
            Console.WriteLine("Invalid date format. Please try again.");
        }

        return new FoodItem(name, category, quantity, expirationDate);
    }

    public override string ToString()
    {
        return $"{Name} | Category: {Category} | Quantity: {Quantity} | Expiration Date: {ExpirationDate.ToShortDateString()}";
    }
}