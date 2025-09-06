using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_1___Employee_Class_with_Properties
{
    internal class Employee
    {
        private string name;
        private int id;
        private double salary;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public Employee(string name, int id, double salary)
        {
            this.name = name;
            this.id = id;
            this.salary = salary;
        }

        public string DisplayInfo()
        {
            return $"Employee Name: {name}\nEmployee ID: {id}\nEmployee Salary: {salary:C}";
        }
    }
}
