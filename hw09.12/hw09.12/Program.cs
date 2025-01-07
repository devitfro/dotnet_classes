using System.Text.RegularExpressions;

namespace hw1;
class Program
{
    static void Main()
    {
        // 1d array class 1dArray
        // 2d array class 1dArray

        Console.WriteLine("Enter string: ");

        string userInput = Console.ReadLine();
        Console.WriteLine("You enter: " + userInput);

        string userStrToLower = userInput.ToLower();
        string strWithoutSpace = Regex.Replace(userStrToLower, @"[^а-яa-z0-9]", "");
        char[] strToChar = strWithoutSpace.ToCharArray();
   
        Array.Reverse(strToChar);

        string strReverse = new string(strToChar);
        bool isPallidrome = strWithoutSpace.Equals(strReverse);

        Console.WriteLine(isPallidrome);
    }
}
