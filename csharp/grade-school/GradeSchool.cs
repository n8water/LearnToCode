using System;
using System.Collections.Generic;
using System.Linq;

public class GradeSchool
{
    private List<Student> studentList = new List<Student>();
    public void Add(string student, int grade)
    {
        studentList.Add(new Student(student, grade));
    }

    public IEnumerable<string> Roster()
    {
        var sortedList = studentList.OrderBy(s=>s.Grade).ThenBy(s => s.Name).Select(s=>s.Name);

        return sortedList;
    }

    public IEnumerable<string> Grade(int grade)
    {
        var studentsInGrade = studentList.Where(s => s.Grade.Equals(grade)).OrderBy(s=>s.Name).Select(s => s.Name);

        return studentsInGrade;
    }

    public class Student
    {
        public string Name { get;  }
        public int Grade { get; }

        public Student(string student, int grade)
        {
            Name = student;
            Grade = grade;
        }

    }
}