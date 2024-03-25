using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitapcsharpqlnv
{
    class DANHSACHNHANVIEN
    {
        Dictionary<String, NHANVIEN> listStaff;
        public DANHSACHNHANVIEN()
        {
            this.listStaff = new Dictionary<string, NHANVIEN>();

        }

        public void Nhap()
        {
            char c = 'y';
            while (c == 'y')
            {
                NHANVIEN nv = null;
                char loai = ' ';
                Console.WriteLine("Nhap ky tu (B) bien che (H) hop dong");
                loai = Convert.ToChar(Console.ReadLine().ToUpper());
                switch (loai)
                {
                    case 'B':
                        {
                            nv = new nhanvienbienche();
                            nv.Nhap();
                            break;
                        }
                    case 'H':
                        {
                            nv = new nhanvienhopdong();
                            nv.Nhap();
                            break;
                        }
                }//end switch
                if (nv != null)
                    this.listStaff.Add(nv.Manv, nv);
                Console.WriteLine("Nhap ky tu 'y' de tiep tuc");
                c = Convert.ToChar(Console.ReadLine());
            }// end while
        }//end Nhap()

        public void Xuat()
        {
            Console.WriteLine("Mã nhân viên |      Họ Tên    |  Ngày sinh  |    Giới tính |   Số Chứng minh |  Phụ Cấp |  thực lĩnh|");

            foreach (NHANVIEN nv in listStaff.Values)
                Console.WriteLine("{0,2} {1,2} {2,2} {3,2} {4,2}", nv.Manv, nv.Hoten, nv.Namsinh.ToString("dd/MM/yyyy"),nv.Gioitinh,nv.Cmnd);
        }//end Xuat()
        public NHANVIEN Tim()
        {
            Console.WriteLine("Nhap ma nv can tim:");
            String manv = Console.ReadLine();
            return this.listStaff[manv];
        }// end tim()
        public void Xoa()
        {
            Console.WriteLine("Nhap ma nv can xoa:");
            String manv = Console.ReadLine();
            this.listStaff.Remove(manv);
        }// end Xoa()
        public void thongke()
        {
            int tongbienche = 0; int tonghopdong = 0;
            foreach (NHANVIEN nv in this.listStaff.Values)
            {
                if (nv is nhanvienbienche)
                    tongbienche++;
                else if (nv is nhanvienhopdong)
                    tonghopdong++;
            }
            Console.WriteLine("Tong so nhan vien bien che hien co:" + tongbienche);
            Console.WriteLine("Tong so nhan vien hop dong hien co:" + tonghopdong);
        }// end thongke()
        public void tinhTongQuyLuong()
        {
            double tongluong = 0;
            foreach (NHANVIEN nv in this.listStaff.Values)
            {

                // tongluong +=nv.tinhThucLinh();

            }
            Console.WriteLine("tong quy luong:" + tongluong);
        }//end tinhTongQuyLuong()

        public void MeNu()
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
                    Nhap(); Console.Clear(); MeNu();
                    break;
                case 2:
                    Xuat(); Console.ReadKey(); Console.Clear(); MeNu();
                    break;
                case 3:
                    Tim(); Console.ReadKey(); Console.Clear(); MeNu();
                    break;
                case 4:
                    Xoa(); Console.ReadKey(); Console.Clear(); MeNu();
                    break;
                case 5:
                    thongke(); Console.ReadKey(); Console.Clear(); MeNu();
                    break;
                case 6:
                    tinhTongQuyLuong() ; Console.ReadKey(); Console.Clear(); MeNu();
                    break;
                case 0: Console.ReadKey(); Console.Clear();return;
                default: Console.WriteLine("Nhập sai ! vui lòng nhập lại ..."); break;

            }
        }
    }//end class DANHSACHNHANVIEN
}
