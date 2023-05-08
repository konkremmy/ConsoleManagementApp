using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssignmentPartB.Entities;
using AssignmentPartB.MyDatabase;
using AssignmentPartB.RepositoryServices;
using AssignmentPartB.Views;
using AssignmentPartB.Views.ViewCreates;
using AssignmentPartB.Views.ViewDeletes;
using AssignmentPartB.Views.ViewEdits;

namespace AssignmentPartB.Controllers
{
    public class TrainerController
    {

        private TrainerRepository trainerRepository;
        private ViewTrainer viewTrainer;
        private ViewCreateTrainer viewCreateTrainer;
        private ViewDeleteTrainer viewDeleteTrainer;
        private ViewEditTrainer viewEditTrainer;

        public TrainerController()
        {
            trainerRepository = new TrainerRepository(new ApplicationDbContext());
            viewTrainer = new ViewTrainer();
            viewCreateTrainer= new ViewCreateTrainer();
            viewDeleteTrainer= new ViewDeleteTrainer();
            viewEditTrainer= new ViewEditTrainer();
        }
        public void PrintTrainers()
        {
            var trainers = trainerRepository.GetAll();
            viewTrainer.ViewTrainers(trainers);
        }
        public void CreateTrainer()
        {
            var trainer = viewCreateTrainer.CreateTrainer();
            if (trainer != null)
            {
                trainerRepository.Add(trainer);
            }
            else
            {
                Console.WriteLine("Something went wrong");
            }
            var trainers = trainerRepository.GetAll();
            viewTrainer.ViewTrainers(trainers);
        }
        public void DeleteTrainer()
        {
            var trainers = trainerRepository.GetAll();
            viewTrainer.ViewTrainersId(trainers);
            viewDeleteTrainer.DeleteTrainer();
            int id = Convert.ToInt32(Console.ReadLine());
            trainerRepository.Delete(id);
            trainers = trainerRepository.GetAll();
            viewTrainer.ViewTrainers(trainers);
        }

        public void EditTrainer()
        {
            var trainers = trainerRepository.GetAll();
            viewTrainer.ViewTrainersId(trainers);
            viewEditTrainer.EditTrainer();
            int id = Convert.ToInt32(Console.ReadLine());
            var trainerOld = trainerRepository.Get(id);
            var trainerNew = viewCreateTrainer.CreateTrainer();
            trainerOld.FirstName = trainerNew.FirstName;
            trainerOld.LastName = trainerNew.LastName;
            trainerOld.Subject = trainerNew.Subject;          
            trainerRepository.Edit(trainerOld);
            viewTrainer.ViewTrainers(trainers);
        }
    }

}
