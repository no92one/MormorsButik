namespace mormorsButiken.Items.Cloths;

public abstract class Cloth : Item
{
    public FitSize Fit;
    public ClothCategory Category;
    
    public Cloth(double price, string name, string color, FitSize fit) 
        : base(price, name, color)
    {
        Fit = fit;
    }
}