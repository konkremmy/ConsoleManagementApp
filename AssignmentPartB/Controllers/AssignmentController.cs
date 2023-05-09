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
    public class AssignmentController
    {
        private AssignmentRepository assignmentRepository;
        private ViewAssignment viewAssignment;
        private ViewCreateAssignment viewCreateAssignment;
        private ViewDeleteAssignment viewDeleteAssignment;
        private ViewEditAssignment viewEditAssignment;
        public AssignmentController()
        {
            assignmentRepository = new AssignmentRepository(new ApplicationDbContext());
            viewAssignment= new ViewAssignment();
            viewCreateAssignment= new ViewCreateAssignment();
            viewDeleteAssignment= new ViewDeleteAssignment();
            viewEditAssignment= new ViewEditAssignment();
        }
        public void PrintAssignments()
        {
            var assignments = assignmentRepository.GetAll();
            viewAssignment.ViewAssignments(assignments);
        }
        public void CreateAssignment()
        {
            var assignment = viewCreateAssignment.CreateAssignment();
            if (assignment != null)
            {
                assignmentRepository.Add(assignment);
            }
            else
            {
                Console.WriteLine("Something went wrong");
            }
            var assignments = assignmentRepository.GetAll();
            viewAssignment.ViewAssignments(assignments);
        }
        public void DeleteAssignment()
        {
            var assignments = assignmentRepository.GetAll();
            viewAssignment.ViewAssignmentsId(assignments);
            int id = viewDeleteAssignment.GetAssignmentsIdForDelete();
            if (assignmentRepository.Get(id) != null)
            {
                assignmentRepository.Delete(id);
            }
            else
            {
                Console.WriteLine("Wrong Id");
            }          
        }
        public void EditAssignment()
        {
            var assignments = assignmentRepository.GetAll();
            viewAssignment.ViewAssignmentsId(assignments);
            int id = viewEditAssignment.GetAssignmentsIdForEdit();
            if (assignmentRepository.Get(id) != null)
            {
                var assignmentOld = assignmentRepository.Get(id);
                var assignmentNew = viewCreateAssignment.CreateAssignment();
                assignmentOld.Title = assignmentNew.Title;
                assignmentOld.Description = assignmentNew.Description;
                assignmentOld.SubDateTime = assignmentNew.SubDateTime;
                assignmentOld.OralMark = assignmentNew.OralMark;
                assignmentOld.TotalMark = assignmentNew.TotalMark;
                assignmentRepository.Edit(assignmentOld);
            }
            else
            {
                Console.WriteLine("Wrong Id");
            }           
        }
    }
}
