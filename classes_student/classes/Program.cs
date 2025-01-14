namespace ClassesStudent;

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
                new List<int> { 85, 90, 75 }
            );

        Student student2 = new Student(
               "Хван",
               "Ин",
               "Хо",
               new DateTime(1989, 3, 22),
               "Сеул",
               "0987654321",
               new List<int> { 90, 80, 100 }
           );

        Student student3 = new Student(
            "Джо",
            "Хён-джу",
            "-",
            new DateTime(1990, 12, 30),
            "Сеул",
            "1122334455",
            new List<int> { 45, 48, 52 }
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

        // Создание группы
        var group = new Group();
        group.SetGroupName("SG2");
        group.SetGroupSpecialist("Math");
        group.SetCourseNumber(2024);

        group.AddStudent(student1);
        group.AddStudent(student2);
        group.AddStudent(student3);

        // Вывод группы до удаления
        Console.WriteLine("Group details before removing low-performing students:");
        group.ShowGroup();
        Console.WriteLine();

        // Удаление студентов с низким средним баллом (< 50)
        group.RemoveStudentsWithLowGrades();

        // Вывод группы после удаления
        Console.WriteLine("Group details after removing low-performing students:");
        group.ShowGroup();
        Console.WriteLine();

        // Редактирование данных студента
        group.EditStudentData(student1, "Джу", "New Address", "9876543210");

        // Вывод новой информации о студенте
        Console.WriteLine("Updated Student 1 details:");
        student1.ShowStudent();
    }
}
