using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_NET072024DataAccess
{
    public abstract class NhanVien
    {
        // Các thuộc tính private để bảo vệ dữ liệu
        private string hoTen;
        private string maNhanVien;
        private double luongCoBan;

        // Phương thức khởi tạo
        public NhanVien(string hoTen, string maNhanVien, double luongCoBan)
        {
            this.hoTen = hoTen;
            this.maNhanVien = maNhanVien;
            this.luongCoBan = luongCoBan;
        }

        // Getter và Setter để kiểm soát truy cập và thay đổi dữ liệu
        public string HoTen
        {
            get { return hoTen; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    hoTen = value;
                }
            }
        }

        public string MaNhanVien
        {
            get { return maNhanVien; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    maNhanVien = value;
                }
            }
        }

        public double LuongCoBan
        {
            get { return luongCoBan; }
            set
            {
                if (value > 0)
                {
                    luongCoBan = value;
                }
            }
        }

        // Phương thức tính lương (sẽ được ghi đè bởi các lớp con)
        public abstract double TinhLuong();

        // Phương thức công khai để hiển thị thông tin
        public virtual void HienThiThongTin()
        {
            Console.WriteLine($"Họ tên: {HoTen}, Mã nhân viên: {MaNhanVien}, Lương cơ bản: {LuongCoBan:C}");
        }
    }


}
