namespace operator_overload;

internal class Program
{
    static void Main(string[] args)
    {
        Student student1 = new Student(
                "Ки Хун",
                "Сон",
                "-",
                new DateTime(1980, 5, 15),
                "Сеул",
                "1234567890",
                new List<int> { 85, 90, 75 },
                new List<int> { 45, 36, 48 },
                new List<int> { 95, 90, 75 }
            );

        Student student2 = new Student(
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

        Student student3 = new Student(
            "Джо",
            "Хён-джу",
            "-",
            new DateTime(1990, 12, 30),
            "Сеул",
            "1122334455",
            new List<int> { 67, 88, 92 },
            new List<int> { 45, 48, 50 },
            new List<int> { 85, 88, 93 }
        );

        // Вывод данных о студентах
        Console.WriteLine("Student 1 details:");

        student1.ShowStudent();
        Console.WriteLine();

        Console.WriteLine("Student 2 details:");
        student2.ShowStudent();
        Console.WriteLine();

        Console.WriteLine("Student 3 details:");
        student3.ShowStudent();
        Console.WriteLine();

        // Создание группы1 и группы2
        var group1 = new Group();
        group1.SetGroupName("SG2");
        group1.SetGroupSpecialist("Math");
        group1.SetCourseNumber(2024);

        group1.AddStudent(student1);
        group1.AddStudent(student2);

        var group2 = new Group();
        group2.SetGroupName("SG3");
        group2.SetGroupSpecialist("Biology");
        group2.SetCourseNumber(2024);

        group2.AddStudent(student3);

        group1.ShowGroup();
        group2.ShowGroup();

        Console.WriteLine("Comparing Students:");
        Console.WriteLine(student1 > student2);
        Console.WriteLine(student1 < student2);
        Console.WriteLine(student1 == student2);
        Console.WriteLine(student1 != student2);

        Console.WriteLine("Student1 is " + (student1 ? "trueee" : "falsee")); 
        Console.WriteLine("Student2 is " + (student2 ? "trueee" : "falsee"));

        Console.WriteLine("Comparing Groups:");
        Console.WriteLine(group1 > group2);
        Console.WriteLine(group1 < group2);
        Console.WriteLine(group1 == group2);
        Console.WriteLine(group1 != group2);

        Console.WriteLine("Group1 is " + (group1 ? "valid" : "not valid"));
        Console.WriteLine("Group2 is " + (group2 ? "valid" : "not valid"));

        Console.WriteLine("Group1 first student: " + group1[0].GetName());
    }
}

