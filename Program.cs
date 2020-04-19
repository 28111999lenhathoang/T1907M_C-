using System;
using System.Collections;
using System.Collections.Generic;

namespace T1907M
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int fb1, fb2, fb;
            Console.Write("nhap so n: ");
            //str = Console.ReadLine();
            int n = Convert.ToInt32(Console.ReadLine());
            // de nhap ky tu la so 
            fb = 0;
            fb1 = 1;
            fb2 = 1;
            while(fb1 +  fb2 < n)
            {
                fb = fb1 + fb2;
                fb2 = fb1;
                fb1 = fb;
            }
            Console.Write("So fibonaci lon nhat nho hon n la: ");
            Console.WriteLine(fb1);
                
                
            }
        }
    }
