using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libraries.Entities;
using Libraries.Factories;

namespace Libraries.Views
{
    public class TrainerView
    {
        private Trainers _trainers;

        public TrainerView(Trainers trainers)
        {
            _trainers = trainers;
        }

        public void RunView()
        {
            Console.Clear();
            Console.WriteLine(AppCommonOutputText.GetApplicationHeading());
            TrainerRecordsView trainerRecordsView = TrainerFactory.TrainerRecordsViewObject(_trainers);
            trainerRecordsView.RunRecordsView();

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Press:\n[A] to Add a new Trainer\n[U] to Update a Trainer's data\n[D] to Delete a Trainer\nor any other key to return to main menu");

            ConsoleKey instructionKey = Console.ReadKey().Key;

            switch (instructionKey)
            {
                case ConsoleKey.A:
                    TrainerCreateView trainerCreateView = TrainerFactory.TrainerCreateViewObject(_trainers);
                    trainerCreateView.RunCreateView();
                    break;
                case ConsoleKey.U:
                     TrainerUpdateView trainerUpdateView = TrainerFactory.TrainerUpdateViewObject(_trainers);
                     trainerUpdateView.RunUpdateView();
                     break;
                 case ConsoleKey.D:
                     TrainerDeleteView trainerDeleteView = TrainerFactory.TrainerDeleteViewObject(_trainers);
                     trainerDeleteView.RunDeleteView();
                     break;
                default:
                    break;

            }
        }
    }
}
