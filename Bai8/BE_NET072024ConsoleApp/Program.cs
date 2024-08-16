using BE_NET072024DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_NET072024ConsoleApp
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            // Tạo đối tượng nhân viên full-time
            NhanVienFullTime nvFullTime = new NhanVienFullTime("Nguyễn Văn A", "NV001", 5000000, 2000000);

            // Tạo đối tượng nhân viên part-time
            NhanVienPartTime nvPartTime = new NhanVienPartTime("Trần Thị B", "NV002", 0, 120, 50000);

            // Gọi phương thức TinhLuong và HienThiThongTin
            nvFullTime.HienThiThongTin();
            Console.WriteLine();
            nvPartTime.HienThiThongTin();

            Console.ReadKey();
        }
    }
}
