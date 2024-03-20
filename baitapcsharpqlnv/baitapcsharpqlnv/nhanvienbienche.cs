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
        public nhanvienbienche(double hesoluong) : base(NHANVIEN)
        {
            this.hesoluong = hesoluong;
        }
        public override void Nhap()
        {
            base.Nhap();
            Console.WriteLine("he so  luong : ");
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
        
    }
}
