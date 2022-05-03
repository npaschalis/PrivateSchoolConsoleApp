using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libraries.Entities;

namespace Libraries.Views
{
    public static class CourseCommonOutputText
    {
        public static string GetColumnHeadings()
        {
            string id = "ID";
            string title = "Title";
            string stream = "Stream";
            string type = "Type";
            string startDate = "Start Date";
            string endDate = "End Date";

            string heading = $"{id.PadRight(6)}\t{title.PadRight(15)}\t{stream.PadRight(15)}\t{type.PadRight(15)}\t{startDate.PadRight(15)}\t{endDate.PadRight(15)}\n";
            heading += $"{new string('_', 6)}\t{new string('_', 15)}\t{new string('_', 15)}\t{new string('_', 15)}\t{new string('_', 15)}\t{new string('_', 15)}\n";

            return heading;
        }

        public static string GetCreateHeading()
        {
            string heading = "Add Course\n";
            string underline = AppCommonOutputText.GetUnderlineForHeading(heading);

            return $"{heading}{underline}\n\n";
        }

        public static string GetCourseNotFoundMessage(int id)
        {
            return $"Could not find course with Id({id}). Please press any key to return to the courses menu...";
        }

        public static string GetUpdateHeading(Course course)
        {
            string heading = $"Update Course Details for {course.Title} {course.Stream} {course.Type} ID: {course.Id}\n";
            string underline = AppCommonOutputText.GetUnderlineForHeading(heading);

            return $"{heading}{underline}\n\n";
        }

        public static string GetUpdateViewAdditionalInstructions()
        {
            return "Note: a blank field will leave relevant field unmodified.\n";
        }
    }
}
