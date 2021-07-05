using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeComputation
{
    class EmpComputeWage 
    {

        public const int FULL_TIME = 1;
        public const int PART_TIME = 2;
        public int ratePerHour;
        public string companyName;
        public int maxWorkingDay;
        public int maxHrPerMonth;
        public int totalWage;
        private List<int> dailywage;

        public EmpComputeWage(string companyName, int ratePerHour, int maxWorkingDay, int maxHrPerMonth)
        {
            this.companyName = companyName;
            this.ratePerHour = ratePerHour;
            this.maxHrPerMonth = maxHrPerMonth;
            this.maxWorkingDay = maxWorkingDay;
            dailywage = new List<int>();
        }
        public void setTotalEmpWage(int totalWage)
        {
            this.totalWage = totalWage;
        }

        public void SetDailyWage(int totalWage , EmpComputeWage empComputeWage)
        {
            empComputeWage.dailywage.Add(totalWage);
        }

        public string toString()
        {
            return "Total Employee wage for Company " + this.companyName + " is " + this.totalWage;
        }

        public void DailyWage(EmpComputeWage empComputeWage)
        {
            int day = 1;
            foreach (int totalWage in empComputeWage.dailywage)
            {
                Console.WriteLine("Day{0}:{1}", day, totalWage);
                day++;
            }
        }
    }
}
