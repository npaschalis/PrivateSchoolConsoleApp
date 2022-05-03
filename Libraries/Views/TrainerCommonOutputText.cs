using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libraries.Entities;

namespace Libraries.Views
{
    public static class TrainerCommonOutputText
    {
        public static string GetColumnHeadings()
        {
            string id = "ID";
            string firstName = "First Name";
            string lastName = "Last Name";
            string subject = "Subjects";

            string heading = $"{id.PadRight(6)}\t{firstName.PadRight(15)}\t{lastName.PadRight(15)}\t{subject.PadRight(60)}\n";
            heading += $"{new string('_', 6)}\t{new string('_', 15)}\t{new string('_', 15)}\t{new string('_', 60)}\n";

            return heading;
        }

        public static string GetCreateHeading()
        {
            string heading = "Add Trainer\n";
            string underline = AppCommonOutputText.GetUnderlineForHeading(heading);

            return $"{heading}{underline}\n\n";
        }

        public static string GetTrainerNotFoundMessage(int id)
        {
            return $"Could not find trainer with Id({id}). Please press any key to return to the trainers menu...";
        }

        public static string GetUpdateHeading(Trainer trainer)
        {
            string heading = $"Update Trainer Details for {trainer.FirstName} {trainer.LastName} ID: {trainer.Id}\n";
            string underline = AppCommonOutputText.GetUnderlineForHeading(heading);

            return $"{heading}{underline}\n\n";
        }

        public static string GetUpdateViewAdditionalInstructions()
        {
            return "Note: a blank field will leave relevant field unmodified.\n";
        }
    }
}
