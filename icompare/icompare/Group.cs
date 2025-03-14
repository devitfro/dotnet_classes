﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace icompare
{
    class Group : IEnumerable<Student>
    {
        private List<Student> _students;
        private string _groupName;
        private string _groupSpecialist;
        private int _courseNumber;

        // c-tor
        public Group() : this("Default Group", "Default Specialist", 1, new List<Student>()) { }

        public Group(string groupName, string groupSpecialist, int courseNumber, List<Student> students)
        {
            GroupName = groupName;
            GroupSpecialist = groupSpecialist;
            CourseNumber = courseNumber;
            Students = students;
        }

        // properties
        public string GroupName
        {
            get => _groupName;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Group name cannot be null or empty.");
                _groupName = value;
            }
        }

        public string GroupSpecialist
        {
            get => _groupSpecialist;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Specialist field cannot be null or empty.");
                _groupSpecialist = value;
            }
        }

        public int CourseNumber
        {
            get => _courseNumber;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Course number must be a positive integer.");
                _courseNumber = value;
            }
        }

        public List<Student> Students
        {
            get => _students;
            set
            {
                if (value == null)
                    throw new ArgumentException("Student list cannot be null.");
                _students = new List<Student>(value);
            }
        }

        // methods
        public override string ToString()
        {
            return $"Group Name: {GroupName}\n" +
                   $"Specialist: {GroupSpecialist}\n" +
                   $"Course: {CourseNumber}\n" +
                   $"Students:\n{string.Join("\n", Students)}";
        }

        // homework
        public void Sort(IComparer<Student> comparer) => _students.Sort(comparer);

        public void Display()
        {
            foreach (var student in _students)
            {
                Console.WriteLine(student);
            }
        }

        public IEnumerator<Student> GetEnumerator() => _students.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}