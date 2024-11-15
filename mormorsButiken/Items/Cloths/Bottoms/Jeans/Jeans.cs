namespace mormorsButiken.Items.Cloths.Bottoms.Jeans;

public class Jeans : Bottom
{
    public Jeans(double price, 
        string name, 
        string color, 
        FitSize fit, 
        LengthSize length, 
        WaistSize waist) 
        : base(price, name, color, fit, length, waist)
    {
        Category = ClothCategory.Jens;
    }
}