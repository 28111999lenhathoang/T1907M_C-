namespace T1907M.Assignment4._1
{
    public class KhachHangNuocNgoai : KhachHang
    {
        private string country;

        public KhachHangNuocNgoai(int id, string name, string ngay, int soluong, string country) : base(id, name, ngay, soluong)
        {
            this.country = country;
        }

        public string Country
        {
            get { return country; }
            set { country = value; }
        }

        public override int Thanhtien()
        {
            return soluong * 2000;
        }
    }
}