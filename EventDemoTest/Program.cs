using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace EventDemoTest
{
    public class Program
    {
        public static event EventHandler<EventArgs> EventByHandler;

        //Old fashioned way
        public delegate void EventWithDelegate(object sender, EventArgs e);
        public static event EventWithDelegate EventByDelegate;

        public static void Main(string[] args)
        {
            EventByHandler += Program_EventByHandler;
            EventByDelegate += Program_EventByDelegate;
            Console.Write("Start event demo:");
            for (int i = 0; i < 3; i++)
            {
                Thread.Sleep(1000);
                Console.Write('.');
            }
            Console.WriteLine();
            EventByHandler?.Invoke(null, EventArgs.Empty);
            OnEventWithDelegate();
            Console.WriteLine("Demo finished! Press any key to exit...");
            Console.ReadKey();
        }

        private static void Program_EventByDelegate(object sender, EventArgs e)
        {
            Console.WriteLine("Event triggered by EventDelegate!");
        }

        private static void Program_EventByHandler(object sender, EventArgs e)
        {
            Console.WriteLine("Event triggered by EventHandler!");
        }

        // Old fashioned way
        public static void OnEventWithDelegate()
        {
            if (EventByDelegate != null)
            {
                Program_EventByDelegate(null, EventArgs.Empty);
            }

            //EventByDelegate?.Invoke(null, EventArgs.Empty);
        }
    }
}
