using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitapcsharpqlnv
{
    abstract class NHANVIEN
    {

        protected String manv;
        protected String hoten;
        protected DateTime namsinh;
        protected String gioitinh;
        protected String cmnd;
        protected DateTime ngayvaocq;
        bool nhapThanhCong = false;
        public const double luongcoban = 1490000;
        abstract public double Luong();
        abstract public double phuCap();

        
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
        public NHANVIEN()
        {
            //this.manv = DemMANV();

        }
        public int thamNiem()
        {
            return DateTime.Today.Year - this.ngayvaocq.Year;
        }
        string inputNgay;
        public virtual void Nhap()
        {
            Console.WriteLine("\nDIEN THONG TIN NHAN VIEN C#");
            Console.Write("Nhap ma nhan vien : ");
            this.manv = Convert.ToString(Console.ReadLine());
            Console.Write("______________________\nNhap ho va ten :  ");
            this.hoten = Convert.ToString(Console.ReadLine());
            do
            {
                Console.Write("______________________\nNhap ngay sinh (dd/MM/yyyy)");
                inputNgay = Console.ReadLine();
                nhapThanhCong = DateTime.TryParseExact(inputNgay, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out this.namsinh);
                if (!nhapThanhCong)
                {
                    Console.WriteLine("Ngày tháng năm sinh không hợp lệ. Vui lòng nhập lại.");
                }
                else if (this.namsinh > DateTime.Now)
                {
                    Console.WriteLine("Ngày tháng năm sinh không thể lớn hơn ngày hiện tại. Vui lòng nhập lại.");
                    nhapThanhCong = false;
                }
            } while (!nhapThanhCong);
            do {
                Console.Write("______________________\nNhap gioi tinh(Nam/Nu - M/W) :  ");
                inputNgay = Console.ReadLine();
                if (inputNgay == "nam" || inputNgay == "nu" || inputNgay == "m" || inputNgay == "w"|| inputNgay == "Nam" || inputNgay == "Nu")
                {
                    this.gioitinh = inputNgay;
                    nhapThanhCong = true;
                }
                else
                {
                    Console.WriteLine("Giới tính không hợp lệ. Vui lòng nhập lại.");
                    nhapThanhCong = false ;
                }
            } while (!nhapThanhCong);


            Console.Write("______________________\nNhap CMND :  ");
            this.cmnd = Convert.ToString(Console.ReadLine());
            do
            {
                Console.Write("______________________\nNhap ngay vao cong ty :  ");
                inputNgay = Console.ReadLine();
                nhapThanhCong = DateTime.TryParseExact(inputNgay, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out this.ngayvaocq);
                if (!nhapThanhCong)
                {
                    Console.WriteLine("Ngày tháng năm sinh không hợp lệ. Vui lòng nhập lại.");
                }
                else if (this.ngayvaocq > DateTime.Now)
                {
                    Console.WriteLine("Ngày tháng năm sinh không thể lớn hơn ngày hiện tại. Vui lòng nhập lại.");
                    nhapThanhCong = false;
                }
            } while (!nhapThanhCong);
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

        


    }
}
