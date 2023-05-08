using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssignmentPartB.Entities;
using AssignmentPartB.MyDatabase;

namespace AssignmentPartB.RepositoryServices
{
    public class AssignmentRepository
    {
        public ApplicationDbContext db;
        public AssignmentRepository(ApplicationDbContext MyContext)
        {
            db = MyContext;
        }

        public IEnumerable<Assignment> GetAll()
        {
            return db.Assignments.ToList();
        }

        public Assignment Get(int? id)
        {
            return db.Assignments.Find(id);
        }

        public void Add(Assignment assignment)
        {
            db.Entry(assignment).State = EntityState.Added;
            db.SaveChanges();
        }

        public void Edit(Assignment assignment)
        {
            db.Entry(assignment).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            Assignment assignment = Get(id);
            db.Entry(assignment).State = EntityState.Deleted;
            db.SaveChanges();
        }
    }
}

