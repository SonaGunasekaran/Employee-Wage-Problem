using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeComputation
{
    public class EmployeeBuilder
    {
        public const int FULL_TIME = 1;
        public const int PART_TIME = 2;

        private int numOfCompany = 0;
        private EmpComputeWage[] companyEmpWageArray;


        public EmployeeBuilder()
        {
            this.companyEmpWageArray = new EmpComputeWage[5];
        }
        public void addCompanyEmpWage(String companyName, int ratePerHour, int maxWorkingHr, int maHrPerMonth)
        {
            companyEmpWageArray[this.numOfCompany] = new EmpComputeWage(companyName,ratePerHour, maxWorkingHr, maHrPerMonth);
            numOfCompany++;
        }
        public void EmployeeCompute()
        {
            for (int i = 0; i < numOfCompany; i++)
            {
                companyEmpWageArray[i].setTotalEmpWage(this.EmployeeCompute(this.companyEmpWageArray[i]));
                Console.WriteLine(this.companyEmpWageArray[i].toString());
            }
        }
        public int EmployeeCompute(EmpComputeWage empComputeWage)
        {
            //local variable

            int empHour = 0;
            int totalEmpHr= 0;
            int totalWorkingDays = 1;


            while (totalWorkingDays<=empComputeWage.maxWorkingDay && totalEmpHr <= empComputeWage.maxHrPerMonth)
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

            return totalEmpHr*empComputeWage.ratePerHour;
           
        }


    }
}
	

