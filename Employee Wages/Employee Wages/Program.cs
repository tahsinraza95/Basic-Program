using System;

namespace Employee_Wages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int RANDOM = 1;
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == RANDOM)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }
    }
}
