using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PartialClass
{
    public partial class PartialEmployee
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
    }
}
