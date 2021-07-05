using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeComputation
{
    public class EmployeeBuilder : IComputeEmpWage //Interface Method
    {
        public const int FULL_TIME = 1;
        public const int PART_TIME = 2;

        private int numOfCompany = 0;
        //initializing array
        //private EmpComputeWage[] companyEmpWageArray;
       List<EmpComputeWage> empComputeList;
        Dictionary<string, EmpComputeWage> companyComputeList;

        public EmployeeBuilder()
        {
            this.empComputeList = new List<EmpComputeWage>();
            this.companyComputeList = new Dictionary<string, EmpComputeWage>();
        }
        public void addCompanyEmpWage(String companyName, int ratePerHour, int maxWorkingHr, int maxHrPerMonth)
        {
            EmpComputeWage emp = new EmpComputeWage( companyName,  ratePerHour,  maxWorkingHr,  maxHrPerMonth);
            this.empComputeList.Add(emp);
            this.companyComputeList.Add(companyName, emp);
        }
        public void EmployeeCompute()
        {
            foreach (EmpComputeWage emp in this.empComputeList)
            {
                emp.setTotalEmpWage(this.EmployeeCompute(emp));
                emp.DailyWage(emp);
                Console.WriteLine("enter 1 if daily wages has to be displayed");
                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 1)
                {
                    emp.DailyWage(emp);
                }

                Console.WriteLine(emp.toString());
            }
        }
        private int EmployeeCompute(EmpComputeWage empComputeWage)
        {
            //local variable

            int empHour = 0;
            int totalEmpHr= 0;
            int empWage = 0;
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
                empWage=empHour + empComputeWage.ratePerHour;
                empComputeWage.SetDailyWage(empWage, empComputeWage);
                totalWorkingDays ++;
            }

            return totalEmpHr*empComputeWage.ratePerHour;
           
        }

        public int GetEmployeeWage(string company)
        {
           // int totalWage;
            return (this.companyComputeList[company].totalWage);
        }


    }
}
	

