using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libraries.Entities;
using Libraries.Views;

namespace Libraries.Factories
{
    public static class StudentFactory
    {
        private static StudentView _studentView;
        private static StudentCreateView _studentCreateView;
        private static StudentUpdateView _studentUpdateView;
        private static StudentDeleteView _studentDeleteView;

        public static Student CreateNewStudentObject(string firstName, string lastName, DateTime dateOfBirth, decimal tuitionFees)
        {
            return new Student
            {
                FirstName = firstName,
                LastName = lastName,
                DateOfBirth = dateOfBirth,
                TuitionFees = tuitionFees
            };
        }

        public static StudentRecordsView StudentRecordsViewObject(Students students)
        {
            return new StudentRecordsView(students);
        }

        public static StudentView StudentViewObject(Students students)
        {
            if (_studentView == null)
            {
                _studentView = new StudentView(students);
            }

            return new StudentView(students);
        }

        public static StudentCreateView StudentCreateViewObject(Students students)
        {
            if (_studentCreateView == null)
            {
                _studentCreateView = new StudentCreateView(students);
            }

            return new StudentCreateView(students);
        }

        public static StudentUpdateView StudentUpdateViewObject (Students students)
        {
            if (_studentUpdateView == null)
            {
                _studentUpdateView = new StudentUpdateView(students);
            }

            return new StudentUpdateView(students);
        }

        public static StudentDeleteView StudentDeleteViewObject(Students students)
        {
            if (_studentDeleteView == null)
            {
                _studentDeleteView = new StudentDeleteView(students);
            }

            return new StudentDeleteView(students);
        }
    }
}
