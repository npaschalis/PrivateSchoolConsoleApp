using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libraries.Entities
{
    public class Trainer
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

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Subject { get; set; }
        public Trainer()
        {
            _nextId++;
            _id = _nextId;
        }

        public string GetTrainerInformation()
        {
            string trainerInformation = $"{Id.ToString().PadRight(6)}\t{FirstName.PadRight(15)}\t{LastName.PadRight(15)}\t{Subject.PadRight(60)}";
            return trainerInformation;
        }
    }
}

