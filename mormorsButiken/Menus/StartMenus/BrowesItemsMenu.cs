namespace mormorsButiken.Menus;

public class BrowesItemsMenu
{
    public TopsMenu TopMenu;
    public BottomsMenu BottomMenu;

    public BrowesItemsMenu()
    {
        TopMenu = new TopsMenu();
        BottomMenu = new BottomsMenu();
    }
    
    public void Start()
    {
        bool run = true;
        while (run)
        {
            
            Console.WriteLine($"\n--- Browes Items ---" +
                              $"\n" +
                              $"\n1. Tops" +
                              $"\n2. Bottoms" +
                              $"\nB. Back" +
                              $"\n" );
            
            String choice = Console.ReadLine();

            switch (choice.Trim().ToLower())
            {
                case "1":
                    TopMenu.Start();
                    break;
                
                case "2":
                    BottomMenu.Start();
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