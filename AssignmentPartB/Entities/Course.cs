using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssignmentPartB.Entities.Enums;

namespace AssignmentPartB.Entities
{
    public class Course
    {
        public Course()
        {
            this.Students= new HashSet<Student>();
            this.Trainers= new HashSet<Trainer>();
            this.Assignments= new HashSet<Assignment>();
        }
        public int CourseId { get; set; }
        public string Title { get; set; }
        public string Stream { get; set; }
        public CourseType Type { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public virtual ICollection<Student> Students { get; set; }
        public virtual ICollection<Trainer> Trainers { get; set; }
        public virtual ICollection<Assignment> Assignments { get; set; }

        
    }
}
