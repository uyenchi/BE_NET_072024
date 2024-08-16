using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_NET072024DataAccess
{
    public class NhanVienPartTime : NhanVien
    {
        // Thuộc tính private
        private double soGioLamViec;
        private double luongGio;

        public NhanVienPartTime(string hoTen, string maNhanVien, double luongCoBan, double soGioLamViec, double luongGio) : base(hoTen, maNhanVien, luongCoBan)
        {
            this.soGioLamViec = soGioLamViec;
            this.luongGio = luongGio;
        }

        // Getter và setter cho thuộc tính 'soGioLamViec' và 'luongGio'
        public double SoGioLamViec
        {
            get { return soGioLamViec; }
            set
            {
                if (value > 0)
                {
                    soGioLamViec = value;
                }
            }
        }

        public double LuongGio
        {
            get { return luongGio; }
            set
            {
                if (value > 0)
                {
                    luongGio = value;
                }
            }
        }

        // Ghi đè phương thức TinhLuong để tính lương cho nhân viên part-time
        public override double TinhLuong()
        {
            return SoGioLamViec * LuongGio;
        }

        // Ghi đè phương thức HienThiThongTin để hiển thị thông tin cụ thể của nhân viên part-time
        public override void HienThiThongTin()
        {
            base.HienThiThongTin();
            Console.WriteLine($"Số giờ làm việc: {SoGioLamViec}, Lương giờ: {LuongGio:C}");
        }
    }

}
