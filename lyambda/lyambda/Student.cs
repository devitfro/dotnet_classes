using System;
using System.Collections.Generic;
using System.Linq;

namespace lyambda
{
    class Student
    {
        private string _name;
        private string _surname;
        private string _patronymic;
        private string _address;
        private string _telNumber;

        private DateTime _birthday;

        public List<int> _gradesCredit = new List<int>();
        public List<int> _gradesCourseWork = new List<int>();
        public List<int> _gradesExam = new List<int>();

        // c-tor
        public Student()
            : this("Name", "Surname", "Patronymic", DateTime.Now, "undefined", "undefined")
        {
        }

        public Student(string name, string surname, string patronymic, DateTime birthday, string address, string telNumber)
            : this(name, surname, patronymic, birthday, address, telNumber, new List<int>(), new List<int>(), new List<int>())
        {
        }

        // new c-tor with properties
        public Student(string name, string surname, string patronymic, DateTime birthday, string address, string telNumber,
                       List<int> gradesCredit, List<int> gradesCourseWork, List<int> gradesExam)
        {
            Name = name;
            Surname = surname;
            Patronymic = patronymic;
            Birthday = birthday;
            Address = address;
            TelNumber = telNumber;
            GradesCredit = gradesCredit;
            GradesCourseWork = gradesCourseWork;
            GradesExam = gradesExam;
        }

        // properties
        public string Name
        {
            get => _name;

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("Name cannot be null or empty.");
                    return;
                }
                _name = value;
            }
        }
        public string Surname
        {
            get => _surname;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Surname cannot be null or empty.");
                _surname = value;
            }
        }

        public string Patronymic
        {
            get => _patronymic;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Patronymic cannot be null or empty.");
                _patronymic = value;
            }
        }

        public string Address
        {
            get => _address;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Address cannot be null or empty.");
                _address = value;
            }
        }

        public string TelNumber
        {
            get => _telNumber;
            set
            {
                if (value.Length < 10 || value.Length > 15)
                    throw new ArgumentException("Telephone number must be between 10 and 15 characters long.");
                _telNumber = value;
            }
        }

        public DateTime Birthday
        {
            get => _birthday;
            set
            {
                DateTime today = DateTime.Now;

                if (value > today)
                    throw new ArgumentException("Birthday cannot be in the future.");

                int age = today.Year - value.Year;

                if (age < 15 || age > 100)
                    throw new ArgumentException("Age must be between 15 and 100 years.");
                _birthday = value;
            }
        }

        public List<int> GradesCredit
        {
            get => _gradesCredit;
            set
            {
                if (value == null)
                {
                    throw new ArgumentException("Grades list cannot be null.");
                }

                foreach (int grade in value)
                {
                    if (grade < 0 || grade > 100)
                    {
                        throw new ArgumentException("All grades must be between 0 and 100.");
                    }
                }
                _gradesCredit = new List<int>(value);
            }
        }

        public List<int> GradesCourseWork
        {
            get => _gradesCourseWork;

            set
            {
                if (value == null)
                {
                    throw new ArgumentException("Grades list cannot be null.");
                }

                foreach (int grade in value)
                {
                    if (grade < 0 || grade > 50)
                    {
                        throw new ArgumentException("All grades must be between 0 and 50.");
                    }
                }
                _gradesCourseWork = new List<int>(value);
            }
        }

        public List<int> GradesExam
        {
            get => _gradesExam;

            set
            {
                if (value == null)
                {
                    throw new ArgumentException("Grades list cannot be null.");
                }

                foreach (int grade in value)
                {
                    if (grade < 0 || grade > 100)
                    {
                        throw new ArgumentException("All grades must be between 0 and 100.");
                    }
                }

                _gradesExam = new List<int>(value);
            }
        }

        // setters
        public void SetName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Name cannot be null or empty.");
                return;
            }
            _name = name;
        }

        public void SetSurname(string surname)
        {
            if (string.IsNullOrWhiteSpace(surname))
            {
                Console.WriteLine("Surname cannot be null or empty.");
                return;
            }

            _surname = surname;
        }

        public void SetPatronymic(string patronymic)
        {
            if (string.IsNullOrWhiteSpace(patronymic))
            {
                Console.WriteLine("Patronymic cannot be null or empty.");
                return;
            }

            _patronymic = patronymic;
        }

        public void SetAddress(string address)
        {
            if (string.IsNullOrWhiteSpace(address))
            {
                Console.WriteLine("Address cannot be null or empty.");
                return;
            }

            _address = address;
        }

        public void SetTelNumber(string telNumber)
        {
            if (telNumber.Length < 10 || telNumber.Length > 15)
            {
                Console.WriteLine("Telephone number must be between 10 and 15 characters long.");
                return;
            }

            _telNumber = telNumber;
        }

        public void SetBirthday(DateTime birthday)
        {
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

            _birthday = birthday;
        }

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

        public void SetGradesCourseWork(List<int> grades)
        {
            if (grades == null)
            {
                grades = new List<int>();
                Console.WriteLine("Grades list is empty!");
            }

            foreach (int grade in grades)
            {
                if (grade >= 0 && grade <= 50)
                {
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
            $"Phone number: {_telNumber}\n" +
            $"Grades credit: {string.Join(", ", _gradesCredit)}\n" +
            $"Grades course work: {string.Join(", ", _gradesCourseWork)}\n" +
            $"Grades exam: {string.Join(", ", _gradesExam)}";

        public void ShowStudent()
        {
            Console.WriteLine(ToString());
        }

        public double GetAverageGrade() => _gradesExam.Average();

        // overload operators
        public static bool operator true(Student student) => student.GetAverageGrade() >= 70;

        public static bool operator false(Student student) => student.GetAverageGrade() < 70;

        public static bool operator >(Student s1, Student s2) => s1.GetAverageGrade() > s2.GetAverageGrade();

        public static bool operator <(Student s1, Student s2) => s1.GetAverageGrade() < s2.GetAverageGrade();

        public static bool operator ==(Student s1, Student s2) => s1.GetAverageGrade() == s2.GetAverageGrade();

        public static bool operator !=(Student s1, Student s2) => s1.GetAverageGrade() != s2.GetAverageGrade();

  
    }
}



