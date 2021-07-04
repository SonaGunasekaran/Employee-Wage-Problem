using System;

namespace EmployeeComputation
{
    public class Program
    {
        public static void Main(string[] args)
        {

            EmployeeBuilder companyempWage = new EmployeeBuilder();
            companyempWage.addCompanyEmpWage("Amazon", 10, 20, 40);
            companyempWage.addCompanyEmpWage("Sirius", 20, 10, 30);
            companyempWage.EmployeeCompute();
        }
    }
}