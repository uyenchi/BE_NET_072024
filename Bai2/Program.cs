using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Thiết lập mã hóa UTF-8 cho đầu ra của console
            Console.OutputEncoding = Encoding.UTF8;


            //tính giai thừa của 1 số
            Console.WriteLine("Bài 1: tính giai thừa của x");
            Console.WriteLine("----------- ");
            Console.Write("x=");
            int intSo = int.Parse(Console.ReadLine());
            Console.WriteLine($"Giai thừa của {intSo} là: {GiaiThua(intSo)}");
            Console.WriteLine();

            Console.WriteLine("Bài 2: Viết chương trình C# liệt kê tất cả các số nguyên tố nhỏ hơn x");
            Console.WriteLine("----------- ");
            Console.Write("x=");
            Console.WriteLine($"các số nguyên tố nhỏ hơn {intSo} là: {GiaiThua(intSo)}");
            Console.ReadLine();
        }

        static int GiaiThua(int so)
        {
            int intKq=1;
            //if so=0 then 0!=1

            if (so != 0)
            {
                for (int i = 1; i <= so; i++)
                {
                    intKq *=  i;
                }
            }

            return intKq;
        }
    }
}
