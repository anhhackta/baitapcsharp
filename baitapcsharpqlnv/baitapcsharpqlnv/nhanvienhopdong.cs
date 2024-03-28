using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitapcsharpqlnv
{
    class nhanvienhopdong : NHANVIEN
    {

        private double mucluong;

        public double Mucluong
        {
            set { this.mucluong = value; }
            get { return this.mucluong; }
        }
        public nhanvienhopdong() : base() { }
        public nhanvienhopdong(double mucluong, string manv, string hoten, DateTime namsinh, string gioitinh, string cmnd, DateTime ngayvaocq) : base(manv, hoten, namsinh, gioitinh, cmnd, ngayvaocq)
        {
            this.mucluong = mucluong;
        }

        public override double phuCap()
        {
            return (base.thamNiem() >= 2) ? (this.mucluong * 0.1 + 200000) : (this.mucluong * 0.1 + 100000);
        }
        public override double Luong()
        {
            return (this.mucluong + luongcoban) + this.phuCap();
        }
        

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("______________________\nNhap muc luong : ");
            this.mucluong = double.Parse(Console.ReadLine());
        }

        
        public override void Xuat()
        {
            base.Xuat();
            Console.Write("**  Thuoc : Nhan vien hop dong\n");
            Console.WriteLine("** Muc luong : " + this.mucluong);
            Console.WriteLine("**  Phu Cap : " + this.phuCap());
            Console.WriteLine("**  Luong : " + this.Luong());
        }
    }
}
