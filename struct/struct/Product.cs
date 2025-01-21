namespace Structure;

struct Product
{
    private string _name;
    private uint _count;
    private double _price;
    private uint _discount;
    
    private uint _countToBuy;
    private double _priceWithDiscount;
    private double _sumWithDiscount; 

    public Product(MilkProducts name, uint count, double price, uint discount)
    {
        this._name = GetProductName(name);
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
        this._count = count;
    }

    public void SetPrice(double price)
    {
        if (price < 0)
        {
            Console.WriteLine("Price cannot be negative.");
            return;
        }
        this._price = price;
    }

    public void SetDiscount(uint discount)
    {
        if (discount < 0 || discount > 99)
        {
            Console.WriteLine("Not correct discount.");
            return;
        }
        this._discount = discount;
    }

    //getters
    public string GetName() => _name;

    public uint GetCount() => _count;

    public double GetPrice() => _price;

    public uint GetDiscount() => _discount;

    public uint GetCountToBuy() => _countToBuy;

    public double GetPriceWithDiscount() => _priceWithDiscount;

    public double GetSumWithDiscount() => _sumWithDiscount;

    // methods
    // Купить продукт, уменьшить к-во на складе, вызвать ф-цию посчитать сумму со скидкой
    public void BuyProduct(uint amount, Receipt receipt) {
        if (amount > _count)
        {
            Console.WriteLine("You can't buy. Not enough product in stock.");
            return;
        }

        _count -= amount;
        _countToBuy = amount;
        CalculateSum(_price, _discount, amount);
        Result(_sumWithDiscount, receipt);
    }

    // Посчитать сумму со скидкой и общую сумму за продукт с учетом скидки
    public void CalculateSum(double price, uint discount, uint amount)
    {
        _priceWithDiscount = price - (price * discount / 100);
        _sumWithDiscount = _priceWithDiscount * amount;
    }

    // Показать сумму со скидкой и спросить устраивает ли пользователя и если да - распечатать чек
    public void Result(double sum, Receipt receipt)
    {
        Console.WriteLine($"Sum to pay for {_name} : {sum:F2}");
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
        $"Name: {_name}\n" +
        $"Count: {_count}\n" +
        $"Price: {_price}\n" +
        $"Discount: {_discount}\n";

    public void ShowProductInfo()
    {
        Console.WriteLine(ToString());
        Console.WriteLine("===============\n");
    }
}
