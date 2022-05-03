using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libraries.Entities;

namespace Libraries.Views
{
    public static class StudentCommonOutputText
    {
        public static string GetColumnHeadings()
        {
            string id = "ID";
            string firstName = "First Name";
            string lastName = "Last Name";
            string dateOfBirth = "Date of Birth";
            string tuitionFees = "Tuition";

            string heading = $"{id.PadRight(6)}\t{firstName.PadRight(15)}\t{lastName.PadRight(15)}\t{dateOfBirth.PadRight(15)}\t{tuitionFees.PadRight(7)}\n";
            heading += $"{new string('_', 6)}\t{new string('_', 15)}\t{new string('_', 15)}\t{new string('_', 15)}\t{new string('_', 7)}\n";

            return heading;
        }

        public static string GetCreateHeading()
        {
            string heading = "Add Student\n";
            string underline = AppCommonOutputText.GetUnderlineForHeading(heading);

            return $"{heading}{underline}\n\n";
        }

        public static string GetStudentNotFoundMessage(int id)
        {
            return $"Cound not find student with ID({id}). Please press any key to return to the Student menu...";
        }

        public static string GetUpdateHeading(Student student)
        {
            string heading = $"Update student details for {student.FirstName} {student.LastName} ID: {student.Id}\n";
            string underline = AppCommonOutputText.GetUnderlineForHeading(heading);

            return $"{heading}{underline}\n\n";
        }

        public static string GetUpdateViewAdditionalInstructions()
        {
            return "Note: a blank field will leave releavant field unmodified.\n";
        }
    }
}

