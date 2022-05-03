using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libraries.Views
{
    public static class AppCommonOutputText
    {
        public static string GetUnderlineForHeading(string heading)
        {
            return new string('_', heading.Length);
        }

        public static string GetApplicationHeading()
        {
            string heading = "Coding Camp Console Application";
            string underline = GetUnderlineForHeading(heading);
            return $"{heading}\n{underline}\n\n";
        }

        public static string GetInstructions()
        {
            return "Press:\n[C] for Courses\n[T] for Trainers\n[S] for Students\n[A] for Assignments\nor any other key to end session";
        }
    }
}
