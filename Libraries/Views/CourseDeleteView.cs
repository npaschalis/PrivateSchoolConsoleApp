using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libraries.Entities;
using Libraries.Factories;

namespace Libraries.Views
{
    public class CourseDeleteView
    {
        private Courses _courses;
        private Students _students;
        private Trainers _trainers;
        private Assignments _assignments;
        public CourseDeleteView(Courses courses, Students students, Trainers trainers, Assignments assignments)
        {
            _courses = courses;
            _students = students;
            _trainers = trainers;
            _assignments = assignments;
        }

        public void RunDeleteView()
        {
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Please enter the ID of the course you wish to delete.");

            int id = Convert.ToInt32(Console.ReadLine());

            int index = _courses.Find(id);

            if (index != -1)
            {
                Course course = _courses[index];
                Console.WriteLine($"Are you sure you wish to delete course with Id ({course.Id})? (y/n)");

                ConsoleKey consoleKey = Console.ReadKey().Key;

                if (consoleKey == ConsoleKey.Y)
                {
                    _courses.Delete(index);
                }
            }
            else
            {
                Console.WriteLine(CourseCommonOutputText.GetCourseNotFoundMessage(id));
                Console.ReadKey();
            }

            CourseView courseView = CourseFactory.CourseViewObject(_courses, _students, _trainers, _assignments);
            courseView.RunView();
        }
    }
}
