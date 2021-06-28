using System;

namespace EmployeeComputation
{
    class Program
    { 
        public const int FULL_TIME = 1;
        public const int PART_TIME = 2;
        public const int EMP_PER_HOUR = 20;
        public const int WORKING_DAYS = 20;


        static void Main(string[] args)
        {
            int empHour = 0;
            int empWage = 0;
            int totalWage = 0;
            
            Random random = new Random();
            int empInput = random.Next(0, 3);
            for (int day = 1; day <= WORKING_DAYS; day++)
            {
                switch (empInput)
                {
                    case FULL_TIME:
                        
                        empHour = 8;
                        break;

                    case PART_TIME:

                        
                        empHour = 4;
                        break;

                    default:
                        empHour = 0;
                        break;

                }
            }

                    empWage = EMP_PER_HOUR * empHour;
                    totalWage += empWage;
                    Console.WriteLine("The daily wage of the employee = " + empWage);
            
        }
    }
}
