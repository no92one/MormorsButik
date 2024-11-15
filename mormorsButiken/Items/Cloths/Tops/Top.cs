namespace mormorsButiken.Items.Cloths.Tops;

public abstract class Top : Cloth
{
    public TopSize Size; 
    
    public Top(double price, 
        string name, 
        string color, 
        FitSize fit,
        TopSize size)
        : base(price, name, color, fit)
    {
        Size = size;
    }
    
}