namespace Delegate;

internal class Program
{
    static void ShowBestStudents(List<Student> students)
    {
        Console.WriteLine("Show all best students");
        foreach (var student in students)
        {
            if (Convert.ToInt32(student.GetGradesExam()) >= 90)
            {
                Console.WriteLine($"{student.GetName()} ({student.GetGradesExam()})");
            }
        }
    }
    static void ShowStudentsBadExam(List<Student> students)
    {
        Console.WriteLine("Show not good students");
        foreach (var student in students)
        {
            if (Convert.ToInt32(student.GetGradesExam()) <= 60)
            {
                Console.WriteLine($"{student.GetName()} ({student.GetGradesExam()})");
            }
        }
    }

    static void AddStudent(List<Student> students)
    {
        Console.WriteLine("Add student");

        Console.WriteLine("Enter student name:");
        string name = Console.ReadLine();

        Student newStudent = new Student();
        newStudent.SetName(name);

        students.Add(newStudent);
    }

    static void RemoveStudent(List<Student> students)
    {
        Console.WriteLine("Remove student");

        Console.WriteLine("Enter student name:");
        string name = Console.ReadLine();
        
        foreach (var student in students)
        {
            if (student.GetName() == name)
            {
                students.Remove(student);
            }
        }
    }

    delegate void FPTR(List<Student> students);
    
    static void Main(string[] args)
    {
        Console.WriteLine("Add student to the group => enter 0: \n" +
            "Remove student from the group => enter 1: \n" +
            "Show all all excellent students => enter 2: \n" +
            "Show all students who got bad grades on their exams => enter 3: \n");
        
        string userChoise = Console.ReadLine();

        bool userChoiseCorrect = int.TryParse(userChoise, out var value);

        if (!userChoiseCorrect || value < 0 || value > 3) 
            Console.WriteLine("Not correct choice... Please enter a number from 0 to 3");

        List<Student> students = new List<Student>();

        FPTR[] methods = { AddStudent, RemoveStudent, ShowBestStudents, ShowStudentsBadExam };

        methods[value](students);
    }
}
