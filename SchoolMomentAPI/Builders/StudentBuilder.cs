using SchoolMomentAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolMomentAPI.Builders
{
    public static class StudentBuilder
    {

        private static int StudentId = 1;
        private static int StartStudentNumber = 10000000;
        private static int AddNumberToName = 0;

        public static Student CreateStudent()
        {
            int id = StudentId;
            StudentId++;
            String studentNumber = CreateStudentNumber();
            String firstName = "Student" + AddNumberToName.ToString();
            String lastName = "LastName";
            AddNumberToName++;
            String password = studentNumber + "@pxl";
            Student student = new Student(id, studentNumber, firstName, lastName, password);
            return student;
        }
        public static String CreateStudentNumber()
        {
            StartStudentNumber += 1;
            return StartStudentNumber.ToString();
        }
    }
}
