namespace mormorsButiken.Menus;

public class BrowesItemsMenu
{
    public TopsMenu TopMenu;
    public BottomsMenu BottomMenu;
    public AccessoriesMenu AccessoriesMenu;

    public BrowesItemsMenu()
    {
        TopMenu = new TopsMenu();
        BottomMenu = new BottomsMenu();
        AccessoriesMenu = new AccessoriesMenu();
    }
    
    public void Start(List<StockItem> storeInventory)
    {
        bool run = true;
        while (run)
        {
            
            Console.WriteLine($"\n--- Browes Items ---" +
                              $"\n" +
                              $"\n1. Tops" +
                              $"\n2. Bottoms" +
                              $"\n3. Accessories" +
                              $"\nB. Back" +
                              $"\n" );
            
            String choice = Console.ReadLine();

            switch (choice.Trim().ToLower())
            {
                case "1":
                    TopMenu.Start(storeInventory);
                    break;
                
                case "2":
                    BottomMenu.Start(storeInventory);
                    break;
                
                case "3":
                    AccessoriesMenu.Start(storeInventory);
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
}