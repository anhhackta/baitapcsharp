using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitapcsharpqlnv
{
    class nhanvienbienche : NHANVIEN
    {
        private double hesoluong { set; get; }


        public nhanvienbienche() : base()
        {

        }
        public nhanvienbienche(double hesoluong, string manv, string hoten, DateTime namsinh, string gioitinh, string cmnd, DateTime ngayvaocq) : base(manv, hoten, namsinh, gioitinh, cmnd, ngayvaocq)
        {
            this.hesoluong = hesoluong;
        }
        public override void Nhap()
        {
            base.Nhap();
            Console.WriteLine("Nhap he so  luong : ");
            this.hesoluong = double.Parse(Console.ReadLine());
        }
        public double Luong()
        {
            return this.hesoluong * luongcoban + this.phuCap();
        }

        public double phuCap()
        {
            return (base.thamNiem() >= 10) ? 500000 : 200000;
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.Write("Thuoc : Nhan vien bien che");
            Console.WriteLine("Luong : "+ this.Luong());
        }
        
    }
}
