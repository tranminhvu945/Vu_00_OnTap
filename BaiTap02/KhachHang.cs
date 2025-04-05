using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap02
{
    public class KhachHang
    {
        #region Properties
        public string MaKH { get; set; }
        public string HoTen { get; set; }
        public string SDT { get; set; }
        #endregion
        #region Constructor
        public KhachHang(string maKH, string hoTen, string sdt)
        {
            MaKH = maKH;
            HoTen = hoTen;
            SDT = sdt;
        }

        public KhachHang()
        {
        }
        #endregion
        #region Methods
        public void Nhap()
        {
            Console.Write("Nhập mã khách hàng: ");
            MaKH = Console.ReadLine();
            Console.Write("Nhập họ tên: ");
            HoTen = Console.ReadLine();
            Console.Write("Nhập số điện thoại: ");
            SDT = Console.ReadLine();
        }
        public override string ToString()
        {
            return $"Mã KH: {MaKH}, Họ tên: {HoTen}, SĐT: {SDT}";
        }

        #endregion


    }
}
