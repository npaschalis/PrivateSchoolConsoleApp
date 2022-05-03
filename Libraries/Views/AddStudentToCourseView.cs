using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libraries.Entities;
using Libraries.Factories;

namespace Libraries.Views
{
    public class AddStudentToCourseView
    {
        private Course _course;
        private Courses _courses;
        private Students _students;
        private Trainers _trainers;
        private Assignments _assignments;

        public AddStudentToCourseView(Course course, Courses courses, Students students, Trainers trainers, Assignments assignments)
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

            foreach(Student stu in _students)
            {
                Console.WriteLine(stu.GetStudentInformation());
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Please enter the id of the student you wish to add to the course");
            int id = Convert.ToInt32(Console.ReadLine());

            int index = _students.Find(id);

            if (index != -1)
            {
                Student studentAlreadyAdded = _course.Students.Find(s => s.Id == id);
                if (studentAlreadyAdded != null)
                {
                    Console.WriteLine("Student already added!");
                    Console.ReadKey();
                }
                else _course.Students.Add(_students[index]);
                Console.WriteLine($"{_students[index].FirstName} {_students[index].LastName} added!");
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
