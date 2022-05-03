using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libraries.Entities;

namespace Libraries.Views
{
    public class TrainerRecordsView
    {
        private Trainers _trainers;
        public TrainerRecordsView(Trainers trainers)
        {
            _trainers = trainers;
        }
        public void RunRecordsView()
        {
            Console.WriteLine(TrainerCommonOutputText.GetColumnHeadings());

            foreach (Trainer t in _trainers)
            {
                Console.WriteLine(t.GetTrainerInformation());
            }
        }
    }
}
