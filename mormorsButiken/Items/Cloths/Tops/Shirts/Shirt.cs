namespace mormorsButiken.Items.Cloths.Tops.Shirts;

public class Shirt : Top
{
    public Shirt(double price, 
        string name, 
        string color, 
        FitSize fit, 
        TopSize size) : 
        base(price, name, color, fit, size)
    {
        Category = ClothCategory.Shirt;
    }
}