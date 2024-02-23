using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedbackApplicatieFutureFlow
{
    internal class Feedback
    {
        public int FeedbackID { get; set; }
        public string Description { get; set; }
        public string FeedbackType { get; set; }
        public string ProfessorName { get; set; }

        // Relationship: bij een goal horen 0 of meerdere remarks
        public Goal Goal { get; set; }

        public Feedback(int feedbackID, string description, string feedbackType, string professorname, Goal goal)
        {
            FeedbackID= feedbackID;
            Description= description;
            FeedbackType= feedbackType;
            ProfessorName = professorname;
            Goal = goal;
        }
    }
}
