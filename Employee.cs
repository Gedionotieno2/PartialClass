using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PartialClass
{
    class Employee
    {
        private string _firstName;
        private string _lastName;
        private double _salary;
        private string _gender;
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        public double Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }
        public string Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }
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
