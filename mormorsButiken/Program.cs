using mormorsButiken.Menus;
using mormorsButiken.ReadWrite;

namespace mormorsButiken;

class Program
{
    static void Main(string[] args)
    {
        // StartMenu menu = new StartMenu(); 
        // menu.Start();
        
        BeltReadWrite bwr = new BeltReadWrite();
        bwr.read();
    }
}