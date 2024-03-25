using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitapcsharpqlnv
{
    class Program
    {
        static DANHSACHNHANVIEN dsnhanvien;

        static void MeNu()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("\n\t\t\t\t\t  CHƯƠNG TRÌNH QUẢN LÝ NHÂN VIÊN  C#");
            Console.WriteLine("\t\t\t\t*************************MENU**************************");
            Console.WriteLine("\t\t\t\t**  1. Nhập nhân viên                                **");
            Console.WriteLine("\t\t\t\t**  2. In ra nhân viên                               **");
            Console.WriteLine("\t\t\t\t**  3. Tìm nhân viên theo Mã nhân viên               **");
            Console.WriteLine("\t\t\t\t**  4. Xóa nhân viên                                 **");
            Console.WriteLine("\t\t\t\t**  5. thống kê                                      **");
            Console.WriteLine("\t\t\t\t**  6. Tổng quỹ lương                                **");
            Console.WriteLine("\t\t\t\t**  0. Thoát                                         **");
            Console.WriteLine("\t\t\t\t*******************************************************");

            int Menuitem = 0;
            Menuitem = int.Parse(Console.ReadLine());

            switch (Menuitem)
            {
                case 1:
                    dsnhanvien.Nhap(); Console.Clear(); MeNu();
                    break;
                case 2:
                    dsnhanvien.Xuat(); Console.ReadKey(); Console.Clear(); MeNu();
                    break;
                case 3:
                    dsnhanvien.Tim(); Console.ReadKey(); Console.Clear(); MeNu();
                    break;
                case 4:
                    dsnhanvien.Xoa(); Console.ReadKey(); Console.Clear(); MeNu();
                    break;
                case 5:
                    dsnhanvien.thongke(); Console.ReadKey(); Console.Clear(); MeNu();
                    break;
                case 6:
                    dsnhanvien.tinhTongQuyLuong(); Console.ReadKey(); Console.Clear(); MeNu();
                    break;
                case 0: Console.ReadKey(); Console.Clear(); return;
                default: Console.WriteLine("Nhập sai ! vui lòng nhập lại ..."); break;

            }
        }
        static void Main(string[] args)
        {
            //List<NHANVIEN> dsnv = new List<NHANVIEN>();
            //while (true)
            //{
            //    Console.WriteLine("1 nv bien che\n2 nv hop dong\n0thoat");
            //    int choice = int.Parse(Console.ReadLine());
            //    if (choice == 0)
            //        break;
            //    NHANVIEN nv;
            //    if (choice == 1)
            //    {
            //        nv = new nhanvienbienche();
            //    }
            //    else
            //    {
            //        nv = new nhanvienhopdong();
            //    }
            //    nv.Nhap();
            //    dsnv.Add(nv);

            //NHANVIEN nv = new NHANVIEN();
            //Console.OutputEncoding = Encoding.UTF8;
            //Console.WriteLine("ĐIỀN THÔNG TIN NHÂN VIÊN");
            //while (true)
            //{
                
            //    Console.WriteLine("1 nhân viên biên chế\n2 nhân viên hợp đồng\n0 thoát và in");
            //    int choice = int.Parse(Console.ReadLine());
            //    if (choice == 0)
            //    {
            //        Console.Clear();
            //        nv.Xuat();
            //    }
            //    if (choice == 1)
            //    {
            //        nv = new nhanvienbienche();

            //    }

            //    if (choice == 2)
            //    {
            //        nv = new nhanvienhopdong();
            //    }
            //    nv.Nhap();

            //}



           
            char c = 'y';
            while (c == 'y' || c == 'Y')
            {
                MeNu();
                Console.OutputEncoding = Encoding.UTF8;
                Console.Write("Nhập 'Y' để tiếp tục , hoặc phím bất kì để thoát !");
                c = Char.Parse(Console.ReadLine());
            }

            Console.ReadKey();
            
        }
    }
}
