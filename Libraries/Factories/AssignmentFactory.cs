using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libraries.Entities;
using Libraries.Views;

namespace Libraries.Factories
{
    public static class AssignmentFactory
    {
        private static AssignmentView _assignmentView;
        private static AssignmentCreateView _assignmentCreateView;
        private static AssignmentUpdateView _assignmentUpdateView;
        private static AssignmentDeleteView _assignmentDeleteView;
        public static Assignment CreateNewAssignmentObject(string title, string description, DateTime subDateTime, int oralMark, int totalMark)
        {
            return new Assignment
            {
                Title = title,
                Description = description,
                SubDateTime = subDateTime,
                OralMark = oralMark,
                TotalMark = totalMark
            };
        }

        public static AssignmentRecordsView AssignmentRecordsViewObject(Assignments assignments)
        {
            return new AssignmentRecordsView(assignments);
        }

        public static AssignmentView AssignmentViewObject(Assignments assignments)
        {
            if (_assignmentView == null)
            {
                _assignmentView = new AssignmentView(assignments);
            }

            return new AssignmentView(assignments);
        }

        public static AssignmentCreateView AssignmentCreateViewObject(Assignments assignments)
        {
            if (_assignmentCreateView == null)
            {
                _assignmentCreateView = new AssignmentCreateView(assignments);
            }

            return new AssignmentCreateView(assignments);
        }

        public static AssignmentUpdateView AssignmentUpdateViewObject(Assignments assignments)
        {
            if (_assignmentUpdateView == null)
            {
                _assignmentUpdateView = new AssignmentUpdateView(assignments);
            }

            return new AssignmentUpdateView(assignments);
        }

        public static AssignmentDeleteView AssignmentDeleteViewObject(Assignments assignments)
        {
            if (_assignmentDeleteView == null)
            {
                _assignmentDeleteView = new AssignmentDeleteView(assignments);
            }

            return new AssignmentDeleteView(assignments);
        }
    }
}
