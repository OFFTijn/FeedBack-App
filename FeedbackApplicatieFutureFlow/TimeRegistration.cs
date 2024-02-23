using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedbackApplicatieFutureFlow
{
    internal class TimeRegistration
    {
        public int TimeRegistrationID { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }
        public string Time { get; set; }    

        // Relationship: bij een task hoort 0 of een tijdsregistratie
    }
}
