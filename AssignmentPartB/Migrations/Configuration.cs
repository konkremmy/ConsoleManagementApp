namespace AssignmentPartB.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Runtime.Remoting.Contexts;
    using AssignmentPartB.Entities;
    using AssignmentPartB.MyDatabase;
   
    internal sealed class Configuration : DbMigrationsConfiguration<AssignmentPartB.MyDatabase.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }
        protected override void Seed(AssignmentPartB.MyDatabase.ApplicationDbContext db)
        {

            #region Seeding Students
            Student s1 = new Student()
            {    
                FirstName = "Konstantinos",
                LastName = "Kremmydas",
                DateOfBirth = new DateTime(1994, 12, 04),
                TuitionFees = 10000
            };          
            Student s2 = new Student()
            {
                FirstName = "Dimitris",
                LastName = "Kremmydas",
                DateOfBirth = new DateTime(1995, 12, 04),
                TuitionFees = 20000
            };
            Student s3 = new Student()
            {
                FirstName = "Alexandros",
                LastName = "Kremmydas",
                DateOfBirth = new DateTime(1996, 12, 04),
                TuitionFees = 30000
            };
            Student s4 = new Student()
            {
                FirstName = "Aristidis",
                LastName = "Kremmydas",
                DateOfBirth = new DateTime(1954, 12, 04),
                TuitionFees = 40000
            };
            Student s5 = new Student()
            {
                FirstName = "Giorgos",
                LastName = "Tsirimokos",
                DateOfBirth = new DateTime(1997, 12, 04),
                TuitionFees = 50000
            };
            Student s6 = new Student()
            {
                FirstName = "Stauros",
                LastName = "Gouleas",
                DateOfBirth = new DateTime(1998, 12, 04),
                TuitionFees = 60000
            };
            Student s7 = new Student()
            {
                FirstName = "Paulos",
                LastName = "Kontaras",
                DateOfBirth = new DateTime(1999, 12, 04),
                TuitionFees = 70000
            };
            Student s8 = new Student()
            {
                FirstName = "Yannis",
                LastName = "Papadopouloss",
                DateOfBirth = new DateTime(2000, 12, 04),
                TuitionFees = 80000
            };
            Student s9 = new Student()
            {
                FirstName = "Vasilhs",
                LastName = "Miskakhs",
                DateOfBirth = new DateTime(2001, 12, 04),
                TuitionFees = 90000
            };
            Student s10 = new Student()
            {
                FirstName = "Riana",
                LastName = "Kotsiafiti",
                DateOfBirth = new DateTime(2002, 12, 04),
                TuitionFees = 15000
            };
            Student s11 = new Student()
            {
                FirstName = "Maria",
                LastName = "Peleki",
                DateOfBirth = new DateTime(2003, 12, 04),
                TuitionFees = 25000
            };
            Student s12 = new Student()
            {
                FirstName = "Fwteinh",
                LastName = "Soukalopoulou",
                DateOfBirth = new DateTime(2004, 12, 04),
                TuitionFees = 35000
            };
            Student s13 = new Student()
            {
                FirstName = "Nikos",
                LastName = "Parthenis",
                DateOfBirth = new DateTime(2005, 12, 04),
                TuitionFees = 45000
            };
            Student s14 = new Student()
            {
                FirstName = "Petros",
                LastName = "Korompos",
                DateOfBirth = new DateTime(1981, 12, 04),
                TuitionFees = 55000
            };
            Student s15 = new Student()
            {
                FirstName = "Makis",
                LastName = "Xristodoulopoulos",
                DateOfBirth = new DateTime(1980, 12, 04),
                TuitionFees = 65000
            };
            Student s16 = new Student()
            {
                FirstName = "Tasos",
                LastName = "Mpoukas",
                DateOfBirth = new DateTime(1982, 12, 04),
                TuitionFees = 75000
            };
            Student s17 = new Student()
            {
                FirstName = "Swthria",
                LastName = "Mpelou",
                DateOfBirth = new DateTime(1983, 12, 04),
                TuitionFees = 85000
            };
            Student s18 = new Student()
            {
                FirstName = "Tzenh",
                LastName = "Vanou",
                DateOfBirth = new DateTime(1984, 12, 04),
                TuitionFees = 95000
            };
            Student s19 = new Student()
            {
                FirstName = "Rena",
                LastName = "Koumioti",
                DateOfBirth = new DateTime(1985, 12, 04),
                TuitionFees = 53000
            };
            Student s20 = new Student()
            {
                FirstName = "Stratos",
                LastName = "Dionusiou",
                DateOfBirth = new DateTime(1986, 12, 04),
                TuitionFees = 87000
            };

            db.Students.AddOrUpdate(x=>new {x.FirstName,x.LastName},s1,s2,s3,s4,s5,s6,s7,s8,s9,s10,s11,s12,s13,s14,s15,s16,s17,s18,s19,s20);
            db.SaveChanges();
            #endregion

            #region Seeding Courses
            Course c1 = new Course()
            {
                Title = "Java1",
                Type = Entities.Enums.CourseType.FullTime,
                StartDate = new DateTime(2019, 1, 1),
                EndDate = new DateTime(2019, 3, 31),
                Stream = "A1"
            };
            c1.Students = new List<Student> { s1, s3, s5, s11, s12 };
            s1.Courses.Add(c1);
            s3.Courses.Add(c1);
            s5.Courses.Add(c1);
            s11.Courses.Add(c1);
            s12.Courses.Add(c1);

            Course c2 = new Course()
            {
                Title = "Java2",
                Type = Entities.Enums.CourseType.PartTime,
                StartDate = new DateTime(2019, 2, 2),
                EndDate = new DateTime(2019, 4, 4),
                Stream = "A2"
            };
            c2.Students = new List<Student> { s2, s4, s6, s13, s14 };
            s2.Courses.Add(c2);
            s4.Courses.Add(c2);
            s6.Courses.Add(c2);
            s13.Courses.Add(c2);
            s14.Courses.Add(c2);

            Course c3 = new Course()
            {
                Title = "C#",
                Type = Entities.Enums.CourseType.FullTime,
                StartDate = new DateTime(2019, 3, 3),
                EndDate = new DateTime(2019, 5, 30),
                Stream = "B1"
            };
            c3.Students = new List<Student> { s7, s9, s15, s16, s17 };
            s7.Courses.Add(c3);
            s9.Courses.Add(c3);
            s15.Courses.Add(c3);
            s16.Courses.Add(c3);
            s17.Courses.Add(c3);

            Course c4 = new Course()
            {
                Title = "C#2",
                Type = Entities.Enums.CourseType.PartTime,
                StartDate = new DateTime(2019, 4, 4),
                EndDate = new DateTime(2019, 6, 30),
                Stream = "B2"
            };
            c4.Students = new List<Student> { s8, s10, s18, s19, s20 };
            s8.Courses.Add(c4);
            s10.Courses.Add(c4);
            s18.Courses.Add(c4);
            s19.Courses.Add(c4);
            s20.Courses.Add(c4);

            db.Courses.AddOrUpdate(x=> new { x.Title, x.Stream },c1,c2,c3,c4);
            db.SaveChanges();
            #endregion

            #region Trainers
            Trainer t1 = new Trainer()
            {
                FirstName = "Kostas",
                LastName = "Makris",
                Subject = "Js"
            };
            t1.Students = new List<Student>() { s1, s2 };
            s1.Trainers.Add(t1);
            s2.Trainers.Add(t1);
            t1.Courses = new List<Course>() { c1 };
            c1.Trainers.Add(t1);

            Trainer t2 = new Trainer()
            {
                FirstName = "Hlias",
                LastName = "Karagiorgos",
                Subject = "Cs"
            };
            t2.Students = new List<Student>() { s3, s4 };
            s3.Trainers.Add(t2);
            s4.Trainers.Add(t2);
            t2.Courses = new List<Course>() { c2 };
            c2.Trainers.Add(t2);

            Trainer t3 = new Trainer()
            {
                FirstName = "Lakis",
                LastName = "Peppas",
                Subject = "Html"
            };
            t3.Students = new List<Student>() { s5, s6 };
            s5.Trainers.Add(t3);
            s6.Trainers.Add(t3);
            t3.Courses = new List<Course>() { c3 };
            c3.Trainers.Add(t3);

            Trainer t4 = new Trainer()
            {
                FirstName = "Aggelos",
                LastName = "Dionusiou",
                Subject = "Javascript"
            };
            t4.Students = new List<Student>() { s7, s8 };
            s7.Trainers.Add(t4);
            s8.Trainers.Add(t4);
            t4.Courses = new List<Course>() { c4 };
            c4.Trainers.Add(t4);

            Trainer t5 = new Trainer()
            {
                TrainerId = 5,
                FirstName = "Spiros",
                LastName = "Denekes",
                Subject = "Jquery"
            };
            t5.Students = new List<Student>() { s9, s10, s11 };
            s9.Trainers.Add(t5);
            s10.Trainers.Add(t5);
            s11.Trainers.Add(t5);
            t5.Courses = new List<Course>() { c1 };
            c1.Trainers.Add(t5);

            Trainer t6 = new Trainer()
            {
                FirstName = "Thodoris",
                LastName = "Kokkalis",
                Subject = "Typescript"
            };
            t6.Students = new List<Student>() { s12, s13, s14 };
            s12.Trainers.Add(t6);
            s13.Trainers.Add(t6);
            s14.Trainers.Add(t6);
            t6.Courses = new List<Course>() { c2 };
            c2.Trainers.Add(t6);

            Trainer t7 = new Trainer()
            {
                FirstName = "Marios",
                LastName = "Sxoinas",
                Subject = "Sql"
            };
            t7.Students = new List<Student>() { s15, s16, s17 };
            s15.Trainers.Add(t7);
            s16.Trainers.Add(t7);
            s17.Trainers.Add(t7);
            t7.Courses = new List<Course>() { c3 };
            c3.Trainers.Add(t7);

            Trainer t8 = new Trainer()
            {
                FirstName = "Fotis",
                LastName = "Lekas",
                Subject = "Bootstrap"
            };
            t8.Students = new List<Student>() { s18, s19, s20 };
            s18.Trainers.Add(t8);
            s19.Trainers.Add(t8);
            s20.Trainers.Add(t8);
            t8.Courses = new List<Course>() { c4 };
            c4.Trainers.Add(t8);

            db.Trainers.AddOrUpdate(x => new { x.FirstName, x.LastName },t1,t2,t3,t4,t5,t6,t7,t8);
            db.SaveChanges();
            #endregion

            #region Assignments
            Assignment a1 = new Assignment()
            {
                Title = "Ass1",
                Description = "JavaForms",
                OralMark = 11,
                TotalMark = 50,
                SubDateTime = new DateTime(2019, 2, 2)
            };
            c4.Assignments.Add(a1);

            Assignment a2 = new Assignment()
            {
                Title = "Ass2",
                Description = "JavaTypes",
                OralMark = 15,
                TotalMark = 60,
                SubDateTime = new DateTime(2019, 3, 2)
            };
            c4.Assignments.Add(a2);

            Assignment a3 = new Assignment()
            {
                Title = "Ass3",
                Description = "Classes",
                OralMark = 13,
                TotalMark = 610,
                SubDateTime = new DateTime(2019, 4, 2)
            };
            c4.Assignments.Add(a3);

            Assignment a4 = new Assignment()
            {
                Title = "Ass4",
                Description = "Functions",
                OralMark = 14,
                TotalMark = 62,
                SubDateTime = new DateTime(2019, 5, 2)
            };
            c4.Assignments.Add(a4);

            Assignment a5 = new Assignment()
            {
                Title = "Ass5",
                Description = "DoWhile",
                OralMark = 15,
                TotalMark = 63,
                SubDateTime = new DateTime(2019, 6, 2)
            };
            c4.Assignments.Add(a5);

            Assignment a6 = new Assignment()
            {
                Title = "Ass6",
                Description = "For",
                OralMark = 15,
                TotalMark = 64,
                SubDateTime = new DateTime(2019, 7, 2)
            };
            c4.Assignments.Add(a6);

            Assignment a7 = new Assignment()
            {
                Title = "Ass7",
                Description = "ForEach",
                OralMark = 16,
                TotalMark = 65,
                SubDateTime = new DateTime(2019, 8, 2)
            };
            c3.Assignments.Add(a7);

            Assignment a8 = new Assignment()
            {
                Title = "Ass8",
                Description = "Switch",
                OralMark = 16,
                TotalMark = 66,
                SubDateTime = new DateTime(2019, 9, 2)
            };
            c3.Assignments.Add(a8);

            Assignment a9 = new Assignment()
            {
                Title = "Ass9",
                Description = "If",
                OralMark = 17,
                TotalMark = 67,
                SubDateTime = new DateTime(2019, 10, 2)
            };
            c3.Assignments.Add(a9);

            Assignment a10 = new Assignment()
            {
                Title = "Ass10",
                Description = "IfElse",
                OralMark = 18,
                TotalMark = 68,
                SubDateTime = new DateTime(2019, 11, 2)
            };
            c3.Assignments.Add(a10);

            Assignment a11 = new Assignment()
            {
                Title = "Ass11",
                Description = "Entities",
                OralMark = 19,
                TotalMark = 69,
                SubDateTime = new DateTime(2019, 12, 2)
            };
            c3.Assignments.Add(a11);

            Assignment a12 = new Assignment()
            {
                Title = "Ass12",
                Description = "Enums",
                OralMark = 20,
                TotalMark = 70,
                SubDateTime = new DateTime(2019, 2, 3)
            };
            c3.Assignments.Add(a12);

            Assignment a13 = new Assignment()
            {
                Title = "Ass13",
                Description = "Database",
                OralMark = 20,
                TotalMark = 71,
                SubDateTime = new DateTime(2019, 2, 4)
            };
            c2.Assignments.Add(a13);

            Assignment a14 = new Assignment()
            {
                Title = "Ass14",
                Description = "Abstract",
                OralMark = 20,
                TotalMark = 72,
                SubDateTime = new DateTime(2019, 2, 5)
            };
            c2.Assignments.Add(a14);

            Assignment a15 = new Assignment()
            {
                Title = "Ass15",
                Description = "Public",
                OralMark = 20,
                TotalMark = 73,
                SubDateTime = new DateTime(2019, 2, 6)
            };
            c2.Assignments.Add(a15);

            Assignment a16 = new Assignment()
            {
                Title = "Ass16",
                Description = "Void",
                OralMark = 20,
                TotalMark = 74,
                SubDateTime = new DateTime(2019, 2, 7)
            };
            c2.Assignments.Add(a16);

            Assignment a17 = new Assignment()
            {
                Title = "Ass18",
                Description = "Private",
                OralMark = 20,
                TotalMark = 75,
                SubDateTime = new DateTime(2019, 2, 8)
            };
            c2.Assignments.Add(a17);

            Assignment a18 = new Assignment()
            {
                Title = "Ass18",
                Description = "Arrays",
                OralMark = 20,
                TotalMark = 76,
                SubDateTime = new DateTime(2019, 2, 9)
            };
            c2.Assignments.Add(a18);

            Assignment a19 = new Assignment()
            {
                Title = "Ass19",
                Description = "Lists",
                OralMark = 20,
                TotalMark = 77,
                SubDateTime = new DateTime(2019, 2, 10)
            };
            c1.Assignments.Add(a19);

            Assignment a20 = new Assignment()
            {
                Title = "Ass20",
                Description = "String",
                OralMark = 20,
                TotalMark = 78,
                SubDateTime = new DateTime(2019, 2, 11)
            };
            c1.Assignments.Add(a20);

            Assignment a21 = new Assignment()
            {
                Title = "Ass21",
                Description = "Int",
                OralMark = 20,
                TotalMark = 79,
                SubDateTime = new DateTime(2019, 2, 12)
            };
            c1.Assignments.Add(a21);

            Assignment a22 = new Assignment()
            {
                Title = "Ass22",
                Description = "Bool",
                OralMark = 20,
                TotalMark = 80,
                SubDateTime = new DateTime(2019, 2, 13)
            };
            c1.Assignments.Add(a22);

            Assignment a23 = new Assignment()
            {
                Title = "Ass23",
                Description = "Double",
                OralMark = 20,
                TotalMark = 90,
                SubDateTime = new DateTime(2019, 2, 14)
            };
            c1.Assignments.Add(a23);

            Assignment a24 = new Assignment()
            {
                Title = "Ass24",
                Description = "Long",
                OralMark = 20,
                TotalMark = 91,
                SubDateTime = new DateTime(2019, 2, 15)
            };
            c1.Assignments.Add(a24);
            
            Assignment a25 = new Assignment()
            {
                Title = "Ass25",
                Description = "Static",
                OralMark = 20,
                TotalMark = 92,
                SubDateTime = new DateTime(2019, 2, 16)
            };
            c1.Assignments.Add(a25);

            Assignment a26 = new Assignment()
            {
                Title = "Ass26",
                Description = "Interfaces",
                OralMark = 20,
                TotalMark = 93,
                SubDateTime = new DateTime(2019, 2, 17)
            };
            c2.Assignments.Add(a26);

            Assignment a27 = new Assignment()
            {
                Title = "Ass27",
                Description = "Restrictions",
                OralMark = 20,
                TotalMark = 94,
                SubDateTime = new DateTime(2019, 2, 18)
            };
            c3.Assignments.Add(a27);

            Assignment a28 = new Assignment()
            {
                Title = "Ass28",
                Description = "Validations",
                OralMark = 20,
                TotalMark = 95,
                SubDateTime = new DateTime(2019, 2, 19)
            };
            c4.Assignments.Add(a28);
           
            db.Assignments.AddOrUpdate(x => new { x.Title, x.Description },a1,a2,a3,a4,a5,a6,a7,a8,a9,a10,a11,a12,a13,a14,a15,a16,a17,a18,a19,a20,a21,a22,a23,a24,a25,a26,a27,a28);
            db.SaveChanges();
            #endregion
          
        }
    }
}
