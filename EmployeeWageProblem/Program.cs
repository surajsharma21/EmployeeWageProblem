using System;

namespace EmployeeWageProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(EmpWage.computeEmpWage("DMart", 20, 2, 10));
            Console.WriteLine(EmpWage.computeEmpWage("Reliance", 10, 4, 20));
        }
    }
}
