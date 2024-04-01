using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitapcsharpqlnv
{
    class DANHSACHNHANVIEN : IReadWriteData
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
                Console.WriteLine("{0,2} {1,15} {2,18} {3,22} {4,25} {5,27} {6,30}", nv.Manv, nv.Hoten, nv.Namsinh.ToString("dd/MM/yyyy"),nv.Gioitinh,nv.Cmnd,nv.phuCap(),nv.Luong());
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
        public void ReadFile()
        {
            string filename = "nhanvien12.txt";
            
            String[] AllLines = File.ReadAllLines(filename);
            foreach (string line in AllLines)
            {
                String[] info = line.Split(',');
                NHANVIEN nv = null;
                if (info[0] == "B")
                {
                    nv = new nhanvienbienche();
                    ((nhanvienbienche)nv).Hesoluong = double.Parse(info[7]);
                }
                else
                {
                    nv = new nhanvienhopdong();
                    ((nhanvienhopdong)nv).Mucluong = double.Parse(info[7]);
                }
                nv.Manv = info[1];
                nv.Hoten = info[2];
                nv.Gioitinh = info[3];
                nv.Namsinh = DateTime.Parse(info[4]);
                nv.Cmnd = info[5];
                nv.Ngayvaocq = DateTime.Parse(info[6]);
                this.listStaff.Add(nv.Manv, nv);
            }
        }



        public void WriteFile()
        {
            string file = "C:\\Users\\DN_Hocvien\\Desktop\\Hoang_LTG\\baitapcsharp\\baitapcsharpqlnv\\nhanvien.txt";
            StreamWriter sr = new StreamWriter(file);
            string info = null;
            foreach(NHANVIEN nv in this.listStaff.Values)
            {
                double hesoluong_mucluong = 0;
                if (nv is nhanvienbienche)
                {
                    info = "B,";
                    hesoluong_mucluong = ((nhanvienbienche)nv).Hesoluong;
                }
                else if(nv is nhanvienhopdong)
                {
                    info = "H,";
                    hesoluong_mucluong = ((nhanvienhopdong)nv).Mucluong;
                }
                info += nv.Manv + ","
                    + nv.Hoten + ","
                    + nv.Gioitinh + ","
                    + nv.Namsinh.ToString("dd/MM/yyyy") + ","
                    + nv.Cmnd + ","
                    + nv.Ngayvaocq.ToString("dd/MM/yyyy") + ","
                    + hesoluong_mucluong;
                sr.WriteLine(info);
            }
            sr.Close();
        }

    }//end class DANHSACHNHANVIEN
}
