namespace mormorsButiken.Items.Shoes.Boots;

public class Boots : Shoes
{
    public Boots(double price, 
        string name, 
        string color, 
        ShoeSize size) 
        : base(price, name, color, size)
    {
        Category = ShoeCategory.Boots;
    }
}