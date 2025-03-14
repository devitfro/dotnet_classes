using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lyambda
{
    delegate bool StudentFilter(Student student);

    internal class Program
    {
        static void Main(string[] args)
        {
            Group group = new Group("CS-101", "Computer Science", 2, new List<Student>
            {
                new Student("Ки Хун", "Сон", "Сон", new DateTime(2002, 5, 12), "NY", "1234567890", new List<int>{ 90, 85, 88 }, new List<int>{ 45, 48 }, new List<int>{ 80, 90 }),
                new Student("Хван", "Ин", "Хо", new DateTime(2003, 6, 25), "Сеул", "0987654321", new List<int>{ 70, 75, 78 }, new List<int>{ 40, 42 }, new List<int>{ 60, 65 }),
                new Student("Charlie", "Brown", "Sergeevich", new DateTime(2001, 2, 20), "TX", "1122334455", new List<int>{ 95, 92, 93 }, new List<int>{ 50, 49 }, new List<int>{ 98, 100 })
            });

            // Фильтры на анонимных методах
            var excellentStudents = group.FilterStudents(delegate (Student s) { return s.GetAverageGrade() >= 10; });
            var nameStartsWithA = group.FilterStudents(delegate (Student s) { return s.Name.StartsWith("A"); });
            var hasGrade2 = group.FilterStudents(delegate (Student s) { return s._gradesExam.Contains(2); });

            // Фильтры на лямбда-выражениях
            var averageGrade = group.Students.Average(s => s.GetAverageGrade());
            var topStudents = group.FilterStudents(s => s.GetAverageGrade() > averageGrade);
            var longNameStudents = group.FilterStudents(s => s.Name.Length > 5);
            var evenGradeCountStudents = group.FilterStudents(s => s._gradesExam.Count % 2 == 0);
            var highTotalGradeStudents = group.FilterStudents(s => s._gradesExam.Sum() + s._gradesExam.Sum() > 50);

            // Вывод результатов
            PrintStudents("Отличники:", excellentStudents);
            PrintStudents("Имена начинаются с 'А':", nameStartsWithA);
            PrintStudents("Есть оценка 2 за экзамен:", hasGrade2);
            PrintStudents("Средний балл выше среднего:", topStudents);
            PrintStudents("Имя длиннее 5 символов:", longNameStudents);
            PrintStudents("Четное количество оценок:", evenGradeCountStudents);
            PrintStudents("Сумма всех оценок больше 50:", highTotalGradeStudents);
        }

        static void PrintStudents(string message, List<Student> students)
        {
            Console.WriteLine($"\n{message}");
            foreach (var student in students)
            {
                Console.WriteLine(student.Name);
            }
        }
    }
}



