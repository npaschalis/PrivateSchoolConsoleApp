using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libraries.Entities;
using Libraries.Views;

namespace Libraries.Factories
{
    public static class CourseFactory
    {
        private static CourseView _courseView;
        private static CourseCreateView _courseCreateView;
        private static CourseUpdateView _courseUpdateView;
        private static CourseDeleteView _courseDeleteView;
        private static CourseProcessView _courseProcessView;
        private static AddStudentToCourseView _addStudentToCourseView;
        private static RemoveStudentFromCourseView _removeStudentFromCourseView;
        private static AddTrainerToCourseView _addTrainerToCourseView;
        private static RemoveTrainerFromCourseView _removeTrainerFromCourseView;
        private static AddAssignmentToCourseView _addAssignmentToCourseView;
        private static RemoveAssignmentFromCourseView _removeAssignmentFromCourseView;
    
        public static Course CreateNewCourseObject(string title, string stream, string type, DateTime startDate, DateTime endDate)
        {
            return new Course
            {
                Title = title,
                Stream = stream,
                Type = type,
                StartDate = startDate,
                EndDate = endDate,
                Students = new List<Student>(),
                Trainers = new List<Trainer>(),
                Assignments = new List<Assignment>()
            };
        }

        public static CourseRecordsView CourseRecordsViewObject(Courses courses)
        {
            return new CourseRecordsView(courses);
        }

        public static CourseView CourseViewObject(Courses courses, Students students, Trainers trainers, Assignments assignments)
        {
            if (_courseView == null)
            {
                _courseView = new CourseView(courses, students, trainers, assignments);
            }

            return new CourseView(courses, students, trainers, assignments);
        }

        public static CourseCreateView CourseCreateViewObject(Courses courses, Students students, Trainers trainers, Assignments assignments)
        {
            if (_courseCreateView == null)
            {
                _courseCreateView = new CourseCreateView(courses, students, trainers, assignments);
            }

            return new CourseCreateView(courses, students, trainers, assignments);
        }

        public static CourseUpdateView CourseUpdateViewObject(Courses courses, Students students, Trainers trainers, Assignments assignments)
        {
            if (_courseUpdateView == null)
            {
                _courseUpdateView = new CourseUpdateView(courses, students, trainers, assignments);
            }

            return new CourseUpdateView(courses, students, trainers, assignments);
        }

        public static CourseDeleteView CourseDeleteViewObject(Courses courses, Students students, Trainers trainers, Assignments assignments)
        {
            if (_courseDeleteView == null)
            {
                _courseDeleteView = new CourseDeleteView(courses, students, trainers, assignments);
            }

            return new CourseDeleteView(courses, students, trainers, assignments);
        }

        public static CourseProcessView CourseProcessViewObject(Course course, Courses courses, Students students, Trainers trainers, Assignments assignments)
        {
            if (_courseProcessView == null)
            {
                _courseProcessView = new CourseProcessView(course, courses, students, trainers, assignments);
            }

            return new CourseProcessView(course, courses, students, trainers, assignments);
        }

        public static AddStudentToCourseView AddStudentToCourseViewObject (Course course, Courses courses, Students students, Trainers trainers, Assignments assignments)
        {
            if (_addStudentToCourseView == null)
            {
                _addStudentToCourseView = new AddStudentToCourseView(course, courses, students, trainers, assignments);
            }

            return new AddStudentToCourseView(course, courses, students, trainers, assignments);
        }

        public static RemoveStudentFromCourseView RemoveStudentFromCourseViewObject(Course course, Courses courses, Students students, Trainers trainers, Assignments assignments)
        {
            if (_removeStudentFromCourseView == null)
            {
                _removeStudentFromCourseView = new RemoveStudentFromCourseView(course, courses, students, trainers, assignments);
            }

            return new RemoveStudentFromCourseView(course, courses, students, trainers, assignments);
        }

        public static AddTrainerToCourseView AddTrainerToCourseViewObject(Course course, Courses courses, Students students, Trainers trainers, Assignments assignments)
        {
            if (_addTrainerToCourseView == null)
            {
                _addTrainerToCourseView = new AddTrainerToCourseView(course, courses, students, trainers, assignments);
            }

            return new AddTrainerToCourseView(course, courses, students, trainers, assignments);
        }

        public static RemoveTrainerFromCourseView RemoveTrainerFromCourseViewObject(Course course, Courses courses, Students students, Trainers trainers, Assignments assignments)
        {
            if (_removeTrainerFromCourseView == null)
            {
                _removeTrainerFromCourseView = new RemoveTrainerFromCourseView(course, courses, students, trainers, assignments);
            }

            return new RemoveTrainerFromCourseView(course, courses, students, trainers, assignments);
        }

        public static AddAssignmentToCourseView AddAssignmentToCourseViewObject(Course course, Courses courses, Students students, Trainers trainers, Assignments assignments)
        {
            if (_addAssignmentToCourseView == null)
            {
                _addAssignmentToCourseView = new AddAssignmentToCourseView(course, courses, students, trainers, assignments);
            }

            return new AddAssignmentToCourseView(course, courses, students, trainers, assignments);
        }

        public static RemoveAssignmentFromCourseView RemoveAssignmentFromCourseViewObject(Course course, Courses courses, Students students, Trainers trainers, Assignments assignments)
        {
            if (_removeAssignmentFromCourseView == null)
            {
                _removeAssignmentFromCourseView = new RemoveAssignmentFromCourseView(course, courses, students, trainers, assignments);
            }

            return new RemoveAssignmentFromCourseView(course, courses, students, trainers, assignments);
        }
    }
}
