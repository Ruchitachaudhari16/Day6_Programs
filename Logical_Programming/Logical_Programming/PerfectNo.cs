namespace Logical_Programming
{
    internal class PerfectNo
    {
        public static void Perfect_Nocheck()
        {
            Console.WriteLine("Enter the number to check");
            int input = Convert.ToInt32(Console.ReadLine());

            int accumulator = 0;
            for (int i = 1; i < input; i++)
            {
                if (input % i == 0)
                {
                    accumulator += 1;
                }
            }
            if (accumulator == input)
            {
                Console.WriteLine("The number is  perfect");
            }
            else
            {
                Console.WriteLine("The number is a not perfect number");
            }
        }
    }
}

