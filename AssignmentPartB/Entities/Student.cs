using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentPartB.Entities
{
    public class Student
    {
        public Student()
        {
            this.Courses=new HashSet<Course>();
            this.Trainers=new HashSet<Trainer>();
            this.Assignments=new HashSet<Assignment>();
        }
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int TuitionFees { get; set; }
        public DateTime DateOfBirth { get; set; }
        public virtual ICollection<Course> Courses { get;set; }
        public virtual ICollection<Trainer> Trainers { get;set; }
        public virtual ICollection<Assignment> Assignments { get;set; }

    }
}
