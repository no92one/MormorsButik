namespace mormorsButiken.Items.Accessories.Belt;

public class Belt : Accessorie
{
    public BeltSize Size;
    
    public Belt(double price, 
        string name, 
        string color,
        BeltSize size) 
        : base(price, name, color)
    {
        Category = AccessorieCategory.Belt;
        Size = size;
    }

    public string getSize()
    {
        return Size.ToString();
    }
}