using System;

namespace EmployeeWageProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            EmpWage dMart = new EmpWage("DMart", 20, 2, 10);
            EmpWage reliance = new EmpWage("Reliance", 10, 4, 20);
            dMart.computeEmpWage();
            reliance.computeEmpWage();
            Console.WriteLine(dMart.toString());
            Console.WriteLine(reliance.toString());
        }
    }
}
