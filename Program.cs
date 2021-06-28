using System;

namespace EmployeeComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            int partTime = 2;
            int fullTime = 1;
            int empHour = 0;
            int empWage = 0;
            int empPerHour = 20;
            Random random = new Random();
            int empInput = random.Next(0, 2);
            if (empInput == fullTime)
            {
                Console.WriteLine("Employee is Working Fulltime");

                empHour = 9;

            }
            else if (empInput == partTime)
            {
                Console.WriteLine("Employee is Working Partime");

                empHour = 4;
            }

            empWage = empPerHour * empHour;
            Console.WriteLine("The daily wage of the employee = " + empWage);
        }
    }
}
