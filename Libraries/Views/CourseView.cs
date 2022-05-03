using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libraries.Entities;
using Libraries.Factories;

namespace Libraries.Views
{
    public class CourseView
    {
        private Courses _courses;
        private Students _students;
        private Trainers _trainers;
        private Assignments _assignments;

        public CourseView(Courses courses, Students students, Trainers trainers, Assignments assignments)
        {
            _courses = courses;
            _students = students;
            _trainers = trainers;
            _assignments = assignments;
        }

        public void RunView()
        {
            Console.Clear();
            Console.WriteLine(AppCommonOutputText.GetApplicationHeading());
            CourseRecordsView courseRecordsView = CourseFactory.CourseRecordsViewObject(_courses);
            courseRecordsView.RunRecordsView();

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Press:\n[A] to Add a new Course\n[U] to Update a Course's details\n[D] to Delete a Course");
            Console.WriteLine("[B] to Add or Remove Data for a Certain Course\nor any other key to return to main menu");

            ConsoleKey instructionKey = Console.ReadKey().Key;

            switch (instructionKey)
            {
                case ConsoleKey.A:
                    CourseCreateView courseCreateView = CourseFactory.CourseCreateViewObject(_courses, _students, _trainers, _assignments);
                    courseCreateView.RunCreateView();
                    break;
                case ConsoleKey.U:
                     CourseUpdateView courseUpdateView = CourseFactory.CourseUpdateViewObject(_courses, _students, _trainers, _assignments);
                     courseUpdateView.RunUpdateView();
                     break;
                 case ConsoleKey.D:
                     CourseDeleteView courseDeleteView = CourseFactory.CourseDeleteViewObject(_courses, _students, _trainers, _assignments);
                     courseDeleteView.RunDeleteView();
                     break;
                case ConsoleKey.B:
                    CourseProcessView courseProcessView = CourseFactory.CourseProcessViewObject(null, _courses, _students, _trainers, _assignments);
                    courseProcessView.RunProcessView();
                    break;
                default:
                    break;
            }
        }
    }
}
