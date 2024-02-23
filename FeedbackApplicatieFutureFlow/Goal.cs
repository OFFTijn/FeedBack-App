using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedbackApplicatieFutureFlow
{
    public class Goal
    {
        public int GoalID { get; set; }
        public string Description { get; set; }
        public string Week { get; set; }

        // Een goal kan niet bestaan zonder een account
        public Account Account { get; set; }

        // bij een doel kan een keer feedback gegeven worden
        /*public Feedback Feedback { get; set; }*/

        public Goal(int goalID, string description, string week, Account account)
        {
            GoalID = goalID;
            Description = description;
            Week = week;
            Account = account;
        }

    }
}
