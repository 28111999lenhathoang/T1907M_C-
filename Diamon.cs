using System;

namespace T1907M.Properties.session2
{
    public class Diamon
    {
        public int cara;
        public int trongluong;

        public void KiemTra_real_fake()
        {
            if (cara < 1)
            {
                Console.WriteLine("hang gia");
            }
            else
            {
                Console.WriteLine("hang that");
            }
        }
    }
}