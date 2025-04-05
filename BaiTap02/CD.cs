using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap02
{
    public class CD:SanPham
    {
        #region Properties
        public string TenCaSy { get; set; }
        public string TenDVSX { get; set; }
        #endregion
        #region Constructor
        public CD() : base()
        {
            TenCaSy = "tencasy";
            TenDVSX = "tendvsx";
        }
        #endregion
        #region Methods
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhập tên ca sĩ: ");
            TenCaSy = Console.ReadLine();
            Console.Write("Nhập tên đơn vị sản xuất: ");
            TenDVSX = Console.ReadLine();
        }
        public override string ToString()
        {
            return $"Mã SP: {MaSP}, Tên SP: {TieuDe}, Giá: {GiaBan}, Tên ca sĩ: {TenCaSy}, Tên đơn vị sản xuất: {TenDVSX}";
        }
        #endregion
    }
}
