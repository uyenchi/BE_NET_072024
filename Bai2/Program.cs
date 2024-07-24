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
            int intSo;
            // Thiết lập mã hóa UTF-8 cho đầu ra của console
            Console.OutputEncoding = Encoding.UTF8;


            //tính giai thừa của 1 số
            Console.WriteLine("Bài 4: tính giai thừa của x");
            Console.WriteLine("----------- ");
            Console.Write("x=");
            intSo = int.Parse(Console.ReadLine());
            Console.WriteLine($"Giai thừa của {intSo} là: {GiaiThua(intSo)}");
            Console.WriteLine();

            Console.WriteLine("Bài 5: Viết chương trình C# liệt kê tất cả các số nguyên tố nhỏ hơn x");
            Console.WriteLine("----------- ");
            Console.Write("x=");
            intSo = int.Parse(Console.ReadLine());
            if (intSo >1) {
                Console.WriteLine($"các số nguyên tố nhỏ hơn {intSo} là:");
                for (int i = 2; i <= intSo; i++)
                {
                    if (SoNguyenTo(i)){
                        Console.Write($" {i} ");
                    }
                }
            }
            else Console.WriteLine("Vui lòng nhập một số nguyên > 1");

            Console.WriteLine();

            Console.WriteLine("Bài 6: Kiểm tra x là số chẵn hay số lẻ trong C#");
            Console.WriteLine("----------- ");
            Console.Write("x=");
            intSo = int.Parse(Console.ReadLine());
            Console.WriteLine($"{intSo} là số {(intSo % 2 == 0 ? "chẵn" : "lẻ")}");

            Console.WriteLine("Bài 7: Kiểm tra 1 số có phải số nguyen tố không ?");
            Console.WriteLine("----------- ");
            Console.Write("x=");
            intSo = int.Parse(Console.ReadLine());
            Console.WriteLine($"{intSo} {(SoNguyenTo(intSo) ? "" : "không")} là số nguyen tố ");
            Console.WriteLine();

            Console.WriteLine("Bài 8: Cho một mảng số nguyên hãy in ra mảng sổ lẻ và mảng số chẵn");
            Console.WriteLine("----------- ");
            int[] intarrSo = new int[10];
            Console.WriteLine($"Nhập 10 phần tử của mảng:");
            NhapMangSoNguyen(ref intarrSo);
            XuatMangSoNguyen(intarrSo,"sochan");
            XuatMangSoNguyen(intarrSo, "sole");


            Console.WriteLine("Bài 9: Cho một mảng số nguyên hãy thực hiện sắp xếp dãy tang và giảm dần");
            Console.WriteLine("----------- ");

            XuatMangSoNguyen(intarrSo, "tangdan");
            XuatMangSoNguyen(intarrSo, "giamdan");
            Console.WriteLine();

            Console.WriteLine("Bài 10: Nhập một số bất kỳ và hiển thị số bằng chữ tương ứng trong C#");
            Console.WriteLine("----------- ");

            Console.WriteLine("Nhập một số từ 0 đến 999.999.999.999:");
            long lngSo = long.Parse(Console.ReadLine());

            Console.WriteLine($"Số {lngSo} bằng chữ: {Doisothanhchu(lngSo)}");
            Console.WriteLine();

            Console.ReadLine();

        }

        static string Doisothanhchu(long lgnSo)
        {
            string[]  lopso= { "tỷ", "triệu", "nghìn" };
            int[] hang = new[] { 1000000000, 1000000, 1000 };
            string strReturn = "";
            int intgroupSo = 0;

            if (lgnSo == 0) {
                return "không";
            }
            
            for (int i = 0;i<hang.Length; i++)
            {
                intgroupSo =(int)(lgnSo / hang[i]);
                if (intgroupSo>0)
                {
                    strReturn += TenMotlop3ChuSo(intgroupSo) + " " + lopso[i] + " ";
                    lgnSo %= hang[i];
                }
            }
            if (lgnSo>0) strReturn += TenMotlop3ChuSo(lgnSo);
            return strReturn;

        }
        static string TenMotlop3ChuSo(long lgnSo)
        {
            string[] tenso = new[] { "không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
            string[] tenhang = new[] {"trăm", "mười" ,""};
            int[] hang = new[] { 100,10,1 };
            string strReturn = "";
            int intChuSo = 0;

            if (lgnSo < 10)
                strReturn = tenso[lgnSo];
            else if (lgnSo <20)
                strReturn = tenhang[1] + tenso[lgnSo-10];
            else
            {
                for (int i = 0;i<tenhang.Length; i++)
                {
                    intChuSo = (int)(lgnSo / hang[i]);
                    if (intChuSo>0)
                    {
                        strReturn += tenso[intChuSo] + " " + tenhang[i] + " ";
                        lgnSo %= hang[i];
                    }
                    else
                    {
                        if (i == 1) strReturn += "lẻ ";
                    }
                }
            }

            return strReturn;
        }


        static void NhapMangSoNguyen(ref int[] intNhap)
        {
            for (int i = 0; i < intNhap.Length; i++)
            {
                intNhap[i] = int.Parse(Console.ReadLine());
            }
        }

        static void XuatMangSoNguyen(int[] intXuat,string strOptions)
        {
            switch (strOptions)
            { 
                case "sochan":
                    Console.WriteLine("Danh sách số chẳn:");
                    for (int i = 0; i < intXuat.Length; i++)
                    {
                        if (intXuat[i] % 2 == 0)
                            Console.Write(intXuat[i] + " ");
                    }
                    Console.WriteLine();
                    break;
                case "sole":
                    Console.WriteLine("Danh sách số lẻ:");
                    for (int i = 0; i < intXuat.Length; i++)
                    {
                        if (intXuat[i] % 2 != 0)
                            Console.Write(intXuat[i] + " ");
                    }
                    Console.WriteLine();
                    break;
                case "tangdan":
                    Array.Sort(intXuat);
                    Console.WriteLine("Danh sách số theo thứ tự tăng dần:");
                    for (int i = 0; i < intXuat.Length; i++)
                    {
                        Console.Write(intXuat[i] + " ");
                    }
                    Console.WriteLine();
                    break;
                case "giamdan":
                    Array.Reverse(intXuat);
                    Console.WriteLine("Danh sách số theo thứ tự giảm dần:");
                    for (int i = 0; i < intXuat.Length; i++)
                    {
                        Console.Write(intXuat[i] + " ");
                    }
                    Console.WriteLine();
                    break;
            }

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

        static bool SoNguyenTo(int so)
        {
            int i=2; 
            if (so >1) {
                while (i<= Math.Floor(Math.Sqrt(so)))
                {
                    if (so % i == 0)
                    {
                        return false;
                    }
                    i++;
                }
            }
            else return false; //1 khong phai la so nguyen to


            return true;
        }
    }
}
