namespace mormorsButiken.Items.Accessories.Sunglasses;

public class Sunglasses : Accessorie
{
    public string Size = "Onesize";
    
    public Sunglasses(double price, 
        string name, 
        string color) 
        : base(price, name, color)
    {
        Category = AccessorieCategory.Sunglasses;
    }
}