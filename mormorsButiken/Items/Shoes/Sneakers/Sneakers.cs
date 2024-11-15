namespace mormorsButiken.Items.Shoes.Sneakers;

public class Sneakers : Shoes
{
    public Sneakers(double price, 
        string name, 
        string color, 
        ShoeSize size) 
        : base(price, name, color, size)
    {
        Category = ShoeCategory.Sneakers;
    }
}