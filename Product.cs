using System;
using System.Collections.Generic;

namespace T1907M.Properties.session2
{
    public class Product
    {
        public int id { set; get; }
        public string name{ set; get; }
        public int price{ set; get; }
        public int qty{ set; get; }
        public string image{ set; get; }
        public string desc{ set; get; }
        List<string> gallery = new List<string>();

        public Product(){}

        public Product(int id, string name, int price, int qty, string image, string desc)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.qty = qty;
            this.image = image;
            this.desc = desc;
        }

        public void GetInfo()
        {
           Console.WriteLine(id);
           Console.WriteLine(name);
           Console.WriteLine(price);
           Console.WriteLine(qty);
           Console.WriteLine(desc);
           Console.WriteLine(image);
        }

        public void Check()
        {
            if (qty>0)
            {
                Console.WriteLine("Còn hàng");
            }
            else
            {
                Console.WriteLine("Hết hàng");
            }
        }

        public void AddImage()
        {
            while (true)
            {
                if (gallery.Count > 10)
                {
                    Console.WriteLine("Nhiều hơn 10, vui lòng xóa bớt để tiếp tục thêm");
                }
                else
                {
                    gallery.Add(Console.ReadLine());
                }
            }
        }

        public void Display()
        {
            foreach (string a in gallery)
            {
                Console.WriteLine(a);
            }
        }

        public void Delete()
        {
            Console.WriteLine("nhập thứ tự ảnh muốn xóa : ");
            int x = Convert.ToInt32(Console.ReadLine());
            gallery.RemoveAt(x);
        }

        
    }
    public class maincalss
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();
            int choice;
            do
            {
                Console.WriteLine("0.Out");
                Console.WriteLine("1.Get info");
                Console.WriteLine("2.Check");
                Console.WriteLine("3.Add image");
                Console.WriteLine("4.Delete image");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 0:
                    {
                        break;
                    }
                    case 1:
                    {
                        new Product().GetInfo();
                        break;
                    }
                    case 2:
                    {
                        new Product().Check();
                        break;
                    }
                    case 3:
                    {
                        new Product().AddImage();
                        break;
                    }
                    case 4:
                    {
                        new Product().Display();
                        new Product().Delete();
                        break;
                    }
                    default:
                    {
                        Console.WriteLine("wrong type!try again");
                        break;
                    }
                }
            } while (choice != 0);

        }
    }
}