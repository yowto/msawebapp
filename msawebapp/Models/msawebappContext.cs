using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace msawebapp.Models
{
   // [DbConfigurationType(typeof(MySql.Data.Entity.MySqlEFConfiguration))]
    public class msawebappContext : DbContext
    {
        public class MyConfiguration : DbMigrationsConfiguration<msawebappContext>
        {
            public MyConfiguration()
            {
                this.AutomaticMigrationsEnabled = true;
            }

            protected override void Seed(msawebappContext context)
            {
                var students = new List<Student>
            {
                new Student { FirstMidName = "Carson",   LastName = "Alexander",
                    EnrollmentDate = DateTime.Parse("2010-09-01") },
                new Student { FirstMidName = "Meredith", LastName = "Alonso",
                    EnrollmentDate = DateTime.Parse("2012-09-01") },
                new Student { FirstMidName = "Arturo",   LastName = "Anand",
                    EnrollmentDate = DateTime.Parse("2013-09-01") },
                new Student { FirstMidName = "Gytis",    LastName = "Barzdukas",
                    EnrollmentDate = DateTime.Parse("2012-09-01") },
                new Student { FirstMidName = "Yan",      LastName = "Li",
                    EnrollmentDate = DateTime.Parse("2012-09-01") },
                new Student { FirstMidName = "Peggy",    LastName = "Justice",
                    EnrollmentDate = DateTime.Parse("2011-09-01") },
                new Student { FirstMidName = "Laura",    LastName = "Norman",
                    EnrollmentDate = DateTime.Parse("2013-09-01") },
                new Student { FirstMidName = "Nino",     LastName = "Olivetto",
                    EnrollmentDate = DateTime.Parse("2005-08-11")}
            };
                students.ForEach(s => context.Students.AddOrUpdate(p => p.LastName, s));
                context.SaveChanges();

                var courses = new List<Course>
            {
                new Course {CourseID = 1050, Title = "Chemistry",      Credits = 3, PercentComplete= 0},
                new Course {CourseID = 4022, Title = "Microeconomics", Credits = 3, PercentComplete= 0},
                new Course {CourseID = 4041, Title = "Macroeconomics", Credits = 3, PercentComplete= 0},
                new Course {CourseID = 1045, Title = "Calculus",       Credits = 4, PercentComplete= 0},
                new Course {CourseID = 3141, Title = "Trigonometry",   Credits = 4, PercentComplete= 0},
                new Course {CourseID = 2021, Title = "Composition",    Credits = 3, PercentComplete= 0},
                new Course {CourseID = 2042, Title = "Literature",     Credits = 4, PercentComplete= 0}
            };
                courses.ForEach(s => context.Courses.AddOrUpdate(p => p.Title, s));
                context.SaveChanges();

                var assignments = new List<Assignment>
                {
                    new Assignment {AssignmentID = 1, AssignmentName="a1", AssignmentPercent=10, CourseID=1045, StudentID= students.Single(s=>s.LastName=="Alexander").ID, DueDate = DateTime.Parse("2005-08-11") },
                    new Assignment {AssignmentID = 2, AssignmentName="a2",AssignmentPercent=20, CourseID=1045, StudentID= students.Single(s=>s.LastName=="Alexander").ID , DueDate = DateTime.Parse("2005-08-11")},
                    new Assignment {AssignmentID = 3, AssignmentName="a3",AssignmentPercent=30, CourseID=1045, StudentID= students.Single(s=>s.LastName=="Alexander").ID , DueDate = DateTime.Parse("2005-08-11")},
                    new Assignment {AssignmentID = 4, AssignmentName="a4",AssignmentPercent=10, CourseID=1045, StudentID= students.Single(s=>s.LastName=="Alexander").ID, DueDate = DateTime.Parse("2005-08-11") },
                    new Assignment {AssignmentID = 5, AssignmentName="a5",AssignmentPercent=10, CourseID=1045, StudentID= students.Single(s=>s.LastName=="Alexander").ID , DueDate = DateTime.Parse("2005-08-11")},
                    new Assignment {AssignmentID = 6, AssignmentName="a6",AssignmentPercent=10, CourseID=1045, StudentID= students.Single(s=>s.LastName=="Alexander").ID , DueDate = DateTime.Parse("2005-08-11")},
                    new Assignment {AssignmentID = 7, AssignmentName="a7",AssignmentPercent=10, CourseID=1045, StudentID= students.Single(s=>s.LastName=="Alexander").ID, DueDate = DateTime.Parse("2005-08-11") }


                };
                assignments.ForEach(s => context.Assignments.AddOrUpdate(p=> p.AssignmentName, s));
                context.SaveChanges();

                var enrollments = new List<Enrollment>
            {
                new Enrollment {
                    StudentID = students.Single(s => s.LastName == "Alexander").ID,
                    CourseID = courses.Single(c => c.Title == "Chemistry" ).CourseID,
                    Grade = Grade.A
                },
                 new Enrollment {
                    StudentID = students.Single(s => s.LastName == "Alexander").ID,
                    CourseID = courses.Single(c => c.Title == "Microeconomics" ).CourseID,
                    Grade = Grade.C
                 },
                 new Enrollment {
                    StudentID = students.Single(s => s.LastName == "Alexander").ID,
                    CourseID = courses.Single(c => c.Title == "Macroeconomics" ).CourseID,
                    Grade = Grade.B
                 },
                 new Enrollment {
                     StudentID = students.Single(s => s.LastName == "Alonso").ID,
                    CourseID = courses.Single(c => c.Title == "Calculus" ).CourseID,
                    Grade = Grade.B
                 },
                 new Enrollment {
                     StudentID = students.Single(s => s.LastName == "Alonso").ID,
                    CourseID = courses.Single(c => c.Title == "Trigonometry" ).CourseID,
                    Grade = Grade.B
                 },
                 new Enrollment {
                    StudentID = students.Single(s => s.LastName == "Alonso").ID,
                    CourseID = courses.Single(c => c.Title == "Composition" ).CourseID,
                    Grade = Grade.B
                 },
                 new Enrollment {
                    StudentID = students.Single(s => s.LastName == "Anand").ID,
                    CourseID = courses.Single(c => c.Title == "Chemistry" ).CourseID
                 },
                 new Enrollment {
                    StudentID = students.Single(s => s.LastName == "Anand").ID,
                    CourseID = courses.Single(c => c.Title == "Microeconomics").CourseID,
                    Grade = Grade.B
                 },
                new Enrollment {
                    StudentID = students.Single(s => s.LastName == "Barzdukas").ID,
                    CourseID = courses.Single(c => c.Title == "Chemistry").CourseID,
                    Grade = Grade.B
                 },
                 new Enrollment {
                    StudentID = students.Single(s => s.LastName == "Li").ID,
                    CourseID = courses.Single(c => c.Title == "Composition").CourseID,
                    Grade = Grade.B
                 },
                 new Enrollment {
                    StudentID = students.Single(s => s.LastName == "Justice").ID,
                    CourseID = courses.Single(c => c.Title == "Literature").CourseID,
                    Grade = Grade.B
                 }
            };

                foreach (Enrollment e in enrollments)
                {
                    var enrollmentInDataBase = context.Enrollments.Where(
                        s =>
                             s.Student.ID == e.StudentID &&
                             s.Course.CourseID == e.CourseID).SingleOrDefault();
                    if (enrollmentInDataBase == null)
                    {
                        context.Enrollments.Add(e);
                    }
                }
                context.SaveChanges();
            }

        }

        public msawebappContext() : base("name=msawebappContext")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<msawebappContext, MyConfiguration>());

        }

        public System.Data.Entity.DbSet<msawebapp.Models.Student> Students { get; set; }

        public System.Data.Entity.DbSet<msawebapp.Models.Enrollment> Enrollments { get; set; }

        public System.Data.Entity.DbSet<msawebapp.Models.Course> Courses { get; set; }

        public System.Data.Entity.DbSet<msawebapp.Models.Assignment> Assignments { get; set; }

        public System.Data.Entity.DbSet<msawebapp.Models.Test> Tests { get; set; }
    }
}
