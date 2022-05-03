using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libraries.Factories;

namespace Libraries.Entities
{
    public class Courses
    {
        List<Course> _courseList = new List<Course>();
        public Courses()
        {
            SeedData();
        }

        public Course this[int index]
        {
            get
            {
                return (Course)_courseList[index];
            }
        }

        private void SeedData()
        {
            this.Add(CourseFactory.CreateNewCourseObject("CB8", "Java", "full-time", new DateTime(2022, 01, 01), new DateTime(2022, 03, 31)));
            this.Add(CourseFactory.CreateNewCourseObject("CB8", "C#", "full-time", new DateTime(2022, 01, 01), new DateTime(2022, 03, 31)));
            this.Add(CourseFactory.CreateNewCourseObject("CB8", "JavaScript", "full-time", new DateTime(2022, 01, 01), new DateTime(2022, 03, 31)));
            this.Add(CourseFactory.CreateNewCourseObject("CB8", "Java", "part-time", new DateTime(2022, 01, 01), new DateTime(2022, 06, 30)));
            this.Add(CourseFactory.CreateNewCourseObject("CB8", "C#", "part-time", new DateTime(2022, 01, 01), new DateTime(2022, 06, 30)));
            this.Add(CourseFactory.CreateNewCourseObject("CB8", "Python", "part-time", new DateTime(2022, 01, 01), new DateTime(2022, 06, 30)));
        }

        public void Add(Course course)
        {
            _courseList.Add(course);
        }

        public void Update(Course course, string title, string stream, string type, DateTime startDate, DateTime endDate)
        {
            course.Title = title;
            course.Stream = stream;
            course.Type = type;
            course.StartDate = startDate;
            course.EndDate = endDate;
        }

        public void Delete(int index)
        {
            _courseList.RemoveAt(index);
        }

        public int Find(int id)
        {
            int count = 0;
            foreach (Course course in _courseList)
            {
                if (course.Id == id)
                {
                    return count;
                }
                count++;
            }

            return -1;
        }

        public int Count()
        {
            return _courseList.Count;
        }


        public IEnumerator<Course> GetEnumerator()
        {
            return _courseList.GetEnumerator();
        }
    }
}
