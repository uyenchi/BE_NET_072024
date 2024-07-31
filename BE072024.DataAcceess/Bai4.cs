using BE072024.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using OfficeOpenXml;


namespace BE072024.DataAcceess
{
    public class Bai4
    {
        public static Employee[] InputEmployees()
        {
            Console.Write("Nhập số lượng nhân viên: ");
            int numEmployees = int.Parse(Console.ReadLine());
            Employee[] employees = new Employee[numEmployees];

            for (int i = 0; i < employees.Length-1; i++)
            {
                Console.WriteLine($"Nhập thông tin cho nhân viên thứ {i + 1}:");
                int id;
                string fullname;
                DateTime dateJoined;
                double salary;
                string jobTitle;
                string errorMessage;

                do
                {
                    Console.Write("Mã nhân viên: ");
                    string input = Console.ReadLine();
                    if (!Validator.ValidateInt(input, out id, out errorMessage))
                    {
                        Console.WriteLine(errorMessage);
                    }
                } while (errorMessage != null);

                do
                {
                    Console.Write("Tên nhân viên: ");
                    string input = Console.ReadLine();
                    if (!Validator.ValidateString(input, out fullname, out errorMessage))
                    {
                        Console.WriteLine(errorMessage);
                    }
                } while (errorMessage != null);

                do
                {
                    Console.Write("Ngày vào công ty (dd-MM-yyyy): ");
                    string input = Console.ReadLine();
                    if (!Validator.ValidateDateTime(input, out dateJoined, out errorMessage))
                    {
                        Console.WriteLine(errorMessage);
                    }
                } while (errorMessage != null);

                do
                {
                    Console.Write("Hệ số lương: ");
                    string input = Console.ReadLine();
                    if (!Validator.ValidateDouble(input, out salary, out errorMessage))
                    {
                        Console.WriteLine(errorMessage);
                    }
                } while (errorMessage != null);

                do
                {
                    Console.Write("Vị trí công việc: ");
                    string input = Console.ReadLine();
                    if (!Validator.ValidateString(input, out jobTitle, out errorMessage))
                    {
                        Console.WriteLine(errorMessage);
                    }
                } while (errorMessage != null);

                employees[i] = new Employee(id, fullname, dateJoined, salary, jobTitle);
            }

            Console.WriteLine("Đã nhập xong danh sách nhân viên.");

            return employees;
        }

        public static Employee[] InputEmployeesFromExcel(string fileName)
        {
            // Thiết lập LicenseContext cho EPPlus
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial; // Set license context for EPPlus

            Employee[] employees;


            fileName = Path.Combine(Directory.GetCurrentDirectory(), fileName);
            FileInfo file = new FileInfo(fileName);

            if (!file.Exists)
            {
                Console.WriteLine("File không tồn tại.");
                return new Employee[0];
            }

            try
            {
                using (ExcelPackage package = new ExcelPackage(file))
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                    int rowCount = worksheet.Dimension.Rows;

                    employees = new Employee[rowCount - 1]; // Trừ đi 1 để bỏ qua tiêu đề

                    for (int row = 2; row <= rowCount; row++) // Bắt đầu từ dòng 2 để bỏ qua tiêu đề
                    {
                        try
                        {
                            int id;
                            string fullname;
                            DateTime dateJoined;
                            double salary;
                            string jobTitle;
                            string errorMessage;

                            if (!Validator.ValidateInt(worksheet.Cells[row, 1].Text, out id, out errorMessage))
                                throw new Exception($"Lỗi ở dòng {row}, cột 1: {errorMessage}");

                            if (!Validator.ValidateString(worksheet.Cells[row, 2].Text, out fullname, out errorMessage))
                                throw new Exception($"Lỗi ở dòng {row}, cột 2: {errorMessage}");

                            if (!Validator.ValidateDateTime(worksheet.Cells[row, 3].Text, out dateJoined, out errorMessage))
                                throw new Exception($"Lỗi ở dòng {row}, cột 3: {errorMessage}");

                            if (!Validator.ValidateDouble(worksheet.Cells[row, 4].Text, out salary, out errorMessage))
                                throw new Exception($"Lỗi ở dòng {row}, cột 4: {errorMessage}");

                            if (!Validator.ValidateString(worksheet.Cells[row, 5].Text, out jobTitle, out errorMessage))
                                throw new Exception($"Lỗi ở dòng {row}, cột 5: {errorMessage}");

                            employees[row - 2] = new Employee(id, fullname, dateJoined, salary, jobTitle);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                }

                Console.WriteLine("Đã nhập xong danh sách nhân viên từ file Excel.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi đọc file Excel: {ex.Message}");
                return new Employee[0];
            }
            return employees;
        }

        public static void DisplayEmployees(Employee[] employees)
        {
            if (employees == null || employees.Length == 0)
            {
                Console.WriteLine("Danh sách nhân viên trống.");
                return;
            }

            Console.WriteLine("Danh sách nhân viên:");
            foreach (var employee in employees)
            {
                Console.WriteLine($"Mã nhân viên: {employee.EmployeeID}, Tên: {employee.FullName}, Ngày vào công ty: {employee.DateJoined:yyyy-MM-dd}, Hệ số lương: {employee.Salary}, Vị trí: {employee.Jobtitle}");
            }
        }

        public static Employee[] FilterEmployeesByMilestones(Employee[] employees,int milestones)
        {

            //Employee[] filteredEmployees = new Employee[];
            var filteredEmployees = new System.Collections.Generic.List<Employee>();

            foreach (var employee in employees)
            {
                int yearsWorked = DateTime.Now.Year - employee.DateJoined.Year;
                if (yearsWorked == milestones)
                {
                    filteredEmployees.Add(employee);
                }
            }
            
            Employee[] empReturn= filteredEmployees.ToArray();

            return empReturn;
    }
    }
    
}
