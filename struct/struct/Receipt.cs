namespace Structure;

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
