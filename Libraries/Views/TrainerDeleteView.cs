using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libraries.Entities;
using Libraries.Factories;

namespace Libraries.Views
{
    public class TrainerDeleteView
    {
        private Trainers _trainers;
        public TrainerDeleteView(Trainers trainers)
        {
            _trainers = trainers;
        }

        public void RunDeleteView()
        {
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Please enter the ID of the trainer you wish to delete.");

            int id = Convert.ToInt32(Console.ReadLine());

            int index = _trainers.Find(id);

            if (index != -1)
            {
                Trainer trainer = _trainers[index];
                Console.WriteLine($"Are you sure you wish to delete trainer with Id ({trainer.Id})? (y/n)");

                ConsoleKey consoleKey = Console.ReadKey().Key;

                if (consoleKey == ConsoleKey.Y)
                {
                    _trainers.Delete(index);
                }
            }
            else
            {
                Console.WriteLine(TrainerCommonOutputText.GetTrainerNotFoundMessage(id));
                Console.ReadKey();
            }

            TrainerView trainerView = TrainerFactory.TrainerViewObject(_trainers);
            trainerView.RunView();
        }
    }
}
