using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitapcsharpqlnv
{
    class NHANVIEN
    {

        protected String manv;
        protected String hoten;
        protected DateTime namsinh;
        protected String gioitinh;
        protected String cmnd;
        protected DateTime ngayvaocq;
        public const double luongcoban = 1490000;

        public NHANVIEN()
        {
            //this.manv = DemMANV();

        }
        public String Manv
        {
            set { this.manv = value; }
            get { return this.manv; }
        }
        public String Hoten
        {
            set { this.hoten = value; }
            get { return this.hoten; }
        }
        public String Gioitinh
        {
            set { this.gioitinh = value; }
            get { return this.gioitinh; }
        }
        public DateTime Namsinh
        {
            set { this.namsinh = value; }
            get { return this.namsinh; }
        }
        public DateTime Ngayvaocq
        {
            set { this.ngayvaocq = value; }
            get { return this.ngayvaocq; }
        }
        public String Cmnd
        {
            set { this.cmnd = value; }
            get { return this.cmnd; }
        }

        public NHANVIEN(String manv ,String hoten, DateTime namsinh, String gioitinh, String cmnd, DateTime ngayvaocq)
        {
            this.manv = manv;
            this.hoten = hoten;
            this.namsinh = namsinh;
            this.gioitinh = gioitinh;
            this.cmnd = cmnd;
            this.ngayvaocq = ngayvaocq;
        }
        //private string DemMANV()
        //{
        //    return "NV" + demnv++;
        //}

        public virtual void Nhap()
        {
            Console.WriteLine("\nDIEN THONG TIN NHAN VIEN C#");
            Console.Write("Nhap ma nhan vien : ");
            this.manv = Convert.ToString(Console.ReadLine());
            Console.Write("______________________\nNhap ho va ten :  ");
            this.hoten = Convert.ToString(Console.ReadLine());
            Console.Write("______________________\nNhap ngay sinh (mm/dd/yyyy)");
            this.namsinh = DateTime.Parse(Console.ReadLine());
            Console.Write("______________________\nNhap gioi tinh(Nam/Nu - M/W) :  ");
            this.gioitinh = Convert.ToString(Console.ReadLine());
            Console.Write("______________________\nNhap CMND :  ");
            this.cmnd = Convert.ToString(Console.ReadLine());
            Console.Write("______________________\nNhap ngay vao cong ty :  ");
            this.ngayvaocq = DateTime.Parse(Console.ReadLine());
        }

        public virtual void Xuat()
        {
            Console.WriteLine("*******************   THONG TIN   *********************");
            Console.WriteLine("**  MA NHAN VIEN : " + this.manv);
            Console.WriteLine("**  TEN NHAN VIEN : " + this.hoten);
            Console.WriteLine("**  NGAY SINH : " + this.namsinh.ToString("dd/MM/yyyy"));
            Console.WriteLine("**  CMND : " + this.cmnd);
            Console.WriteLine("**  NGAY VAO CO QUAN : " + this.ngayvaocq.ToString("dd/MM/yyyy"));
            Console.WriteLine("**  SO NAM LAM VIEC : " + this.thamNiem() + " Nam");
            Console.WriteLine("**  LUONG CO BAN : " + luongcoban + " Dong");

        }

        public int thamNiem()
        {
            return DateTime.Today.Year - this.ngayvaocq.Year;
        }


    }
}
