namespace mormorsButiken.Items.Accessories.Socks;

public class Socks : Accessorie
{
    public string Size = "Onesize";
    
    public Socks(double price, 
        string name, 
        string color) 
        : base(price, name, color)
    {
        Category = AccessorieCategory.Socks;
    }
}