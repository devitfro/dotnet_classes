namespace ClassesStudent;

internal class Program
{
    static void Main(string[] args)
    {
        Student st = new Student();
        Console.WriteLine(st.GetName());

        List<int> gradesCredit = new List<int>() { 5, 5, 5 };
        List<int> gradesCourseWork = new List<int>() { 125, 25, 35 };
        List<int> gradesExam = new List<int>() { 100, 90, 98, 100, 99 };

        st.SetGradesCredit(gradesCredit);
        st.SetGradesCredit(gradesCourseWork);
        st.SetGradesCredit(gradesExam);

        st.ShowStudent();

    }
}
