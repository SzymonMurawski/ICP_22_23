namespace ShoppingListApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, this is your Shopping List App!");
            ShoppingList shoppingList = new ShoppingList();
            while (true)
            {
                Console.WriteLine($"You have {shoppingList.Size()} items on your shopping list.");
                Console.WriteLine("Write next item to add, or leave empty to end adding.");
                string? item = Console.ReadLine();
                if (string.IsNullOrEmpty(item))
                {
                    break;
                }
                shoppingList.AddItem(item);
            }
            Console.WriteLine("On your shopping list you have the following items:");
            Console.WriteLine(shoppingList.GetList());
        }
    }
}