using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsDemoWithObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EventsClass eventObject = new EventsClass();
            eventObject.EventFromObject += EventObject_EventFromObject;
        }

        private static void EventObject_EventFromObject(object sender, EventArgs e)
        {
            
        }
    }
}
