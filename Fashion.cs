using System;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace T1907M.Properties.session2
{
    public class Fashion : Product
    {
        public string color;
        public string size;

        public void Kiemtra()
        {
            Console.WriteLine("Nhap id");
            string a = Convert.ToString(Console.ReadLine());
            foreach (Product x in gallery)
            {
                if (x.id == a)
                {
                    Console.WriteLine("con hang");
                }
                else
                {
                    Console.WriteLine("het hang");
                }
            }
        }
    }
}