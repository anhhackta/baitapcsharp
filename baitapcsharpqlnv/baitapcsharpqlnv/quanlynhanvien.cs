using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitapcsharpqlnv
{
    class quanlynhanvien
    {
        Dictionary<String, NHANVIEN> dsnhanvien;

        public quanlynhanvien()
        {
            dsnhanvien = new Dictionary<String, NHANVIEN>();
        }
        public void Nhap()
        {
            //char c = 'y';
            //while (c == 'y' || c == 'Y')
            //{
            //    NHANVIEN nv = new NHANVIEN();
            //    nv.Nhap();
            //    danhsachnhanvien.Add(nv.MANV, nv);
            //    Console.WriteLine("nhap y de tiep tuc , bat ky de ket thuc ! ");
            //    c = Convert.ToChar(Console.ReadLine());
            //}
        }

    }
}
