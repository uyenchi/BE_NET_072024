using BE072024.DataAcceess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BE072024.DataAcceess
{
    public abstract class Product
    {
        public string Name { get; set; }
        public string Brand { get; set; }
        public double BasePrice { get; set; }

        // Phương thức tính giá bán
        public abstract double GetPrice();

        // Phương thức lấy thông tin sản phẩm
        public abstract string GetInfo();
    }

}
    public class Phone : Product
    {
        public string Model { get; set; }
        public int Storage { get; set; } // Dung lượng lưu trữ

        public override double GetPrice()
        {
            // Ví dụ tính giá bán dựa trên dung lượng lưu trữ
            return BasePrice ;
        }

        public override string GetInfo()
        {
            return $"Phone: {Brand} {Name}, Model: {Model}, Storage: {Storage}GB, Price: {GetPrice():C}";
        }
    }

    public class Laptop : Product
    {
        public string Processor { get; set; }
        public int RAM { get; set; } // Dung lượng RAM

        public override double GetPrice()
        {
            // Ví dụ tính giá bán dựa trên bộ vi xử lý và RAM
            return BasePrice + (RAM * 100);
        }

        public override string GetInfo()
        {
            return $"Laptop: {Brand} {Name}, Processor: {Processor}, RAM: {RAM}GB, Price: {GetPrice():C}";
        }
    }



