using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeComputation
{
    class EmployeeBuilder
    {
		public const int FULL_TIME = 1;
		public const int PART_TIME = 2;
		private int ratePerHour;
		private string companyName;
		private int maxWorkingDay;
		private int maxHrPerMonth;
        private int totalWage;

		public EmployeeBuilder(string companyName, int ratePerHour, int maxWorkingDay, int maxHrPerMonth)
		{
			this.companyName = companyName;
			this.ratePerHour = ratePerHour;
			this.maxHrPerMonth= maxHrPerMonth;
			this.maxWorkingDay = maxWorkingDay;
		}
        public void ComputingWage( )
        {
            //local variable
            int empHour = 0;
            int totalEmpHr= 0;
            int totalWorkingDays = 1;


            while (totalWorkingDays<= this.maxWorkingDay && totalEmpHr <= this.maxHrPerMonth)
            {
                Random random = new Random();

                //calling a Next() method

                int empInput = random.Next(0, 3);

                //calculating totalWages
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

                totalEmpHr += empHour;
                totalWorkingDays ++;
            }

            totalWage= totalEmpHr*this.ratePerHour;
           // Console.WriteLine("In" + " " + companyName + " " + "Total Employee Wage for maximum " + " " + totalWorkingDays + " " + "days = " + " " + totalWage);

        }

        public string toString()
        {
            return "In" + " " + this.companyName + " " + "Total Employee Wage for maximum " + " " + this.maxWorkingDay+ " " + "days = " + " " + this.totalWage;
        }
    }
}
	

