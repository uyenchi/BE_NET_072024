using BE072024.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE072024.DataAcceess
{
    public class Bai7
    {
        public static Phone AddPhone()
        {
            Phone phone = new Phone();

            Console.Write("Enter Phone Name: ");
            phone.Name = Console.ReadLine();

            Console.Write("Enter Phone Brand: ");
            phone.Brand = Console.ReadLine();

            Console.Write("Enter Base Price: ");
            phone.BasePrice = double.Parse(Console.ReadLine());

            Console.Write("Enter Model: ");
            phone.Model = Console.ReadLine();

            Console.Write("Enter Storage (in GB): ");
            phone.Storage = int.Parse(Console.ReadLine());

            return phone;
        }

        public static Laptop AddLaptop()
        {
            Laptop laptop = new Laptop();
            string input;
            string errorMessage;

            do
            {
                Console.Write("Enter Laptop Name: ");
                input = Console.ReadLine();
            } while (Validator.ValidateString(input, out errorMessage));

            laptop.Name = input;

            do
            {
                Console.Write("Enter Laptop Brand: ");
                input = Console.ReadLine();
            } while (Validator.ValidateString(input, out errorMessage));

            laptop.Brand = input;

            double basePrice;
            do
            {
                Console.Write("Enter Base Price: ");
                input = Console.ReadLine();
            } while (!Validator.ValidateDouble(input, out basePrice, out errorMessage));

            laptop.BasePrice = basePrice;

            do
            {
                Console.Write("Enter Processor: ");
                input = Console.ReadLine();
            } while (Validator.ValidateString(input, out errorMessage));

            laptop.Processor = input;

            int ram;
            do
            {
                Console.Write("Enter RAM (in GB): ");
                input = Console.ReadLine();
            } while (!Validator.ValidateInt(input, out ram, out errorMessage));

            laptop.RAM = ram;


            return laptop;
        }

        public static void DisplayProducts(List<Product>  products)
        {
            Console.WriteLine("\n List of Products:");
            foreach (var product in products)
            {
                Console.WriteLine(product.GetInfo());
            }
            Console.WriteLine();
        }

        public static Employee AddFullTimeEmployee()
        {
            FullTimeEmployee employee = new FullTimeEmployee();
            string input;
            string errorMessage;

            Console.Write("Nhập mã nhân viên: ");
            if (!Validator.ValidateString(Console.ReadLine(), out string id, out errorMessage))
            {
                Console.WriteLine(errorMessage);
                return null;
            }
            employee.Id = id;

            Console.Write("Nhập tên nhân viên: ");
            if (!Validator.ValidateString(Console.ReadLine(), out string name, out errorMessage))
            {
                Console.WriteLine(errorMessage);
                return null;
            }
            employee.Name = name;

            Console.Write("Nhập vị trí công việc: ");
            if (!Validator.ValidateString(Console.ReadLine(), out string position, out errorMessage))
            {
                Console.WriteLine(errorMessage);
                return null;
            }
            employee.Position = position;
            bool checkPositive;

            Console.Write("Nhập lương tháng: ");
            input = Console.ReadLine();
            if (!Validator.ValidateDouble(input, out double monthlySalary, out errorMessage, checkPositive: true))
            {
                Console.WriteLine(errorMessage);
                return null;
            }
            employee.MonthlySalary = monthlySalary;

            return employee;
        }

    }
}
