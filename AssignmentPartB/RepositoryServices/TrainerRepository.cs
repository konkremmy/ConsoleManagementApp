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
    public class TrainerRepository
    {
        public ApplicationDbContext db;
        public TrainerRepository(ApplicationDbContext MyContext)
        {
            db = MyContext;
        }

        public IEnumerable<Trainer> GetAll()
        {
            return db.Trainers.ToList();
        }

        public Trainer Get(int? id)
        {
            return db.Trainers.Find(id);
        }

        public void Add(Trainer trainer)
        {
            db.Entry(trainer).State = EntityState.Added;
            db.SaveChanges();
        }

        public void Edit(Trainer trainer)
        {
            db.Entry(trainer).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            Trainer trainer = Get(id);
            db.Entry(trainer).State = EntityState.Deleted;
            db.SaveChanges();
        }
    }

}

