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

        public EmpComputeWage(string companyName, int ratePerHour, int maxWorkingDay, int maxHrPerMonth)
        {
            this.companyName = companyName;
            this.ratePerHour = ratePerHour;
            this.maxHrPerMonth = maxHrPerMonth;
            this.maxWorkingDay = maxWorkingDay;
        }
        public void setTotalEmpWage(int totalWage)
        {
            this.totalWage = totalWage;
        }
        public string toString()
        {
            return "Total Employee wage for Company " + this.companyName + " is " + this.totalWage;
        }
    }
}
