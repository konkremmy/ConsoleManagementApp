using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentPartB.Entities
{
    public class Trainer
    {
        public Trainer()
        {
            this.Students=new HashSet<Student>();
            this.Courses=new HashSet<Course>();
        }
        public int TrainerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Subject { get; set; }
        public virtual ICollection<Student> Students { get;set; }
        public virtual ICollection<Course> Courses { get;set; }

    }
}
