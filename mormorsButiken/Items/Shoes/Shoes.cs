namespace mormorsButiken.Items.Shoes;

public class Shoes : Item
{
    public ShoeCategory Category;
    public ShoeSize Size;
    
    public Shoes(double price, 
        string name, 
        string color, 
        ShoeSize size) 
        : base(price, name, color)
    {
        Size = size;
    }
}