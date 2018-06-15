using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MosalaSchool.Models;

namespace MosalaSchool.DAL
{
    public class SchoolInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<SchoolContext>
    {
        protected override void Seed(SchoolContext context)
        {

            var students = new List<Student>
        {
           new Student { Name = "Relebohile",
            LastName = "Biza",
            EnrollmentDate =DateTime.Parse( "2010-02-01") },
           new Student { Name = "Ishmael",
            LastName = "Biza",
            EnrollmentDate =DateTime.Parse( "2010-02-01") },
           new Student { Name = "Matlale",
            LastName = "Biza",
            EnrollmentDate =DateTime.Parse( "2010-02-01") },
           new Student { Name = "Chuku",
            LastName = "Biza",
            EnrollmentDate =DateTime.Parse( "2010-02-01") }
        };

            students.ForEach(s => context.Student.Add(s));
            context.SaveChanges();

            var courses = new List<Course>
        {
            new Course{ ID= 2020,
            Title="Informatics",
            Credits = 20, },
            new Course{ ID= 2021,
            Title="Economics",
            Credits = 20,},
            new Course{ ID= 2022,
            Title="Accounting",
            Credits = 20, },
            new Course{ ID= 2023,
            Title="Computer Science",
            Credits = 20, },
        };
            courses.ForEach(s => context.Course.Add(s));
            context.SaveChanges();

            var enrollments = new List<Enrollment>
            {
                new Enrollment {
                    StudentID=1,
                    CourseID=2020,
                    Grade= Grade.A,},
                new Enrollment {
                    StudentID=1,
                    CourseID=2023,
                    Grade= Grade.B,},
                new Enrollment {
                    StudentID=2,
                    CourseID=2020,
                    Grade= Grade.C,},
                new Enrollment {
                    StudentID=3,
                    CourseID=2022,
                    Grade= Grade.A,},
            };
            enrollments.ForEach(s => context.Enrollment.Add(s));
            context.SaveChanges();


    }
    }
}