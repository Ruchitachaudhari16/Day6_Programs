﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programming
{
    internal class Fibonacci
    {
        public static int PreviousToPrevious = 0;
        public static int Next = 1;
        public static int Previous = 0;

        public static void GetSeries()
        {
            Console.WriteLine("Please enter the number to find fiboniciseries");
            int input = Convert.ToInt32(Console.ReadLine());
            while (Next < input)
            {
                PreviousToPrevious = Previous;
                Previous = Next;
                Next = PreviousToPrevious + Previous;
                Console.WriteLine(Previous);
            }


        }
    }
}

    
