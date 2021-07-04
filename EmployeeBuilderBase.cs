namespace EmployeeComputation
{
    public class EmployeeBuilderBase
    {
        public int EmployeeCompute(EmpComputeWage empComputeWage)
        {
            //local variable

            int empHour = 0;
            int totalEmpHr = 0;
            int totalWorkingDays = 1;


            while (totalWorkingDays <= empComputeWage.maxWorkingDay && totalEmpHr <= empComputeWage.maxHrPerMonth)
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
                totalWorkingDays++;
            }

            return totalEmpHr * empComputeWage.ratePerHour;

        }
    }
}