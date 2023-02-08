using System;
using System.Collections.Generic;
using System.Text;

namespace Access_modifiers_Encapsulation
{
     class Employee
     {
        public string Fullname;
        protected double _salary;

        public virtual double Salary
        {
            get
            {
                return _salary;
            }
            set
            {
                if (value>=300)
                {
                    _salary = value;
                }
            }
        }
        public Employee(string fullname,double salary)
        {
            Fullname = fullname;
            Salary = salary;
        }
    }
}
