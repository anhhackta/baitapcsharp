using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitapcsharpqlnv
{
    class nhanvienhopdong : NHANVIEN
    {

        private double mucluong { set; get; }
        public nhanvienhopdong() : base() { }
        public nhanvienhopdong(double mucluong): base(NHANVIEN)
        {
            this.mucluong = mucluong;
        }

        public override void Nhap()
        {
            base.Nhap();
            Console.WriteLine("muc luong : ");
            this.mucluong = double.Parse(Console.ReadLine());
        }

        public double Luong()
        {
            return this.mucluong + luongcoban + this.phuCap();
        }
        public double phuCap()
        {
            return (base.thamNiem() >= 2) ? 200000 : 100000; 
        }
    }
}
