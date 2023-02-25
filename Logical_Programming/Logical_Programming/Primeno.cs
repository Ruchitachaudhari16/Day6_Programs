using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programming
{
    internal class Primeno
    {
        public static void PrimeCheck()
        {
            Console.WriteLine("Enter the number weather it is prime or not");
            int number=Convert.ToInt32(Console.ReadLine());
            bool ifEnterCheck = false;
            for (int i = 2; i < number ; i++)
            {
                if(number % i == 0)
                {
                    Console.WriteLine("Number is not a Prime");
                    ifEnterCheck = true;
                    break;
                }
            }
            if (ifEnterCheck == false)
            {
                Console.WriteLine("Number is a Prime");
            }
        }
    }
}
