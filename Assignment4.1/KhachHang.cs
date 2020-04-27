using System;
using T1907M.Properties.session2;

namespace T1907M.Assignment4._1
{
    public class KhachHang
    {
        protected int id;
        protected string name;
        protected string ngay;
        protected int soluong;

        public KhachHang()
        {
        }

        public KhachHang(int id, string name, string ngay, int soluong)
        {
            this.id = id;
            this.name = name;
            this.ngay = ngay;
            this.soluong = soluong;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Ngay
        {
            get { return ngay; }
            set { ngay = value; }
        }

        public int Soluong
        {
            get { return soluong; }
            set { soluong = value; }
        }

        public virtual int Thanhtien()
        {
            if (soluong < 50)
            {
                return soluong * 1000;
            }
            else if (50 < soluong && soluong < 100)
            {
                return 50 * 1000 + (soluong - 50) * 1200;
            }
            else if (100 < soluong && soluong < 200)
            {
                return 50 * 1000 + 50 * 1200 + (soluong - 100) * 1500;
            }
            else
            {
                return soluong * 2000;
            }
        }

        public void ShowBill()
        {
            Console.WriteLine("Id : " +id);
            Console.WriteLine("Name : " +name);
            Console.WriteLine("Total : " +Thanhtien());
        }
        
    }
}