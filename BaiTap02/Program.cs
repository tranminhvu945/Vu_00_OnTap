using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap02
{
    class Program
    {
        static void TimKHMuaNhieuNhat(List<HoaDon> hoaDons)
        {
            // Tìm khách hàng mua nhiều nhất
            Dictionary<string, Int64> khachHangMuaNhieuNhat = new Dictionary<string, Int64>();
            foreach (var hd in hoaDons)
            {
                hd.TinhTongTien();
                if (khachHangMuaNhieuNhat.ContainsKey(hd.KH.MaKH))
                {
                    khachHangMuaNhieuNhat[hd.KH.MaKH] += hd.TongTien;
                }
                else
                {
                    khachHangMuaNhieuNhat.Add(hd.KH.MaKH, hd.TongTien);
                }
            }
            var khachHangMax = khachHangMuaNhieuNhat.OrderByDescending(x => x.Value).FirstOrDefault();
            Console.WriteLine($"Khách hàng mua nhiều nhất: {khachHangMax.Key}, Tống số tiền: {khachHangMax.Value}");
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Chương trình quản lý hóa đơn bán hàng");
            Console.WriteLine("Nhập thông tin hóa đơn:");
            List<HoaDon> hoaDons = new List<HoaDon>();
            Console.Write("Nhập số lượng hóa đơn: ");
            int soLuongHD = int.Parse(Console.ReadLine());
            for (int i = 0; i < soLuongHD; i++)
            {
                Console.WriteLine($"Nhập thông tin hóa đơn thứ {i + 1}:");
                HoaDon hd = new HoaDon();
                hd.Nhap();
                hd.TinhTongTien();
                hoaDons.Add(hd);
            }
            Console.WriteLine("Danh sách hóa đơn:");
            foreach (var hd in hoaDons)
            {
                Console.WriteLine(hd.ToString());
            }

            TimKHMuaNhieuNhat(hoaDons);
            Console.ReadKey();

        }
    }
}
