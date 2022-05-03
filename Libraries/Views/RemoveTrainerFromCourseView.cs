using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libraries.Entities;
using Libraries.Factories;

namespace Libraries.Views
{
    public class RemoveTrainerFromCourseView
    {
        private Course _course;
        private Courses _courses;
        private Students _students;
        private Trainers _trainers;
        private Assignments _assignments;

        public RemoveTrainerFromCourseView(Course course, Courses courses, Students students, Trainers trainers, Assignments assignments)
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

            foreach (Trainer t in _course.Trainers)
            {
                Console.WriteLine(t.GetTrainerInformation());
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Please enter the id of the trainer you wish to delete from the course");
            int id = Convert.ToInt32(Console.ReadLine());

            Trainer tr = _course.Trainers.Find(t => t.Id == id);

            if (tr != null)
            {
                _course.Trainers.Remove(tr);
                Console.WriteLine($"Trainer with the ID {id} was just deleted!");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine($"Trainer with the ID {id} isn't in this course");
                Console.ReadLine();
            }

            Console.Clear();
            CourseProcessView courseProcessView = CourseFactory.CourseProcessViewObject(_course, _courses, _students, _trainers, _assignments);
            courseProcessView.RunProcessView();
        }
    }
}
