namespace mormorsButiken.Items.Cloths.Bottoms;

public abstract class Bottom : Cloth
{
    public LengthSize Length;
    public WaistSize Waist;
    
    public Bottom(double price, 
        string name, 
        string color, 
        FitSize fit , 
        LengthSize length, 
        WaistSize waist)
        : base(price, name, color, fit)
    {
        Length = length;
        Waist = waist;
    }
}