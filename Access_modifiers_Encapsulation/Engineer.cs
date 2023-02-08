using System;
using System.Collections.Generic;
using System.Text;

namespace Access_modifiers_Encapsulation
{
    class Engineer:Employee
    {

        public override double Salary 
        {
            get
            {
                return _salary;
            }
            set 
            {
                if (value>=1000)
                {
                    _salary = value;
                }
            }
        }
        public Engineer(string fullname, double salary) : base(fullname, salary)
        {
            Fullname = fullname;
            Salary = salary;
        }
    }
}
