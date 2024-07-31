using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE072024.DataAcceess;

namespace BE_07.ConsoleApp
{
    internal class Program
    {
        public static Employee[] employees;
        static void Main()
        {
            // Thiết lập mã hóa UTF-8 cho đầu ra của console
            Console.OutputEncoding = Encoding.UTF8;

            while (true)
            {
                Console.WriteLine("Chọn một chức năng:");
                Console.WriteLine("1. Nhập danh sách Nhân viên từ bàn phím");
                Console.WriteLine("2. Nhập danh sách Nhân viên từ file Excel");
                Console.WriteLine("3. Hiển thị danh sách Nhân viên");
                Console.WriteLine("4. Hiển thị danh sách Nhân viên có thời gian làm việc 5 năm ");
                Console.WriteLine("0. Thoát");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        employees=Bai4.InputEmployees();
                        break;
                    case 2:
                        employees=Bai4.InputEmployeesFromExcel("dsNhanvien.xlsx");
                        break;
                    case 3:
                        Bai4.DisplayEmployees(employees);
                        break;
                    case 4:
                        if (employees == null || employees.Length == 0)
                        {
                            Console.WriteLine("Danh sách nhân viên trống.");
                        }
                        else
                        {
                            Employee[] employeefilter;
                            employeefilter = Bai4.FilterEmployeesByMilestones(employees, 5);

                            if (employeefilter.Length==0)
                            {
                                Console.WriteLine("Khong có nhân viên có thời gian làm việc 5 năm.");
                            }
                            else
                            {
                                Console.WriteLine("Danh sách nhân viên có thời gian làm việc 5 năm.");

                                Bai4.DisplayEmployees(employeefilter);
                            }


                        }
                        break;
                    case 0:
                        return;
                    default:
                        Console.WriteLine("Chức năng không hợp lệ.");
                        break;
                }
            }
        }
    }
}
