//using System;
//using System.Collections.Generic;

//class NhanVien
//{
//    protected string hoTen;
//    protected DateTime ngaySinh;
//    protected string gioiTinh;
//    protected DateTime ngayVaoCoQuan;
//    protected string soCMND;

//    public virtual void NhapThongTin()
//    {
//        Console.WriteLine("Nhập thông tin nhân viên:");
//        Console.Write("Họ và tên: ");
//        hoTen = Console.ReadLine();
//        Console.Write("Ngày sinh (dd/mm/yyyy): ");
//        ngaySinh = DateTime.Parse(Console.ReadLine());
//        Console.Write("Giới tính: ");
//        gioiTinh = Console.ReadLine();
//        Console.Write("Ngày vào cơ quan (dd/mm/yyyy): ");
//        ngayVaoCoQuan = DateTime.Parse(Console.ReadLine());
//        Console.Write("Số CMND: ");
//        soCMND = Console.ReadLine();
//    }

//    public virtual void InThongTin()
//    {
//        Console.WriteLine("Thông tin nhân viên:");
//        Console.WriteLine("Họ và tên: " + hoTen);
//        Console.WriteLine("Ngày sinh: " + ngaySinh.ToString("dd/MM/yyyy"));
//        Console.WriteLine("Giới tính: " + gioiTinh);
//        Console.WriteLine("Ngày vào cơ quan: " + ngayVaoCoQuan.ToString("dd/MM/yyyy"));
//        Console.WriteLine("Số CMND: " + soCMND);
//    }

//    public virtual double TinhLuong()
//    {
//        return 0;
//    }
//}

//class NhanVienBienChe : NhanVien
//{
//    private const double LUONG_CO_BAN = 1490000;
//    private double heSoLuong;


//    public override void NhapThongTin()
//    {
//        base.NhapThongTin();
//        Console.Write("Hệ số lương: ");
//        heSoLuong = double.Parse(Console.ReadLine());
//    }

//    public override void InThongTin()
//    {
//        base.InThongTin();
//        Console.WriteLine("Lương cơ bản: " + LUONG_CO_BAN);
//        Console.WriteLine("Hệ số lương: " + heSoLuong);
//        Console.WriteLine("Phụ cấp: " + phuCap());
//    }
//    public double phuCap()
//    {
//        return (thamNien() >= 10) ? 500000 : 200000;
//    }
//    public double thamNien()
//    {
//        return (DateTime.Now - ngayVaoCoQuan).TotalDays / 365;
//    }

//    public override double TinhLuong()
//    {

//        return heSoLuong * LUONG_CO_BAN + phuCap();
//    }
//}

//class NhanVienHopDong : NhanVien
//{
//    private const double LUONG_CO_BAN = 1490000;
//    private double mucLuong;


//    public override void NhapThongTin()
//    {
//        base.NhapThongTin();
//        Console.Write("Mức lương: ");
//        mucLuong = double.Parse(Console.ReadLine());
//    }

//    public override void InThongTin()
//    {
//        base.InThongTin();
//        Console.WriteLine("Lương cơ bản: " + LUONG_CO_BAN);
//        Console.WriteLine("Mức lương: " + mucLuong);
//        Console.WriteLine("Phụ cấp: " + phuCap());
//    }
//    public double phuCap()
//    {
//        return (thamNien() >= 2) ? 200000 : 100000;
//    }
//    public double thamNien()
//    {
//        return (DateTime.Now - ngayVaoCoQuan).TotalDays / 365;
//    }
//    public override double TinhLuong()
//    {

//        return LUONG_CO_BAN + mucLuong + phuCap();
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        List<NhanVien> danhSachNhanVien = new List<NhanVien>();

//        while (true)
//        {
//            Console.WriteLine("Chọn loại nhân viên (1: Biên chế, 2: Hợp đồng, 0: Kết thúc): ");
//            int choice = int.Parse(Console.ReadLine());
//            if (choice == 0)
//                break;

//            NhanVien nv;
//            if (choice == 1)
//                nv = new NhanVienBienChe();
//            else
//                nv = new NhanVienHopDong();

//            nv.NhapThongTin();
//            danhSachNhanVien.Add(nv);
//        }

//        double tongLuong = 0;
//        danhSachNhanVien.Sort((x, y) => y.TinhLuong().CompareTo(x.TinhLuong()));

//        Console.WriteLine("Danh sách nhân viên theo lương giảm dần:");
//        foreach (var nv in danhSachNhanVien)
//        {
//            nv.InThongTin();
//            Console.WriteLine("Lương: " + nv.TinhLuong());
//            tongLuong += nv.TinhLuong();
//        }

//        Console.WriteLine("Tổng quỹ lương phải trả: " + tongLuong);
//    }
//}
