using System;
using System.Collections.Generic;
using T1907M.Properties.session2;

namespace T1907M.Assignment3
{
    public class Cart : Product
    {
        public string id { set; get; }
        public string customer { set; get; }
        public int grandTotal { set; get; }
        public string city { set; get; }
        public string country { set; get; }
        List<Product> productList = new List<Product>();

        public void ThemSanPham()
        {
            productList.Add(new Product());
        }

        public void XoaSanPham()
        {
            productList.RemoveAt(Convert.ToInt32(Console.ReadLine()));
        }

        public void TongTien()
        {
            if (country == "Viet Name")
            {
                if (city == "ha noi" || city == "ho chi minh")
                {
                    grandTotal = Convert.ToInt32(price*1.01);
                }
                else
                {
                    grandTotal = Convert.ToInt32(price * 1.02);
                }
            }
            else
            {
                grandTotal = Convert.ToInt32(price * 1.05);
            }
        }
        
    }
}