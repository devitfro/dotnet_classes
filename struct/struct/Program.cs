using System;
using System.Net;
using System.Threading.Channels;
using System.Xml.Linq;

namespace Structure;

enum MilkProducts { MILK, KEFIR, YOGURT, CHEESE, SOUR_CREAM }

struct Receipt
{
    private List<Product> products;

    double totalAmount; 

    public void InitReceipt()
    {
        products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public void PrintReceipt()
    {

        if (products == null || products.Count == 0)
        {
            Console.WriteLine("The receipt is empty.");
            return;
        }

        string stringDecoration = new string('-', 23);

        Console.WriteLine(stringDecoration + "\n" + stringDecoration);
        Console.WriteLine("\tRECEIPT\t");
        Console.WriteLine(stringDecoration + "\n" + stringDecoration + "\n");

        foreach (var product in products)
        {
            Console.WriteLine(product.GetName() + " x" + product.GetCountToBuy() + " : " + product.GetPriceWithDiscount());
            Console.WriteLine($"Total Price: {product.GetSumWithDiscount():F2}\n");
            totalAmount += product.GetSumWithDiscount();
        }
        Console.WriteLine(stringDecoration);
        Console.WriteLine($"Total Amount: {totalAmount:F2}");
        Console.WriteLine(stringDecoration);
    }
}

struct Product
{
    private string name;
    private uint count;
    private double price;
    private uint discount;
    
    private uint countToBuy;
    private double priceWithDiscount;
    private double sumWithDiscount; 

    public Product(MilkProducts name, uint count, double price, uint discount)
    {
        this.name = GetProductName(name);
        SetCount(count);
        SetPrice(price);
        SetDiscount(discount);
    }

    private static string GetProductName(MilkProducts productName)
    {
        switch (productName) {
            case MilkProducts.MILK:
                return "Milk";
            case MilkProducts.KEFIR:
                return "Kefir";
            case MilkProducts.YOGURT:
                return "Yogurt";
            case MilkProducts.CHEESE:
                return "Cheese";
            case MilkProducts.SOUR_CREAM:
                return "Sour Cream";
            default:
                return "Unknown";
        }
    }

    // setters
    public void SetCount(uint count)
    {
        if (count > 1000)
        {
            Console.WriteLine("Cannot be so much products.");
            return;
        }
        this.count = count;
    }

    public void SetPrice(double price)
    {
        if (price < 0)
        {
            Console.WriteLine("Price cannot be negative.");
            return;
        }
        this.price = price;
    }

    public void SetDiscount(uint discount)
    {
        if (discount < 0 || discount > 99)
        {
            Console.WriteLine("Not correct discount.");
            return;
        }
        this.discount = discount;
    }

    //getters
    public string GetName() => name;

    public uint GetCount() => count;

    public double GetPrice() => price;

    public uint GetDiscount() => discount;

    public uint GetCountToBuy() => countToBuy;

    public double GetPriceWithDiscount() => priceWithDiscount;

    public double GetSumWithDiscount() => sumWithDiscount;

    // methods
    // Купить продукт, уменьшить к-во на складе, вызвать ф-цию посчитать сумму со скидкой
    public void BuyProduct(uint amount, Receipt receipt) {
        if (amount > count)
        {
            Console.WriteLine("You can't buy. Not enough product in stock.");
            return;
        }

        count -= amount;
        countToBuy = amount;
        CalculateSum(price, discount, amount);
        Result(sumWithDiscount, receipt);
    }

    // Посчитать сумму со скидкой и общую сумму за продукт с учетом скидки
    public void CalculateSum(double price, uint discount, uint amount)
    {
        priceWithDiscount = price - (price * discount / 100);
        sumWithDiscount = priceWithDiscount * amount;
    }

    // Показать сумму со скидкой и спросить устраивает ли пользователя и если да - распечатать чек
    public void Result(double sum, Receipt receipt)
    {
        Console.WriteLine($"Sum to pay for {name} : {sum:F2}");
        Console.WriteLine("You agree to buy?");
   
        string userChoice = Console.ReadLine()?.Trim().ToLower();

        while (userChoice != "yes" && userChoice != "no")
        {
            Console.WriteLine("Not correct input. Please type 'yes' or 'no'.");
            userChoice = Console.ReadLine()?.Trim().ToLower();
        }

        if (userChoice == "yes")
        {
            receipt.AddProduct(this);
            Console.WriteLine("Product added to the receipt.\n");
        }
        else if (userChoice == "no") Console.WriteLine();
    }

    // Показать информацию о продукте
    public override string ToString() => 
        $"Name: {name}\n" +
        $"Count: {count}\n" +
        $"Price: {price}\n" +
        $"Discount: {discount}\n";

    public void ShowProductInfo()
    {
        Console.WriteLine(ToString());
        Console.WriteLine("===============\n");
    }
}

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
