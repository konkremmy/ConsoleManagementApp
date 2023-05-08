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
    public class StudentRepository
    {
        private ApplicationDbContext db;
        public StudentRepository(ApplicationDbContext MyContext)
        {
            db = MyContext;
        }

        public IEnumerable<Student> GetAll()
        {
            return db.Students.ToList();
        }

        public Student Get(int? id)
        {
            return db.Students.Find(id);
        }
        

        public void Add(Student student)
        {
            db.Entry(student).State = EntityState.Added;
            db.SaveChanges();
        }

        public void Edit(Student student)
        {
            db.Entry(student).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            Student student = Get(id);
            db.Entry(student).State = EntityState.Deleted;
            db.SaveChanges();
        }
       
    }
}
