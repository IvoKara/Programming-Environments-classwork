using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoSystem
{
    internal static class StudentData
    {
        public static List<Student> TestStudents
        {
            get
            {
                Student student = new Student();
                student.FirstName = "Peter";
                student.MiddleName = "Petrov";
                student.LastName = "Popov";
                student.Faculty = "FCST";
                student.Speciality = "CSE";
                student.Degree = "bachelor";
                student.Status = "paid";
                student.FacultyNumber = "121220012";
                student.Course = 3;
                student.Stream = 9;
                student.GroupNumber = 43;

                return new List<Student>() { student };
            }
            set { }
        }
    }
}
