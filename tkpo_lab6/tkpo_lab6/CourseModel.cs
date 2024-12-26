using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace tkpo_lab6
{
    public class Student
    {
        public Student(string studentName) 
        { 
            Name = studentName;
            Grade = 0;
        }
        public string Name { get; set; }
        public int Grade { get; set; }
    }
    public class CourseModel : Observable
    {
        public string CourseName { get; set; }
        public List<Student> Students { get; private set; }

        public CourseModel(string courseName)
        {
            CourseName = courseName;
            Students = new List<Student>();
        }

        public void AddStudent(string studentName)
        {
            Students.Add(new Student(studentName));
            NotifyUpdate();
        }

        public void RemoveStudent(int studentIndex)
        {
            Students.RemoveAt(studentIndex);
            NotifyUpdate();
        }

        public void AddGrade(int studentIndex, int grade)
        {
            Students[studentIndex].Grade = grade;
            NotifyUpdate();
        }
    }
}
