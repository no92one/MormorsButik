namespace mormorsButiken.Items.Accessories;

public class Accessorie : Item
{
    public AccessorieCategory Category;
    
    public Accessorie(double price, 
        string name, 
        string color) 
        : base(price, name, color)
    {
    }
}