using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libraries.Entities;

namespace Libraries.Views
{
    public static class AssignmentCommonOutputText
    {
        public static string GetColumnHeadings()
        {
            string id = "ID";
            string title = "Title";
            string subDateTime = "Submission";
            string oralMark = "Oral";
            string totalMark = "Total";

            string heading = $"{id.PadRight(6)}\t{title.PadRight(25)}\t{subDateTime.PadRight(15)}\t{oralMark.PadRight(7)}\t{totalMark.PadRight(7)}\n";
            heading += $"{new string('_', 6)}\t{new string('_', 25)}\t{new string('_', 15)}\t{new string('_', 7)}\t{new string('_', 7)}\n";

            return heading;
        }

        public static string GetCreateHeading()
        {
            string heading = "Add Assignment\n";
            string underline = AppCommonOutputText.GetUnderlineForHeading(heading);

            return $"{heading}{underline}\n\n";
        }

        public static string GetAssignmentNotFoundMessage(int id)
        {
            return $"Could not find assignment with Id({id}). Please press any key to return to the assignments menu...";
        }

        public static string GetUpdateHeading(Assignment assignment)
        {
            string heading = $"Update Assignment Details for {assignment.Title} ID: {assignment.Id}\n";
            string underline = AppCommonOutputText.GetUnderlineForHeading(heading);

            return $"{heading}{underline}\n\n";
        }

        public static string GetUpdateViewAdditionalInstructions()
        {
            return "Note: a blank field will leave relevant field unmodified.\n";
        }
    }
}
