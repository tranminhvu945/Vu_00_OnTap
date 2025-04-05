using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap02
{
    public class HoaDon
    {
        #region Properties
        public string MaHD { get; set; }
        public KhachHang KH { get; set; }
        public DateTime NgayLap { get; set; }
        public List<SanPham> SanPhams { get; set; }
        public Int64 TongTien { get; set; }
        #endregion
        #region Constructor
        public HoaDon()
        {
            MaHD = "HD00";
            KH = new KhachHang();
            NgayLap = DateTime.Now;
            SanPhams = new List<SanPham>();
            TongTien = 0;
        }
        #endregion
        #region Methods
        public void Nhap()
        {
            Console.Write("Nhập mã hóa đơn: ");
            MaHD = Console.ReadLine();
            Console.Write("Nhập khách hàng: ");
            KH.Nhap();
            Console.Write("Nhập ngày lập: ");
            NgayLap = DateTime.Parse(Console.ReadLine());
            SanPhams = new List<SanPham>();
            Console.Write("Nhập số lượng sản phẩm: ");
            int soLuong = int.Parse(Console.ReadLine());
            for (int i = 0; i < soLuong; i++)
            {
                Console.WriteLine($"Nhập thông tin sản phẩm thứ {i + 1}:");
                SanPham sp = null;
                Console.WriteLine("Chọn loại sản phẩm (1: Tranh, 2: CD âm nhạc): ");
                int loaiSP = int.Parse(Console.ReadLine());
                switch (loaiSP)
                {
                    case 1:
                        sp = new TranhAnh();
                        break;
                    case 2:
                        sp = new CD();
                        break;
                    default:
                        Console.WriteLine("Loại sản phẩm không hợp lệ.");
                        break;
                }
                sp.Nhap();
                SanPhams.Add(sp);
            }
        }
        public override string ToString()
        {
            string result = $"Mã HD: {MaHD}\nKhách hàng: {KH.ToString()}\nNgày lập: {NgayLap}\nSản phẩm:\n";
            foreach (var sp in SanPhams)
            {
                result += sp.ToString() + "\n";
            }
            result += $"Tổng tiền: {TongTien}";
            return result;
        }
        public void TinhTongTien()
        {
            TongTien = 0;
            foreach (var sp in SanPhams)
            {
                TongTien += sp.GiaBan;
            }
        }

        #endregion


    }
}
