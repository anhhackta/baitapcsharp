﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitapcsharpqlnv
{
    class Program
    {
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

            NHANVIEN nv = new NHANVIEN();
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("ĐIỀN THÔNG TIN NHÂN VIÊN");
            while (true)
            {
                
                Console.WriteLine("1 nhân viên biên chế\n2 nhân viên hợp đồng\n0 thoát và in");
                int choice = int.Parse(Console.ReadLine());
                if (choice == 0)
                {
                    Console.Clear();
                    nv.Xuat();
                }
                if (choice == 1)
                {
                    nv = new nhanvienbienche();

                }

                if (choice == 2)
                {
                    nv = new nhanvienhopdong();
                }
                nv.Nhap();

            }

            Console.ReadKey();
            
        }
    }
}
