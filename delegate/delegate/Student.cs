using System.Reflection;
using System.Xml.Linq;

namespace Delegate;

class Student
{
    private string _name;
    private string _surname;
    private string _patronymic;
    private string _address;
    private string _telNumber;

    private DateTime _birthday;

    private List<int> _gradesExam = new List<int>();

    // c-tor
    public Student()
        : this("Name", "Surname", "Patronymic", DateTime.Now, "undefined", "undefined", new List<int>())
    {
    }

    public Student(string name, string surname, string patronymic, DateTime birthday, string address, string telNumber)
        : this(name, surname, patronymic, birthday, address, telNumber, new List<int>())
    {
    }

    public Student(string name, string surname, string patronymic, DateTime birthday, string address, string telNumber, List<int> grades)
    {
        SetName(name);
        SetSurname(surname);
        SetPatronymic(patronymic);
        SetBirthday(birthday);
        SetAddress(address);
        SetTelNumber(telNumber);
        SetGradesExam(grades);
    }

    // setters
    public void SetName(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            Console.WriteLine("Name cannot be null or empty.");
            return;
        }
        this._name = name;
    }
        
    public void SetSurname(string surname)
    {
        if (string.IsNullOrWhiteSpace(surname))
        {
            Console.WriteLine("Surname cannot be null or empty.");
            return;
        }

        this._surname = surname;
    }    

    public void SetPatronymic(string patronymic)
    {
        if (string.IsNullOrWhiteSpace(patronymic))
        {
            Console.WriteLine("Patronymic cannot be null or empty.");
            return;
        }

        this._patronymic = patronymic;
    }
     

    public void SetAddress(string address)
    {
        if (string.IsNullOrWhiteSpace(address))
        {
            Console.WriteLine("Address cannot be null or empty.");
            return;
        }

        this._address = address;
    }
        

    public void SetTelNumber(string telNumber)
    {
        if (telNumber.Length < 10 || telNumber.Length > 15)
        {
            Console.WriteLine("Telephone number must be between 10 and 15 characters long.");
            return;
        }

        this._telNumber = telNumber;
    }

    public void SetBirthday(DateTime birthday) {
        DateTime today = DateTime.Now;

        if (birthday > today)
        {
            Console.WriteLine("Birthday cannot be in the future.");
            return;
        }

        int age = today.Year - birthday.Year;

        if (age < 15 || age > 100)
        {
            Console.WriteLine("Maybe not correct..");
            return;
        }

        this._birthday = birthday;
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

    public List<int> GetGradesExam() => _gradesExam;

    public override string ToString() =>
        $"Surname: {_surname}\n" +
        $"Name: {_name}\n" +
        $"Patronymic: {_patronymic}\n" +
        $"Birthday:" +
        $" {_birthday}\n" +
        $"Address: {_address}\n" +
        $"Phone number: {_telNumber}";

    // methods
    public void ShowStudent()
    {
        Console.WriteLine(ToString());
        Console.WriteLine("Grades exam: " + string.Join(", ", _gradesExam));
    }
}
