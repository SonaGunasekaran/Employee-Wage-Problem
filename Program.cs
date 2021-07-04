using System;

namespace EmployeeComputation
{
    public class Program
    {
        public static void Main(string[] args)
        {

            EmployeeBuilder amazon = new EmployeeBuilder("Amazon",20,25,50);
            amazon.ComputingWage();
            Console.WriteLine(amazon.toString());
            EmployeeBuilder sirius = new EmployeeBuilder("Sirius", 20, 15, 50);
            sirius.ComputingWage();
            Console.WriteLine(sirius.toString());
        }
    }
}