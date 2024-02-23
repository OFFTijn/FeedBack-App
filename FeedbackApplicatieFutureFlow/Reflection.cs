using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedbackApplicatieFutureFlow
{
    internal class Reflection
    {
        public int ReflectionID { get; set; }
        public string Description { get; set; }

        // Relationship: bij ieder goal kan je 0 of 1 reflectie hebben.
    }
}
