using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap02
{
    public class SanPham
    {
        #region Properties
        public string MaSP { get; set; }
        public string TieuDe { get; set; }
        public Int64 GiaBan { get; set; }
        #endregion
        #region Constructor
        public SanPham()
        {
            MaSP = "000";
            TieuDe = "tenSP";
            GiaBan = 0;
        }
        #endregion
        #region Methods
        public virtual void Nhap()
        {
            Console.Write("Nhập mã sản phẩm: ");
            MaSP = Console.ReadLine();
            Console.Write("Nhập tên sản phẩm: ");
            TieuDe = Console.ReadLine();
            Console.Write("Nhập giá bán: ");
            GiaBan = Int64.Parse(Console.ReadLine());
        }
        public override string ToString()
        {
            return $"Mã SP: {MaSP}, Tên SP: {TieuDe}, Giá: {GiaBan}";
        }
        #endregion

    }
}
