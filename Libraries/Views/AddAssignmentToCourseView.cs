using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libraries.Entities;
using Libraries.Factories;

namespace Libraries.Views
{
    public class AddAssignmentToCourseView
    {
        private Course _course;
        private Courses _courses;
        private Students _students;
        private Trainers _trainers;
        private Assignments _assignments;

        public AddAssignmentToCourseView(Course course, Courses courses, Students students, Trainers trainers, Assignments assignments)
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

            foreach (Assignment assign in _assignments)
            {
                Console.WriteLine(assign.GetAssignmentInformation());
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Please enter the id of the assignment you wish to add to the course");
            int id = Convert.ToInt32(Console.ReadLine());

            int index = _assignments.Find(id);

            if (index != -1)
            {
                Assignment assignmentAlreadyAdded = _course.Assignments.Find(a => a.Id == id);
                if (assignmentAlreadyAdded != null)
                {
                    Console.WriteLine("Assignment already added!");
                    Console.ReadKey();
                }
                else _course.Assignments.Add(_assignments[index]);
                Console.WriteLine($"{_assignments[index].Title} added!");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Not found. Press any key to return to the courses updates menu");
                Console.ReadKey();
            }

            Console.Clear();
            CourseProcessView courseProcessView = CourseFactory.CourseProcessViewObject(_course, _courses, _students, _trainers, _assignments);
            courseProcessView.RunProcessView();
        }
    }
}
