using BE072024.DataAcceess_NetFrameWork.DO;
using BE072024.DataAcceess_NetFrameWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BE_07.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Thiết lập mã hóa UTF-8 cho đầu ra của console
            Console.OutputEncoding = Encoding.UTF8;
            int intTuSo, intMauSo;
            // Nhập hai phân số từ người dùng
            Console.WriteLine("Nhập phân số thứ nhất ");
            Console.Write("Tử số: ");
            intTuSo=int.Parse(Console.ReadLine());
            Console.Write("Mẫu số: ");
            intMauSo = int.Parse(Console.ReadLine());

            PhanSo objPhanSo1 = new PhanSo(intTuSo,intMauSo);

            Console.WriteLine("Nhập phân số thứ hai ");
            Console.Write("Tử số: ");
            intTuSo = int.Parse(Console.ReadLine());
            Console.Write("Mẫu số: ");
            intMauSo = int.Parse(Console.ReadLine());

            PhanSo objPhanSo2 = new PhanSo(intTuSo, intMauSo);

            // Thực hiện các phép toán và in kết quả
            PhanSo objKetqua= Bai3_1.Cong(objPhanSo1,objPhanSo2);

            Console.WriteLine($"Tổng: {objKetqua.ToString()}");

            objKetqua = Bai3_1.Tru(objPhanSo1, objPhanSo2);
            Console.WriteLine($"Hiệu: {objKetqua.ToString()}");

            objKetqua = Bai3_1.Nhan(objPhanSo1, objPhanSo2);
            Console.WriteLine($"Tích: {objKetqua.ToString()}");

            objKetqua = Bai3_1.Chia(objPhanSo1, objPhanSo2);
            Console.WriteLine($"Thương: {objKetqua.ToString()}");

            Console.ReadKey();
        }
    }
}
