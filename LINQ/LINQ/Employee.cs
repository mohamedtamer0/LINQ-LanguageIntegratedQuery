using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Employee
    {

        private int _Number;
        public int Number
        {
            get { return _Number; }
            set { _Number = value; }
        }

        private string _Name;
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }


        private string _City;
        public string City
        {
            get { return _City; }
            set { _City = value; }
        }


        private int _Salary;
        public int Salary
        {
            get { return _Salary; }
            set { _Salary = value; }
        }
    }
}
