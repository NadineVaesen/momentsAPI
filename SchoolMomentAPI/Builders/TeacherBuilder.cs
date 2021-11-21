using SchoolMomentAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolMomentAPI.Builders
{
    public static class TeacherBuilder
    {
        private static int TeacherId = 1;
        private static int StartTeacherNumber = 1000000000;
        private static int AddNumberToName = 0;

        public static Teacher Createteacher()
        {
            int id = TeacherId;
            TeacherId++;
            String teacherNumber = CreateTeacherNumber();
            String firstName = "Teacher" + AddNumberToName.ToString();
            String lastName = "LastName";
            AddNumberToName++;
            String password = teacherNumber + "@pxl";
            Teacher teacher = new Teacher(id, teacherNumber, firstName, lastName, password);
            return teacher;
        }

        public static String CreateTeacherNumber()
        {
            StartTeacherNumber += 1;
            return StartTeacherNumber.ToString();
        }
    }
}
