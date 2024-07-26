using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE072024.DataAcceess_NetFrameWork.DO
{
    public struct PhanSo
    {
        public int TuSo { get; set; }
        public int MauSo { get; set; }

        public PhanSo(int intTuso, int intMauso)
        {
            if (intMauso == 0)
            {
                throw new ArgumentException("Mẫu số phải khác 0.");
            }
            this.TuSo = intTuso;
            this.MauSo = intMauso;
        }

        // Phương thức để in phân số
        public override string ToString()
        {
            return $"{TuSo}/{MauSo}";
        }
    }
}
