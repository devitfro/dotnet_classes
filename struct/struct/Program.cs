using System;
using System.Net;
using System.Threading.Channels;
using System.Xml.Linq;

namespace Structure;

internal class Program
{
    static void Main(string[] args)
    {
        var receipt = new Receipt();
        receipt.InitReceipt();

        var product1 = new Product(MilkProducts.MILK, 10, 45.5, 10);
        var product2 = new Product(MilkProducts.CHEESE, 10, 500, 5);
        var product3 = new Product(MilkProducts.YOGURT, 10, 25.8, 0);

        product1.ShowProductInfo();
        product2.ShowProductInfo();
        product3.ShowProductInfo();

        product1.BuyProduct(3, receipt);
        product2.BuyProduct(3, receipt);
        product3.BuyProduct(5, receipt);

        receipt.PrintReceipt();
    }
}
