using mormorsButiken.Items;
using mormorsButiken.Items.Accessories;
using mormorsButiken.Items.Accessories.Belt;
using mormorsButiken.Items.Accessories.Gloves;

namespace mormorsButiken.Menus;

public class AccessoriesMenu
{
    public void Start(List<StockItem> storeInventory)
    {
        bool run = true;
        while (run)
        {

            Console.WriteLine($"\n--- Accessories ---" +
                              $"\n");

            printAccessorieItems(storeInventory);
                              
            Console.WriteLine($"\nB. Back" +
                              $"\n" );
            
            String choice = Console.ReadLine();

            switch (choice.Trim().ToLower())
            {
                case "1":
                    Console.WriteLine("Items - WIP");
                    break;
                
                case "b":
                    run = false;
                    break;
                
                default:
                    Console.WriteLine("You need to pick 1 - 4.");
                    break;
            }
        }
    }

    private void printAccessorieItems(List<StockItem> storeInventory)
    {
        for (int i = 0; i < storeInventory.Count; i++)
        {
            if (storeInventory[i].Product is Accessorie)
            {
                Console.WriteLine($"{i + 1}. {storeInventory[i].Product.Name}");
            }
        }
    }
}