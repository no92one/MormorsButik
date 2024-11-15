namespace mormorsButiken.Menus;

public class TopsMenu
{
    public void Start()
    {
        bool run = true;
        while (run)
        {
            
            Console.WriteLine($"\n--- Tops ---" +
                              $"\n" +
                              $"\n1. Items" +
                              $"\nB. Back" +
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
}