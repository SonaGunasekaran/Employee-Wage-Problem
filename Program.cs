using System;

namespace EmployeeComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            int empPresent = 1;
            
            Random random = new Random();
            int empInput = random.Next(0, 2);
            if (empInput == empPresent)
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
