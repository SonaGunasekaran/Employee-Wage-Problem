using System;

namespace EmployeeComputation
{
    class Program
    { 
        public const int FULL_TIME = 1;
        public const int PART_TIME = 2;
        public const int EMP_PER_HOUR = 20;
        public const int WORKING_DAYS = 20;
        public const int WORKING_HOURS = 100;


        static void Main(string[] args)
        {
            int empHour = 0;
            int empWage = 0;
            int totalWage = 0;
            int workingDays = 1;
            int workingHours = 0;


            Random random = new Random();
            int empInput = random.Next(0, 3);
            while (workingDays <= WORKING_DAYS && workingHours <= WORKING_HOURS)
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


                empWage = EMP_PER_HOUR * empHour;
                workingHours += empHour;
                totalWage += empWage;
                if (empInput != 0)
                {
                    workingDays++;
                }
            }

                Console.WriteLine("The Employee Wage for maximum working days = " + totalWage);
                  
            
        }
    }
}
