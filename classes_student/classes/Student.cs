namespace ClassesStudent;

class Student
{
    private string _name;
    private string _surname;
    private string _patronymic;
    private string _address;
    private string _telNumber;

    private DateTime _birthday;

    private List<int> _gradesCredit = new List<int>();
    private List<int> _gradesCourseWork = new List<int>();
    private List<int> _gradesExam = new List<int>();

    // c-tor
    public Student()
    {
        SetName("Name");
        SetSurname("Surname");
        SetPatronymic("Patronymic");
        SetBirthday(DateTime.Now);
        SetAddress("undefined");
        SetTelNumber("undefined");
    }

    public Student(string name, string surname, string patronymic, DateTime birthday, string address, string telNumber)
    {
        this._name = name; 
        this._surname = surname;
        this._patronymic = patronymic;
        this._birthday = birthday;
        this._address = address;
        this._telNumber = telNumber;
    }
    public Student(string name, string surname, string patronymic, DateTime birthday, string address, string telNumber, List<int> grades)
    {
        this._name = name;
        this._surname = surname;
        this._patronymic = patronymic;
        this._birthday = birthday;
        this._address = address;
        this._telNumber = telNumber;
        this._gradesExam = new List<int>();
    }

    // setters
    public void SetName(string name) => 
        this._name = name;

    public void SetSurname(string surname) => 
        this._surname = surname;

    public void SetPatronymic(string patronymic) => 
        this._patronymic = patronymic;

    public void SetAddress(string address) => 
        this._address = address;

    public void SetTelNumber(string telNumber) => 
        this._telNumber = telNumber;

    public void SetBirthday(DateTime birthday) => 
        this._birthday = birthday;

    public void SetGradesCredit(List<int> grades)
    {
        if (grades == null)
        {
            grades = new List<int>();
            Console.WriteLine("Grades list is empty!");
        }

        foreach (int grade in grades)
        {
            if (grade >= 0 && grade <= 100)
            {
                _gradesCredit.Add(grade);
            }
        }
    }

    public void SetGradeCourseWork(List<int> grades)
    {
        if (grades == null)
        {
            grades = new List<int>();
            Console.WriteLine("Grades list is empty!");
        }

        foreach (int grade in grades)
        {
            if (grade >= 0 && grade <= 50) {
                _gradesCourseWork.Add(grade);
            }
        } 
    }

    public void SetGradesExam(List<int> grades)
    {
        if (grades == null)
        {
            grades = new List<int>();
            Console.WriteLine("Grades list is empty!");
        }

        foreach (int grade in grades)
        {
            if (grade >= 0 && grade <= 100)
            {
                _gradesExam.Add(grade);
            }
        }
    }

    // getters
    public string GetName() => _name;

    public string GetSurname() => _surname;

    public string GetPatronymic() => _patronymic;

    public string GetAddress() => _address;

    public string GetTelNumber() => _telNumber;

    public DateTime GetBirthday() => _birthday;

    public List<int> GetGradesCredit() => _gradesCredit;

    public List<int> GetGradesCourseWork() => _gradesCourseWork;

    public List<int> GetGradesExam() => _gradesExam;

    public override string ToString() => 
        $"Surname: {_surname}\n" +
        $"Name: {_name}\n" +
        $"Patronymic: {_patronymic}\n" +
        $"Birthday:" +
        $" {_birthday}\n" +
        $"Address: {_address}\n" +
        $"Phone number: {_telNumber}";

    public void ShowStudent()
    {
        Console.WriteLine(ToString());
        Console.WriteLine("Grades credit: " + string.Join(", ", _gradesCredit));
        Console.WriteLine("Grades course work: " + string.Join(", ", _gradesCourseWork));
        Console.WriteLine("Grades exam: " + string.Join(", ", _gradesExam));
    }
}
