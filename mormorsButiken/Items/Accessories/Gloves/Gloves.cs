namespace mormorsButiken.Items.Accessories.Gloves;

public class Gloves : Accessorie
{
    public GloveSize Size;
    
    public Gloves(double price, 
        string name, 
        string color,
        GloveSize size) 
        : base(price, name, color)
    {
        Category = AccessorieCategory.Gloves;
        Size = size;
    }
}