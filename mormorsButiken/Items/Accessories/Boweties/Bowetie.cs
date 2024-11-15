namespace mormorsButiken.Items.Accessories.Boweties;

public class Bowetie : Accessorie
{
    public string Size = "Onesize";
    
    public Bowetie(double price, 
        string name, 
        string color) 
        : base(price, name, color)
    {
        Category = AccessorieCategory.Bowetie;
    }
}