using System;

namespace EmployeeComputation
{
    public class Program
    {
        public const int FULL_TIME = 1;
        public const int PART_TIME = 2;
        public const int EMP_PER_HOUR = 20;
        public const int MAX_WORKING_DAYS = 20;
        public const int MAX_WORKING_HOURS = 100;

        public static void Main(string[] args)
        {

            ComputingWage();
            //ComputingWage("Tvs Next", 10, 20, 100);

        }



        public static void ComputingWage()
        {
            int empHour = 0;
            int empWage = 0;
            int totalWage = 0;
            int workingDays = 1;
            int workingHours = 0;


            Random random = new Random();
            int empInput = random.Next(0, 3);
            while (workingDays <= MAX_WORKING_DAYS && workingHours <= MAX_WORKING_HOURS)
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

            Console.WriteLine("Total Employee Wage for maximum " + " " + workingDays + " " + "days = " + " " + totalWage);
        }
    }
}
