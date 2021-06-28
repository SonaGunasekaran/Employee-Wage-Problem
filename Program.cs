using System;

namespace EmployeeComputation
{
    class Program
    { 
        public const int FULL_TIME = 1;
        public const int PART_TIME = 2;
        public const int EMP_PER_HOUR = 20;
    
        static void Main(string[] args)
        {
            int empHour = 0;
            int empWage = 0;
            
            Random random = new Random();
            int empInput = random.Next(0, 3);
            switch (empInput)
            {
                case FULL_TIME:
                    Console.WriteLine("Employee is Working Fulltime");
                    empHour = 8;
                    break;

                case PART_TIME:

                    Console.WriteLine("Employee is Working Partime");
                    empHour = 4;
                    break;

                default:
                    empHour = 0;
                    break;

            }

                    empWage = EMP_PER_HOUR * empHour;
                    Console.WriteLine("The daily wage of the employee = " + empWage);
            
        }
    }
}
