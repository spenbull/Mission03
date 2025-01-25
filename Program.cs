using Mission03;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Food Inventory System");

        List<FoodItem> inventory = new List<FoodItem>();
        bool continueRunning = true;

        while (continueRunning)
        {
            Console.WriteLine("\nPlease Choose an Option:");
            Console.WriteLine("1. Add Food Item");
            Console.WriteLine("2. Delete Food Item");
            Console.WriteLine("3. Print Food Inventory");
            Console.WriteLine("4. Exit");
            Console.Write("\nEnter a number to continue: ");

            string userInput = Console.ReadLine();

            if (userInput == "1")
            {
                Console.WriteLine("\nAdding a new food item...");
                FoodItem foodItem = FoodItem.AddFoodItem();
                if (foodItem != null)
                {
                    inventory.Add(foodItem);
                    Console.WriteLine("Food item added successfully!");
                }
            }
            else if (userInput == "2")
            {
                if (inventory.Count == 0)
                {
                    Console.WriteLine("The inventory is empty. Nothing to delete.");
                }
                else
                {
                    Console.WriteLine("\nCurrent Inventory:");
                    PrintInventory(inventory);

                    int itemIndex;
                    while (true)
                    {
                        Console.Write("\nEnter the number of the food item to delete: ");
                        if (int.TryParse(Console.ReadLine(), out itemIndex) && itemIndex > 0 && itemIndex <= inventory.Count)
                        {
                            break;
                        }
                        Console.WriteLine("Invalid selection. Please enter a valid number.");
                    }

                    inventory.RemoveAt(itemIndex - 1);
                    Console.WriteLine("Food item deleted successfully.");
                }
            }
            else if (userInput == "3")
            {
                Console.WriteLine("\nCurrent Food Inventory:");
                PrintInventory(inventory);
            }
            else if (userInput == "4")
            {
                Console.WriteLine("Exiting...");
                continueRunning = false;
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
        }
    }

    static void PrintInventory(List<FoodItem> inventory)
    {
        if (inventory.Count == 0)
        {
            Console.WriteLine("The inventory is empty.");
        }
        else
        {
            for (int i = 0; i < inventory.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {inventory[i]}");
            }
        }
    }
}

