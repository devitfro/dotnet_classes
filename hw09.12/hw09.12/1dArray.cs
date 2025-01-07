//namespace hw1;

//class _1dArray
//{
//    static void Main()
//    {
//        Console.Write("Введите число от 0 до 1 000 000: ");
//        string userInput = Console.ReadLine();

//        bool success = int.TryParse(userInput, out var number);

//        if (!success || number < 0 || number >= 1000000)
//        {
//            Console.WriteLine("Ошибка: введите число в диапазоне от 0 до 1 000 000.");
//            return;
//        }

//        Console.WriteLine("Ваше число - " + Result(number));
//    }

//    static string Result(int number)
//    {
//        if (number == 0) return "ноль";
//        if (number == 1000000) return "один миллион";

//        string result = "";

//        if (number >= 1000)
//        {
//            int thousands = number / 1000;
//            result += Thousands(thousands) + " тысяча ";
//            number %= 1000;
//        }

//        result += Hundreds(number);

//        return result;
//    }

//    static string Thousands(int number)
//    {
//        if (number == 1) return "одна";
//        if (number == 2) return "две";

//        return Hundreds(number);
//    }

//    static string Hundreds(int number)
//    {
//        string[] hundreds = { "", "сто", "двести", "триста", "четыреста", "пятьсот", "шестьсот", "семьсот", "восемьсот", "девятьсот" };
//        string[] tens = { "", "десять", "двадцать", "тридцать", "сорок", "пятьдесят", "шестьдесят", "семьдесят", "восемьдесят", "девяносто" };
//        string[] teens = { "десять", "одиннадцать", "двенадцать", "тринадцать", "четырнадцать", "пятнадцать", "шестнадцать", "семнадцать", "восемнадцать", "девятнадцать" };
//        string[] ones = { "", "один", "два", "три", "четыре", "пять", "шесть", "семь", "восемь", "девять" };

//        string result = "";

//        if (number >= 100)
//        {
//            result += hundreds[number / 100] + " ";
//            number %= 100;
//        }

//        if (number >= 10 && number < 20)
//        {
//            result += teens[number - 10] + " ";
//        }
//        else
//        {
//            if (number >= 20)
//            {
//                result += tens[number / 10] + " ";
//                number %= 10;
//            }
//            if (number > 0)
//            {
//                result += ones[number] + " ";
//            }
//        }

//        return result;
//    }
//}
