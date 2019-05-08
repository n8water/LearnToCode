using System;
using System.Collections.Generic;
using System.Linq;

public class GradeSchool
{
    Dictionary<string, int> studentGrade = new Dictionary<string, int>();
    public void Add(string student, int grade)
    {
        studentGrade.Add(student, grade);
    }

    public IEnumerable<string> Roster()
    {
        List<string> students = new List<string>();



        //var students = studentGrade.Where((k, v) => )

        return students;
  
    }

    public IEnumerable<string> Grade(int grade)
    {
        throw new NotImplementedException("You need to implement this function.");
    }
}