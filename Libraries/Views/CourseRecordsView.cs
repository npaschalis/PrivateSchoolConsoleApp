using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libraries.Entities;

namespace Libraries.Views
{
    public class CourseRecordsView
    {
        private Courses _courses;
        public CourseRecordsView(Courses courses)
        {
            _courses = courses;
        }
        public void RunRecordsView()
        {
            Console.WriteLine(CourseCommonOutputText.GetColumnHeadings());

            foreach (Course c in _courses)
            {
                Console.WriteLine(c.GetCourseInformation());
            }
        }
    }
}
