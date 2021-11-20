using Microsoft.EntityFrameworkCore;
using SchoolMomentAPI.Builders;
using SchoolMomentAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolMomentAPI.Data
{
    public class SchoolContext :DbContext
    {
        public DbSet<Student> Students { get; set; }

        public DbSet<Teacher> Teachers { get; set; }
       
        public DbSet<Moment> Moments { get; set; }
        

        public SchoolContext(DbContextOptions options) : base (options)
        {
            EnsureIsMigrated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().Property(x => x.StudentNumber).IsRequired().HasMaxLength(10).IsUnicode();
            modelBuilder.Entity<Teacher>().Property(x => x.TeacherNumber).IsRequired().HasMaxLength(10).IsUnicode();
            modelBuilder.Entity<Moment>().Property(x => x.Category).HasConversion(x => (int)x, x => (Category)x);
            
            //seeding data
            //for (int i = 0; i < 10; i++)
            //{
            //    modelBuilder.Entity<Student>().HasData(
            //        StudentBuilder.CreateStudent()
            //    );
            //}

            //for (int i = 0; i < 10; i++)
            //{
            //    modelBuilder.Entity<Teacher>().HasData(
            //        TeacherBuilder.Createteacher()
            //    );
            //}

            ////for (int i = 0; i < 10; i++)
            ////{
            //    modelBuilder.Entity<Moment>().HasData(
            //        );
            //}
        }
        public void EnsureIsMigrated()
        {
            if (Database.GetPendingMigrations().Any())
            {
                Database.Migrate();
            }
        }
    }
}
