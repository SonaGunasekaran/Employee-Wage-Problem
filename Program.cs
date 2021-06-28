using System;

namespace EmployeeComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            int empPresent = 1;
            int empHour = 0;
            int empWage = 0;
            int empPerHour = 20;
            Random random = new Random();
            int empInput = random.Next(0, 2);
            if (empInput == empPresent)
            {
                Console.WriteLine("Employee is Present");
                empHour = 8;
            }
            else
            {
                Console.WriteLine("Employee is Absent");
                empHour = 0;
            }

            empWage = empPerHour * empHour;
            Console.WriteLine("The daily wage of the employee = " + empWage);
        }
    }
}
