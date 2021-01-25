using System;

namespace EntityFramework.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var provider = new EmployeeProvider(new EmployeeContext(""));
            var employee = provider.Get(1);
            Console.WriteLine($"Welcome{employee.FirstName}{employee.LastName}");
        }
    }
}
