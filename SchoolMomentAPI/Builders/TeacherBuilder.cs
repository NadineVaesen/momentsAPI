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
        private static int StartTeacherNumber = 0000000000;
        private static int AddNumberToName = 0;

        public static Teacher Createteacher()
        {
            int id = TeacherId;
            TeacherId++;
            String studentNumber = CreateTeacherNumber();
            String firstName = "Teacher" + AddNumberToName.ToString();
            String lastName = "LastName";
            AddNumberToName++;
            Teacher teacher = new Teacher(id, studentNumber, firstName, lastName);
            return teacher;
        }

        public static String CreateTeacherNumber()
        {
            StartTeacherNumber += 1;
            return StartTeacherNumber.ToString();
        }
    }
}
