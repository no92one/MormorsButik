namespace mormorsButiken.Items.Cloths.Tops.Hoodies;

public class Jacket : Top
{
    public Jacket(double price, 
        string name, 
        string color, 
        FitSize fit, 
        TopSize size) : 
        base(price, name, color, fit, size)
    {
        Category = ClothCategory.Jacket;
    }
}