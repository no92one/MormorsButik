namespace mormorsButiken.Items.Cloths.Bottoms.Chinos;

public class Chiono : Bottom
{
    public Chiono(double price, 
        string name, 
        string color, 
        FitSize fit, 
        LengthSize length, 
        WaistSize waist) 
        : base(price, name, color, fit, length, waist)
    {
        Category = ClothCategory.Chino;
    }
}