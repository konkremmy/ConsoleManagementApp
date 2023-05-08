using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssignmentPartB.Entities;
using System.Xml.Linq;
using AssignmentPartB.Controllers;

namespace AssignmentPartB.Views
{
    public class ViewTrainer
    {
        
        public void ViewTrainers(IEnumerable<Trainer> trainers)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{"FirstName",-25}{"LastName",-25}{"Subject",-25}");
            Console.ResetColor();
            foreach (var trainer in trainers)
            {
                Console.WriteLine($"{trainer.FirstName,-25}{trainer.LastName,-25}{trainer.Subject,-25}");
            }
        }
        public void ViewTrainersId(IEnumerable<Trainer> trainers)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{"Id",-15}{"FirstName",-25}{"LastName",-25}{"Subject",-25}");
            Console.ResetColor();
            foreach (var trainer in trainers)
            {
                Console.WriteLine($"{trainer.TrainerId,-15}{trainer.FirstName,-25}{trainer.LastName,-25}{trainer.Subject,-25}");
            }
        }
    }
}
