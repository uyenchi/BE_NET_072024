using BE072024.DataAcceess_NetFrameWork.DO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE072024.DataAcceess_NetFrameWork
{
    public class Bai3_1
    {
        // Phương thức cộng hai phân số
        public static PhanSo Cong(PhanSo objphso1, PhanSo objphso2)
        {
            int intMauso = BCNN(objphso1.MauSo, objphso2.MauSo);
            int intTuSo = objphso1.TuSo * intMauso + objphso2.TuSo * intMauso;

            return new PhanSo(intTuSo, intMauso);
        }

        // Phương thức trừ hai phân số
        public static PhanSo Tru(PhanSo objphso1, PhanSo objphso2)
        {
            int intMauso = BCNN(objphso1.MauSo, objphso2.MauSo);
            int intTuSo = objphso1.TuSo * intMauso - objphso2.TuSo * intMauso;

            return new PhanSo(intTuSo, intMauso);
        }

        // Phương thức nhân hai phân số
        public static PhanSo Nhan(PhanSo objphso1, PhanSo objphso2)
        {
            int intTuSo = objphso1.TuSo * objphso2.TuSo;
            int intMauso = objphso1.MauSo * objphso2.MauSo;

            return new PhanSo(intTuSo, intMauso);
        }

        // Phương thức chia hai phân số
        public static PhanSo Chia(PhanSo objphso1, PhanSo objphso2)
        {
            if (objphso2.TuSo == 0)
            {
                throw new ArgumentException("Không thể chia cho 0.");
            }

            int intTuSo = objphso1.TuSo * objphso2.MauSo;
            int intMauso = objphso1.MauSo * objphso2.TuSo;

            return new PhanSo(intTuSo, intMauso);

        }

        // Hàm tìm ước chung lớn nhất
        static int BCNN(int a, int b)
        {
            int ucln = UCLN(a, b);
            return (a * b) / ucln;
        }
        // Hàm tìm ước chung lớn nhất
        static int UCLN(int a, int b)
        {
            while (b != 0)
            {
                int temp = a % b;
                a = b;
                b = temp;
            }
            return a;
        }
    }
}
