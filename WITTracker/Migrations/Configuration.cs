namespace WITTracker.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using WITTracker.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<WITTracker.DAL.WITContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "WITTracker.DAL.WITContext";
        }

        protected override void Seed(WITTracker.DAL.WITContext context)
        {
            var buildings = new List<Building>
            {
                new Building{Name = "Harper"},
                new Building{Name = "Mansueto"},
                new Building{Name = "Regenstein"},
                new Building{Name = "Cobb Hall"}
            };
            buildings.ForEach(b => context.Buildings.Add(b));
            context.SaveChanges();

            var rooms = new List<Room>
            {
                new Room{RoomNumber = "114", BuildingID = 1},
                new Room{RoomNumber = "168", BuildingID = 1},
                new Room{RoomNumber = "179", BuildingID = 1},
                new Room{RoomNumber = "A1", BuildingID = 2},
                new Room{RoomNumber = "A2", BuildingID = 2},
                new Room{RoomNumber = "B4", BuildingID = 3},
                new Room{RoomNumber = "368", BuildingID = 3},
                new Room{RoomNumber = "405", BuildingID = 3},
                new Room{RoomNumber = "538", BuildingID = 3},
            };
            rooms.ForEach(r => context.Rooms.Add(r));
            context.SaveChanges();

            var subjects = new List<Subject>
            {
                new Subject{Name = "Composite"},
                new Subject{Name = "English"},
                new Subject{Name = "Math"},
                new Subject{Name = "Writing"},
                new Subject{Name = "Reading"},
                new Subject{Name = "Science"}
            };
            subjects.ForEach(s => context.Subjects.Add(s));
            context.SaveChanges();

            var teachers = new List<Teacher>
            {
                new Teacher{FirstName = "Gamal",LastName = "DeWeever", 
                    Email = "gadeweever@uchicago.edu",SubjectID = 2, BuildingID = 2 },
                new Teacher{FirstName = "Pablo",LastName = "Picasso", 
                    Email = "bestartist1900s@microsoft.com",SubjectID = 6, BuildingID = 1 },
                new Teacher{FirstName = "Microsoft",LastName = "Sam", 
                    Email = "mrmonotone@uchicago.edu",SubjectID = 5, BuildingID = 3 }
            };
            teachers.ForEach(t => context.Teachers.Add(t));
            context.SaveChanges();

            var students = new List<Student>
            {
                new Student{FirstName = "Steve", LastName = "Ballmer",TeacherID = 1},
                new Student{FirstName = "Sebastian", LastName = "Bach", TeacherID = 3},
                new Student {FirstName = "Johann", LastName = "Hassler", TeacherID = 1}

            };
            students.ForEach(s => context.Students.Add(s));
            context.SaveChanges();

            var grades = new List<Grade>
            {
                new Grade{Score = 22, SubjectID = 1, StudentID = 1},
                new Grade{Score = 21, SubjectID = 2, StudentID = 1},
                new Grade{Score = 23, SubjectID = 3, StudentID = 1},
                new Grade{Score = 24, SubjectID = 4, StudentID = 1},
                new Grade{Score = 25, SubjectID = 5, StudentID = 1},
                new Grade{Score = 21, SubjectID = 6, StudentID = 1},
                new Grade{Score = 24, SubjectID = 1, StudentID = 2},
                new Grade{Score = 18, SubjectID = 2, StudentID = 2},
                new Grade{Score = 19, SubjectID = 3, StudentID = 2},
                new Grade{Score = 20, SubjectID = 4, StudentID = 2}, 
                new Grade{Score = 36, SubjectID = 5, StudentID = 2},
                new Grade{Score = 35, SubjectID = 6, StudentID = 2},
                new Grade{Score = 23, SubjectID = 1, StudentID = 3},
                new Grade{Score = 12, SubjectID = 2, StudentID = 3},
                new Grade{Score = 20, SubjectID = 3, StudentID = 3},
                new Grade{Score = 28, SubjectID = 4, StudentID = 3},
                new Grade{Score = 27, SubjectID = 5, StudentID = 3},
                new Grade{Score = 25, SubjectID = 6, StudentID = 3}
                
            };
            grades.ForEach(g => context.Grades.Add(g));
            context.SaveChanges();

            var posts = new List<Update>
            {
                new Update{TeacherID=1, Header="Moved Class!",Text="We have decided to have class in Cobb Hall today. Please do not go to the reg!", TimePosted= new DateTime(2014,12,15,6,45,22,0,DateTimeKind.Utc)},
                new Update{TeacherID=2, Header="Girl Scout Cookies!",Text="For the person who gains the most points, we will give you girl scout cookies!",TimePosted= new DateTime(2014,5,12,8,23,44,0,DateTimeKind.Utc)},
                new Update{TeacherID=1, Header="Teacher leaving!",Text="We are sad to say that Gamal will be leaving us next quarter. Make his life hell!", TimePosted= new DateTime(2014,4,4,1,19,1,0,DateTimeKind.Utc)}
            
            };
            posts.ForEach(p => context.Updates.Add(p));
            context.SaveChanges();
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
