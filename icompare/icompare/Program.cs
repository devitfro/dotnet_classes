using System.Collections.Generic;
using System;
using System.Text;
using System.Threading.Tasks;

namespace icompare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var student1 = new Student(
              "Ки Хун",
              "Сон",
              "-",
              new DateTime(1990, 5, 15),
              "Сеул",
              "1234567890",
              new List<int> { 85, 90, 75 },
              new List<int> { 45, 36, 48 },
              new List<int> { 95, 90, 75 }
       );

            var student2 = new Student(
                    "Хван",
                    "Ин",
                    "Хо",
                    new DateTime(1989, 3, 22),
                    "Сеул",
                    "0987654321",
                    new List<int> { 90, 83, 100 },
                    new List<int> { 30, 45, 50 },
                    new List<int> { 92, 80, 100 }
            );

            var group = new Group("Group SG2", "Math", 3, new List<Student> { student1, student2 });

            Console.WriteLine("Before methods:");
            group.Display();


            group.Sort(new Student.StudentComparerByAverageMark());
            Console.WriteLine("\nSorted by average score:");
            group.Display();

            group.Sort(new Student.StudentComparerByName());
            Console.WriteLine("\nSorted by name:");
            group.Display();
        }
    }
}
