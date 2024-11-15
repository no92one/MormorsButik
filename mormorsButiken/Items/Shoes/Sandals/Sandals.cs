namespace mormorsButiken.Items.Shoes.Sandals;

public class Sandals : Shoes
{
    public Sandals(double price, 
        string name, 
        string color, 
        ShoeSize size) 
        : base(price, name, color, size)
    {
        Category = ShoeCategory.Sandals;
    }
}