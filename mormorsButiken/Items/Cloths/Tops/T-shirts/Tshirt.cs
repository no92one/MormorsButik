namespace mormorsButiken.Items.Cloths.Tops.Tshirts;

public class Tshirt : Top
{
    public Tshirt(double price, 
        string name, 
        string color, 
        FitSize fit, 
        TopSize size) : 
        base(price, name, color, fit, size)
    {
        Category = ClothCategory.Tshirt;
    }
}