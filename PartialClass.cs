using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PartialClass
{
    public partial class PartialEmployee
    {
        public void DisplayFullName()
        {
            Console.WriteLine(@"Full Name is :  {0} {1}", _firstName, _lastName);
        }
        public void DisplayEmployeeDetails()
        {
            Console.WriteLine("Employee Details : ");
            Console.WriteLine(@"First Name : {0}", _firstName);
            Console.WriteLine(@"Last Name : {0}", _lastName);
            Console.WriteLine(@"Gender : {0}", _gender);
            Console.WriteLine(@"Salary : {0}", _salary);
        }
    }
}
