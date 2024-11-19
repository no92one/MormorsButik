using mormorsButiken.Items;
using System.Diagnostics;
using mormorsButiken.Items.Accessories.Belt;
using mormorsButiken.Menus;

namespace mormorsButiken.ReadWrite;

public class BeltReadWrite
{

    public void read()
    {
        
        string fileName = "Belts.csv";

        Debug.Assert(File.Exists(fileName));

        List<string> lines = new(File.ReadAllLines(fileName));
        
        // pris,namn,färg,längd,lagersaldo
        List<StockItem> BeltList = new List<StockItem>();
        foreach (var line in lines)
        {
            string[] beltData = line.Split(",");

            Belt newBelt = new Belt(
                Convert.ToDouble(beltData[0]),
                beltData[1],
                beltData[2],
                (BeltSize)Convert.ToInt32(beltData[3]));

            StockItem newStockItem = new StockItem(
                newBelt, 
                Convert.ToInt32(beltData[4]));
            BeltList.Add(newStockItem);
        }

        Console.WriteLine(BeltList[0].Product.Name);
    }
}