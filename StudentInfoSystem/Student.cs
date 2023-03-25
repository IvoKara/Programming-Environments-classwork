using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoSystem
{
    internal class Student
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }

        public string Faculty { get; set; }
        public string Speciality { get; set; }
        public string Degree { get; set; }
        public string Status { get; set; }

        public string FacultyNumber { get; set; }
        public int Course { get; set;}
        public int Stream { get; set; }
        public int GroupNumber { get; set; }

        public override string ToString()
        {
            return $"FirstName: {FirstName}\n" +
                $"LastName: {LastName}\n" +
                $"MiddleName: {MiddleName}\n" +
                $"Faculty: {Faculty}\n" +
                $"Speciality: {Speciality}\n" +
                $"Degree: {Degree}\n" +
                $"Status: {Status}\n" +
                $"FacultyNumber: {FacultyNumber}\n" + 
                $"Course: {Course}\n" +
                $"Stream: {Stream}\n" +
                $"GroupNumber: {GroupNumber}\n";
        }
    }

}
