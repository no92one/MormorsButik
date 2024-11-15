namespace mormorsButiken.Items.Accessories.Hats;

public class Hat : Accessorie
{
    public string Size = "Onesize";
    
    public Hat(double price, 
        string name, 
        string color) 
        : base(price, name, color)
    {
        Category = AccessorieCategory.Hat;
    }
}