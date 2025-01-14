namespace Delegate;

internal class Program
{
    static void ShowBestStudents()
    {
        Console.WriteLine("Show all best students");
    }
    static void ShowStudentsBadExam()
    {
        Console.WriteLine("Show not good students");
    }

    static void AddStudent()
    {
        Console.WriteLine("Add student");
    }

    static void RemoveStudent()
    {
        Console.WriteLine("Remove student");
    }

    delegate void FPTR();
    
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

        FPTR[] methods = { AddStudent, RemoveStudent, ShowBestStudents, ShowStudentsBadExam };
        methods[value]();
    }
}
