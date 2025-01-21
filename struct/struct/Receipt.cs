namespace Structure;

struct Receipt
{
    private List<Product> _products;
    private double _totalAmount; 

    public void InitReceipt()
    {
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public void PrintReceipt()
    {
        if (_products == null || _products.Count == 0)
        {
            Console.WriteLine("The receipt is empty.");
            return;
        }

        string stringDecoration = new string('-', 23);

        Console.WriteLine(stringDecoration + "\n" + stringDecoration);
        Console.WriteLine("\tRECEIPT\t");
        Console.WriteLine(stringDecoration + "\n" + stringDecoration + "\n");

        foreach (var product in _products)
        {
            Console.WriteLine(product.GetName() + " x" + product.GetCountToBuy() + " : " + product.GetPriceWithDiscount());
            Console.WriteLine($"Total Price: {product.GetSumWithDiscount():F2}\n");
            _totalAmount += product.GetSumWithDiscount();
        }

        Console.WriteLine(stringDecoration);
        Console.WriteLine($"Total Amount: {_totalAmount:F2}");
        Console.WriteLine(stringDecoration);
    }
}
