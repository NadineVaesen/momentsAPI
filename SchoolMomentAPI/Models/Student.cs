using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolMomentAPI.Models
{
    public class Student
    {

        public int StudentId { get; set; }
        public String StudentNumber { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }

        public Student()
        {
        }

        public Student(int studentId, string studentNumber, string firstName, string lastName)
        {
            StudentId = studentId;
            StudentNumber = studentNumber;
            FirstName = firstName;
            LastName = lastName;

        }
    }
}
