using mormorsButiken.Items;

namespace mormorsButiken.Menus;

public class StockItem
{
    public Item Product;
    public int Quantity;

    public StockItem(Item product, int quantity)
    {
        Product = product;
        Quantity = quantity;
    }
    
}