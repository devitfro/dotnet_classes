using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extension
{
    public static class Extensions
    {
        public static void Print<T>(this T value)
        {
            Console.WriteLine(value);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            "Hello world".Print();
            2024.Print();
            0.08.Print();
        }
    }
}





