using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libraries.Entities
{
    public class Course
    {
        private static int _nextId = 0;
        private int _id = 0;

        public int Id
        {
            get
            {
                return _id;
            }
        }

        public string Title { get; set; }

        public string Stream { get; set; }

        public string Type { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public List<Student> Students { get; set; } = new List<Student>();
        public List<Assignment> Assignments { get; set; } = new List<Assignment>();
        public List<Trainer> Trainers { get; set; } = new List<Trainer>();

        public Course()
        {
            _nextId++;
            _id = _nextId;
        }

        public string GetCourseInformation()
        {
            string courseInformation = $"{Id.ToString().PadRight(6)}\t{Title.PadRight(15)}\t{Stream.PadRight(15)}\t{Type.PadRight(15)}\t{StartDate.ToString("dd.MM.yyyy").PadRight(15)}\t{EndDate.ToString("dd.MM.yyyy").PadRight(15)}";
            return courseInformation;
        }
    }
}

