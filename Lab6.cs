using System;

namespace T1907M.Session6
{
    public delegate int TestDelegate(int a, int b);
    public class Lab6
    {
        public static void Main(string[] args)
        {
            int choice;
            
            do
            {
            Console.WriteLine("danh sach ham");
            Console.WriteLine("0.Thoat chuong trinh");
            Console.WriteLine("1.Cong");
            Console.WriteLine("2.Tru");
            Console.WriteLine("3.Nhan");
            Console.WriteLine("4.Chia");
            Console.Write("Chon ham muon chay : ");
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                {
                    TestDelegate test = Lab6.Test("Cong");
                    Console.WriteLine("Nhap vao 2 so ");
                    Console.Write("a :");
                    int a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("b :");
                    int b = Convert.ToInt32(Console.ReadLine());
                    float x = test(a, b);
                    break;
                }
                case 2:
                {
                    TestDelegate test = Lab6.Test("Tru");
                    Console.WriteLine("Nhap vao 2 so ");
                    Console.Write("a :");
                    int a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("b :");
                    int b = Convert.ToInt32(Console.ReadLine());
                    float x = test(a, b);
                    break; 
                }
                case 3:
                {
                    TestDelegate test = Lab6.Test("Nhan");
                    Console.WriteLine("Nhap vao 2 so ");
                    Console.Write("a :");
                    int a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("b :");
                    int b = Convert.ToInt32(Console.ReadLine());
                    float x = test(a, b);
                    break;
                }
                case 4:
                {
                    TestDelegate test = Lab6.Test("Chia");
                    Console.WriteLine("Nhap vao 2 so ");
                    Console.Write("a :");
                    int a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("b :");
                    int b = Convert.ToInt32(Console.ReadLine());
                    float x = test(a, b);
                    break;
                }
                default:
                {
                    Console.WriteLine("Xin moi nhap lai");
                    break;
                }
            }
            } while (choice != 0);
        }
        public static int Cong(int a, int b)
        {
            Console.WriteLine("a + b = " +(a+b));
            return a + b;
        }

        public static int Tru(int a, int b)
        {
            Console.WriteLine("a - b = " +(a-b));
            return a - b;
        }

        public static int Nhan(int a, int b)
        {
            Console.WriteLine("a * b = " + (a*b)) ;
            return a * b;
        }

        public static int Chia(int a, int b)
        {
            if (b == 0) return 0;
            else
            {
                Console.WriteLine("a / b = " +(a/b));
                return a / b;
            }
        }

        public static TestDelegate Test(string ham)
        {
            if (ham == "Cong")
            {
                return Cong;
            }else if (ham =="Tru")
            {
                return Tru;
            }else if (ham == "Nhan")
            {
                return Nhan;
            }
            else
            {
                return Chia;
            }
        }
        
    }
}