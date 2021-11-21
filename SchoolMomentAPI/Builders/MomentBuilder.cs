using SchoolMomentAPI.Data;
using SchoolMomentAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolMomentAPI.Builders
{
    public static class MomentBuilder
    {
        private static int MomentId = 1;
        private static int AddNumberToName = 0;
        private static readonly Random Random = new Random();
        private static SchoolContext _schoolContext;
        private static int TeacherIdMoment = 1;

        public static Moment CreateMoment()
        {
            int id = MomentId;
            MomentId++;
            String name = "Moment" + AddNumberToName.ToString();
            AddNumberToName++;

            Category category = GetRandomCategory();
            DateTime dateTime = GetRandomDate();
            int duration = 2;

            List<Student> requestedStudents = new List<Student>();
            List<Student> attendedStudents = new List<Student>();


            //string name, Category category, DateTime dateTime, int duration,
            //Teacher teacher, List<Student> requestedStudents, List<Student> attendedStudents
            Moment moment = new Moment(id, name, category, dateTime, duration,  requestedStudents, attendedStudents);
            return moment;
        }

        private static DateTime GetRandomDate()
        {
            return DateTime.Now.AddDays(Random.Next(10));
        }

        public static Category GetRandomCategory()
        {

            var values = Enum.GetValues(typeof(Category));

            return (Category)values.GetValue(Random.Next(values.Length));

        }
    }
}
