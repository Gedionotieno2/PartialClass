using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PartialClass
{
    class Program
    {
        static void Main(string[] args)
        {
            PartialEmployee emp = new PartialEmployee();
            emp.FirstName = "Pranaya";
            emp.LastName = "Rout";
            emp.Salary = 100000;
            emp.Gender = "Male";
            emp.DisplayFullName();
            emp.DisplayEmployeeDetails();
            Console.WriteLine("Press any key to exist.");
            Console.ReadKey();
        }
    }
}
