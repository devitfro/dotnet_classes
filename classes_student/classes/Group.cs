namespace ClassesStudent;

class Group
{
    private List<Student> _students;

    private string _groupName;
    private string _groupSpecialist;
    private int _courseNumber;

    // c-tor
    public Group()
    {
        _students = new List<Student>();
    }

    // setters
    public void SetGroupName(string groupName) =>
        _groupName = groupName;

    public void SetGroupSpecialist(string groupSpecialist) =>
        _groupSpecialist = groupSpecialist;

    public void SetCourseNumber(int courseNumber) =>
       _courseNumber = courseNumber;

    // getters
    public string GetGroupName() => _groupName;

    public string GetGroupSpecialist() => _groupSpecialist;

    public int GetCourseNumber() => _courseNumber;

    // methods
    public void ShowGroup()
    {
        Console.WriteLine($"Group: {_groupName}, Specialisation: {_groupSpecialist}, Course: {_courseNumber}");

        Console.WriteLine("Students:");

        _students.Sort((s1, s2) => string.Compare(s1.GetSurname(), s2.GetSurname(), StringComparison.Ordinal));

        for (int i = 0; i < _students.Count; i++)
        {
            Console.WriteLine($"{i + 1}.{_students[i].GetSurname()} {_students[i].GetName()}");
        }  
    }

    public void AddStudent(Student student)
    {
        _students.Add(student);
    }

    public void EditStudentData(Student student, string surname, string addess, string telNumber)
    {
        student.SetSurname(surname);
        student.SetAddress(addess);
        student.SetTelNumber(telNumber);
    }

    public void RemoveStudent(List<Student> students)
    {
        foreach (Student student in students)
        {         
            if (!CheckGradeExam(student, student.GetGradesExam()))
            {
                students.Remove(student);
            }
        }
    }

    public void RemoveStudentsWithLowGrades()
    {
        _students = _students.Where(student => CheckGradeExam(student, student.GetGradesExam())).ToList();
    }

    public bool CheckGradeExam(Student student, List<int> gradesExam)
    {

        if (gradesExam == null || gradesExam.Count == 0)
            return false;

        int gradeSum = 0;

        foreach(int grade in gradesExam)
        {
            gradeSum += grade;
        }

        double avgGrade = gradeSum / gradesExam.Count;

        return avgGrade >= 50;
    }
}
