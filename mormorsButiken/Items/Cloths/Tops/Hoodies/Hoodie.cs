namespace mormorsButiken.Items.Cloths.Tops.Hoodies;

public class Hoodie : Top
{
    
    public Hoodie(double price, 
        string name, 
        string color, 
        FitSize fit, 
        TopSize size) : 
        base(price, name, color, fit, size)
    {
        Category = ClothCategory.Hoodie;
    }
}