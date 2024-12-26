using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tkpo_lab6
{
    public class CourseController
    {
        private readonly CourseModel _model;

        public CourseController(CourseModel model)
        {
            _model = model;
        }

        public void AddStudent(string studentName)
        {
            _model.AddStudent(studentName);
        }

        public void RemoveStudent(int studentIndex)
        {
            _model.RemoveStudent(studentIndex);
        }

        public void AddGrade(int studentIndex, int grade)
        {
            _model.AddGrade(studentIndex, grade);
        }
    }
}
