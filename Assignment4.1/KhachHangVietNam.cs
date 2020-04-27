namespace T1907M.Assignment4._1
{
    public class KhachHangVietNam : KhachHang
    {
        private string doituong;

        public KhachHangVietNam(int id, string name, string ngay, int soluong, string doituong) : base(id, name, ngay, soluong)
        {
            this.doituong = doituong;
        }

        public string Doituong
        {
            get { return doituong; }
            set { doituong = value; }
        }
    }
}