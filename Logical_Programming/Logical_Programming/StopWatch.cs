﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programming
{
    internal class StopWatch
    {
        public static void Time_Check()
        {
            
            Console.WriteLine("Press any key to start the stopwatch");
            Console.ReadKey();
            DateTime startTime= DateTime.Now;
            Console.WriteLine("Stopwatch started.Press any key to stop");
            Console.ReadKey();
            DateTime stopTime = DateTime.Now;
            TimeSpan elapsedTime = stopTime - startTime;
            Console.WriteLine("Elapsed time: {0}", elapsedTime);
        }
    }
}
