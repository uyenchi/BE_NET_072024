using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_NET072024DataAccess
{
    public class NhanVienFullTime : NhanVien
    {
        // Thuộc tính private
        private double thuong;

        public NhanVienFullTime(string hoTen, string maNhanVien, double luongCoBan, double thuong) : base(hoTen, maNhanVien, luongCoBan)
        {
            this.thuong = thuong;
        }

        // Ghi đè phương thức TinhLuong() để tính lương cho nhân viên full-time
        public override double TinhLuong()
        {
            return LuongCoBan + thuong;
        }
    }
}
