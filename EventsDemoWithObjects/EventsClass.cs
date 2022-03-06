using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsDemoWithObjects
{
    public class EventsClass
    {
        public int Id { get; set; }

        public event EventHandler<EventArgs> EventFromObject;
    }
}
