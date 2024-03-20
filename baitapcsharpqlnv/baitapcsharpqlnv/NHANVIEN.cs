using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitapcsharpqlnv
{
    class NHANVIEN
    {
        private static int demnv = 1;// ma nv ban dau = nv{demnv}
        private String manv { set;  get ; }
        private String hoten { set; get; }
        private DateTime namsinh { set; get; }
        private String gioitinh { set; get; }
        private String cmnd { set; get; }
        private DateTime ngayvaocq { set; get; }
        public const double luongcoban = 1490000;

        public NHANVIEN()
        {
            this.manv = DemMANV();

        }

        public NHANVIEN(String hoten, DateTime namsinh, String gioitinh, String cmnd, DateTime ngayvaocq)
        {
            this.manv = DemMANV();
            this.hoten = hoten;
            this.namsinh = namsinh;
            this.gioitinh = gioitinh;
            this.cmnd = cmnd;
            this.ngayvaocq = ngayvaocq;
        }
        private string DemMANV()
        {
            return "NV" + demnv++;
        }

        public void Nhap()
        {
            Console.WriteLine("\nDIEN THONG TIN NHAN VIEN C#");
            Console.Write("MANV(auto) : " + this.manv);
            Console.Write("______________________\nNhap ho va ten :  ");
            this.hoten = Convert.ToString(Console.ReadLine());
            Console.Write("______________________\nNhap ngay sinh (mm/dd/yyyy");
            this.namsinh = DateTime.Parse(Console.ReadLine());
            Console.Write("______________________\nNhap gioi tinh(Nam/Nu - M/W) :  ");
            this.gioitinh = Convert.ToString(Console.ReadLine());
            Console.Write("______________________\nNhap CMND :  ");
            this.cmnd = Convert.ToString(Console.ReadLine());
            Console.Write("______________________\nNhap ngay vao cong ty :  ");
            this.ngayvaocq = DateTime.Parse(Console.ReadLine());
        }

        public void Xuat()
        {
            Console.Write("*******************   THONG TIN   *********************");
            Console.Write("**  MA NHAN VIEN : " + this.manv);
            Console.Write("**  TEN NHAN VIEN : " + this.hoten);
            Console.Write("**  NGAY SINH : " + this.namsinh.ToString("dd/MM/yyyy"));
            Console.Write("**  CMND : " + this.cmnd);
            Console.Write("**  NGAY VAO CO QUAN : " + this.ngayvaocq.ToString("dd/MM/yyyy"));
            Console.Write("**  LUONG CO BAN : " + luongcoban);
            Console.Write("**  TONG LUONG");
            Console.Write("*******************************************************");
        }

        public int thamNiem()
        {
            return DateTime.Today.Year - this.ngayvaocq.Year;
        }


    }
}
