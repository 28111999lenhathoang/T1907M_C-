using System;
using System.Collections.Generic;

namespace T1907M.Assignment4._1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<KhachHangVietNam> list1 = new List<KhachHangVietNam>();
            list1.Add(new KhachHangVietNam(1,"hoang","27/4/2020",60,"sinh hoat"));
            list1.Add(new KhachHangVietNam(2, "trang", "27/1/2020", 150, "sinh hoat"));
            List<KhachHangNuocNgoai> list3 = new List<KhachHangNuocNgoai>();
            list3.Add(new KhachHangNuocNgoai(3,"alex","28/11/1999",100,"anh quoc"));
            foreach (KhachHangVietNam n in list1)
            {
                n.ShowBill();
            }

            int x = 0;
            Console.Write("tong tien khach hang viet nam :");
            foreach (KhachHangVietNam a in list1)
            {
                x += a.Thanhtien();
            }
            Console.WriteLine("tong tien khach hang nuoc ngoai");
            foreach (KhachHangNuocNgoai n in list3)
            {
                x += n.Thanhtien();
            }
            
        }
    }
}