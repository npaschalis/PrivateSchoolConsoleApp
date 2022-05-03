using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libraries.Entities;
using Libraries.Factories;

namespace Libraries.Views
{
    public class RemoveAssignmentFromCourseView
    {
        private Course _course;
        private Courses _courses;
        private Students _students;
        private Trainers _trainers;
        private Assignments _assignments;

        public RemoveAssignmentFromCourseView(Course course, Courses courses, Students students, Trainers trainers, Assignments assignments)
        {
            _course = course;
            _courses = courses;
            _students = students;
            _trainers = trainers;
            _assignments = assignments;
        }

        public void RunView()
        {
            Console.Clear();
            Console.WriteLine(AppCommonOutputText.GetApplicationHeading());
            Console.WriteLine();
            Console.WriteLine(CourseCommonOutputText.GetUpdateHeading(_course));

            foreach (Assignment assig in _course.Assignments)
            {
                Console.WriteLine(assig.GetAssignmentInformation());
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Please enter the id of the assignment you wish to delete from the course");
            int id = Convert.ToInt32(Console.ReadLine());

            Assignment assign = _course.Assignments.Find(a => a.Id == id);

            if (assign != null)
            {
                _course.Assignments.Remove(assign);
                Console.WriteLine($"Assignment with the ID {id} was just deleted!");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine($"Assignment with the ID {id} isn't in this course");
                Console.ReadLine();
            }

            Console.Clear();
            CourseProcessView courseProcessView = CourseFactory.CourseProcessViewObject(_course, _courses, _students, _trainers, _assignments);
            courseProcessView.RunProcessView();
        }
    }
}
