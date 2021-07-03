using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeComputation
{
    public class EmployeeWage
    {
        public const int FULL_TIME = 1;
        public const int PART_TIME = 2;
        public const int EMP_PER_HOUR = 20;
        


        public static int ComputingWage(string companyName,int maxWorkingDay,int maxWorkingHr)
        {
            //local variable
            int empHour = 0;
            int empWage = 0;
            int totalWage = 0;
            int workingDays = 1;
            int workingHours = 0;


            Random random = new Random();

            //calling a Next() method

            int empInput = random.Next(0, 3);

            //calculating totalWages

            while (workingDays <= maxWorkingDay && workingHours <= maxWorkingHr)
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

               //Formula for calculate Employee Wage

                empWage = EMP_PER_HOUR * empHour;

                workingHours += empHour;

                totalWage += empWage;

                if (empInput != 0)
                {
                    workingDays++;
                }


            }

            Console.WriteLine("In"+" "+ companyName + " "+"Total Employee Wage for maximum " + " " + workingDays + " " + "days = " + " " + totalWage);
            
            return totalWage;
        }
    }
}

