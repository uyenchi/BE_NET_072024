using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE072024.DataAcceess
{
    public struct Employee
    {
        public int EmployeeID;
        public string FullName;
        public DateTime DateJoined;
        public double Salary;
        public string Jobtitle;

        public Employee(int id, string name, DateTime dateJoined, double salary, string jobtitle)
        {
            EmployeeID = id;
            FullName = name;
            DateJoined = dateJoined;
            Salary = salary;
            Jobtitle = jobtitle;
        }
    }
}
