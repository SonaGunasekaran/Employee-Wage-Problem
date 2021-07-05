using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeComputation
{
    

         public interface IComputeEmpWage
        {
            public void addCompanyEmpWage(string compName, int ratePerHour, int maxWorkDays, int maxWorkHrs);
            public void EmployeeCompute();

        }
    
}
