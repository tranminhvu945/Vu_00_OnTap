using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap02
{
    public class TranhAnh : SanPham
    {
        #region Properties
        public int ChieuRong { get; set; }
        public int ChieuCao { get; set; }
        public string TenHoaSi { get; set; }
        #endregion
        #region Constructor
        public TranhAnh() : base()
        {
            ChieuRong = 0;
            ChieuCao = 0;
            TenHoaSi = "tenhoasi";
        }
 
        #endregion
        #region Methods
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhập chiều rộng: ");
            ChieuRong = int.Parse(Console.ReadLine());
            Console.Write("Nhập chiều cao: ");
            ChieuCao = int.Parse(Console.ReadLine());
            Console.Write("Nhập tên họa sĩ: ");
            TenHoaSi = Console.ReadLine();
        }
        public override string ToString()
        {
            return $"Mã SP: {MaSP}, Tên SP: {TieuDe}, Giá: {GiaBan}, Chiều rộng: {ChieuRong}, Chiều cao: {ChieuCao}, Tên họa sĩ: {TenHoaSi}";
        }
        #endregion
    }
}
