using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserLogin;

namespace StudentInfoSystem
{
    internal class StudentValidation
    {
        public Student GetStudentDataByUser(User user)
        {
            if (String.IsNullOrEmpty(user.FacultyNumber))
                throw new Exception("User do not have faculty number!");

            Student? student = (
                from testStudent in StudentData.TestStudents
                where testStudent.FacultyNumber == user.FacultyNumber
                select testStudent
            ).FirstOrDefault();

            if (student == null)
                throw new Exception("No such student with given user information!");

            return student;

        }
    }
}
