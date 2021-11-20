using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolMomentAPI.Models
{
    public class Teacher
    {
        public int TeacherId { get; set; }
        public String TeacherNumber { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }

        public Teacher()
        {
        }

        public Teacher(int teacherId, string teacherNumber, string firstName, string lastName)
        {
            TeacherId = teacherId;
            TeacherNumber = teacherNumber;
            FirstName = firstName;
            LastName = lastName;

        }
    }
}
