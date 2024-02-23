using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedbackApplicatieFutureFlow
{
    internal class Task
    {
        public int TaskID { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }

        // Relationship: een of meerdere tasks horen bij een goal
        public Goal Goal { get; set; }

        public Task(int taskID, string description, string status, Goal goal)
        {
            TaskID = taskID;
            Description = description;
            Status = status;
            Goal = goal;
        }
    }
}
