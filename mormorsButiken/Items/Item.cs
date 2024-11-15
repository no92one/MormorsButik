namespace mormorsButiken.Items;

public abstract class Item
{
    public double Price;
    public string Name;
    public string Color;

    public Item(double price, string name, string color)
    {
        Price = price;
        Name = name;
        Color = color;
    }
}