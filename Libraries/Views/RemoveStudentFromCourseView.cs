using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libraries.Entities;
using Libraries.Factories;

namespace Libraries.Views
{
    public class RemoveStudentFromCourseView
    {
        private Course _course;
        private Courses _courses;
        private Students _students;
        private Trainers _trainers;
        private Assignments _assignments;

        public RemoveStudentFromCourseView(Course course, Courses courses, Students students, Trainers trainers, Assignments assignments)
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

            foreach (Student stu in _course.Students)
            {
                Console.WriteLine(stu.GetStudentInformation());
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Please enter the id of the student you wish to delete from the course");
            int id = Convert.ToInt32(Console.ReadLine());

            Student stud = _course.Students.Find(s => s.Id == id);

            if (stud != null)
            {
                _course.Students.Remove(stud);
                Console.WriteLine($"Student with the ID {id} was just deleted!");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine($"Student with the ID {id} isn't in this course");
                Console.ReadLine();
            }

            Console.Clear();
            CourseProcessView courseProcessView = CourseFactory.CourseProcessViewObject(_course, _courses, _students, _trainers, _assignments);
            courseProcessView.RunProcessView();
        }
    }
}
