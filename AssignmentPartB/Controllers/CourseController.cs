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
    public class CourseController
    {
        
        private CourseRepository courseRepository;
        private ViewCourse viewCourse;
        private ViewAssignmentsPerCourse viewAssignmentsPerCourse;
        private ViewTrainerPerCourse viewTrainerPerCourse;
        private ViewStudentPerCourse viewStudentPerCourse;
        private ViewCreateCourse viewCreateCourse;
        private ViewDeleteCourse viewDeleteCourse;
        private ViewEditCourse viewEditCourse;
        public CourseController()
        {
            courseRepository = new CourseRepository(new ApplicationDbContext());
            viewCourse= new ViewCourse();
            viewAssignmentsPerCourse= new ViewAssignmentsPerCourse();
            viewTrainerPerCourse= new ViewTrainerPerCourse();
            viewStudentPerCourse= new ViewStudentPerCourse();
            viewCreateCourse= new ViewCreateCourse();
            viewDeleteCourse= new ViewDeleteCourse();
            viewEditCourse= new ViewEditCourse();
            
        }

        public void PrintCourses()
        {
            var courses =courseRepository.GetAll();
            viewCourse.ViewCourses(courses);        
        }
        public void PrintAssignmentsPerCourse()
        {
            var courses = courseRepository.GetAll();
            viewAssignmentsPerCourse.ViewAssignmentsPerCourses(courses);
        }
        public void PrintTrainersPerCourse()
        {
            var courses = courseRepository.GetAll();
            viewTrainerPerCourse.ViewTrainerPerCourses(courses);
        }
        public void PrintStudentsPerCourse()
        {
            var courses = courseRepository.GetAll();
            viewStudentPerCourse.ViewStudentsPerCourse(courses);
        }
        public void CreateCourse()
        {
            var course = viewCreateCourse.CreateCourse();
            if (course != null)
            {
                courseRepository.Add(course);
            }
            else
            {
                Console.WriteLine("Something went wrong");
            }
            var courses = courseRepository.GetAll();
            viewCourse.ViewCourses(courses);
        }
        public void DeleteCourse()
        {
            var courses = courseRepository.GetAll();
            viewCourse.ViewCoursesId(courses);
            viewDeleteCourse.DeleteCourse();
            int id = Convert.ToInt32(Console.ReadLine());
            courseRepository.Delete(id);
            courses = courseRepository.GetAll();
            viewCourse.ViewCourses(courses);
        }

        public void EditCourse()
        {
            var courses = courseRepository.GetAll();
            viewCourse.ViewCoursesId(courses);
            viewEditCourse.EditCourse();
            int id = Convert.ToInt32(Console.ReadLine());
            var courseOld = courseRepository.Get(id);
            var courseNew = viewCreateCourse.CreateCourse();
            courseOld.Title = courseNew.Title;
            courseOld.Stream = courseNew.Stream;
            courseOld.Type = courseNew.Type;
            courseOld.StartDate = courseNew.StartDate;
            courseOld.EndDate = courseNew.EndDate;
            courseRepository.Edit(courseOld);
            viewCourse.ViewCourses(courses);
        }
    }
}
