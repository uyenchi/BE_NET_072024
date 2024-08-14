using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE072024.DataAcceess
{
    public abstract class Employee
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }

        // Phương thức tính lương trừu tượng 
        public abstract double CalculateSalary();
    }
    //Nhân viên toàn thời gian

    public class FullTimeEmployee : Employee
    {
        public double MonthlySalary { get; set; }

        public override double CalculateSalary()
        {
            return MonthlySalary;
        }
    }
    //Nhân viên bán thời gian
    public class PartTimeEmployee : Employee
    {
        public double HourlyRate { get; set; }
        public int HoursWorked { get; set; }

        public override double CalculateSalary()
        {
            return HourlyRate * HoursWorked;
        }
    }
    //Nhân viên thực tập
    public class Intern : Employee
    {
        public double Stipend { get; set; }

        public override double CalculateSalary()
        {
            return Stipend;
        }
    }


}
