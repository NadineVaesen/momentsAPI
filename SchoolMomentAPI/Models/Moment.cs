using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolMomentAPI.Models
{
    public class Moment
    {
        public int MomentId { get; set; }
        public String Name { get; set; }
        public Category Category { get; set; }
        public DateTime DateTime { get; set; }
        public int Duration { get; set; }
        //duration in hours
        public Teacher Teacher { get; set; }
        public List<Student> RequestedStudents { get; set; }
        public List<Student> AttendedStudents { get; set; }

        public Moment()
        {
        }

        public Moment(int momentId, string name, Category category, DateTime dateTime, int duration, Teacher teacher, List<Student> requestedStudents, List<Student> attendedStudents)
        {
            MomentId = momentId;
            Name = name;
            Category = category;
            DateTime = dateTime;
            Duration = duration;
            Teacher = teacher;
            RequestedStudents = requestedStudents;
            AttendedStudents = attendedStudents;
        }
    }
}
