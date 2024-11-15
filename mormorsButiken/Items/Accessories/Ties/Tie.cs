namespace mormorsButiken.Items.Accessories.Ties;

public class Tie : Accessorie
{
    public string Size = "Onesize";
    
    public Tie(double price, 
        string name, 
        string color) 
        : base(price, name, color)
    {
        Category = AccessorieCategory.Tie;
    }
}