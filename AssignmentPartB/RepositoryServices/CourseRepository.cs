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
    public class CourseRepository
    {
        public ApplicationDbContext db;
        public CourseRepository(ApplicationDbContext MyContext)
        {
            db = MyContext;
        }

        public IEnumerable<Course> GetAll()
        {
            return db.Courses.ToList();
        }
        public Course Get(int? id)
        {
            return db.Courses.Find(id);
        }
        public void Add(Course course)
        {
            db.Entry(course).State = EntityState.Added;
            db.SaveChanges();
        }
        public void Edit(Course course)
        {
            db.Entry(course).State = EntityState.Modified;
            db.SaveChanges();
        }
        public void Delete(int id)
        {
            Course course = Get(id);
            db.Entry(course).State = EntityState.Deleted;
            db.SaveChanges();
        }
    }
}
