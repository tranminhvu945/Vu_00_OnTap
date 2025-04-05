using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap01
{
    class CPhanSo
    {
        #region Properties
        public int TuSo { get; set; }
        public int MauSo { get; set; }
        #endregion
        #region Constructors
        public CPhanSo()
        {
            TuSo = 0;
            MauSo = 1;
        }
        public CPhanSo(int tuSo, int mauSo)
        {
            TuSo = tuSo;
            MauSo = mauSo;
        }
        public CPhanSo(CPhanSo ps)
        {
            TuSo = ps.TuSo;
            MauSo = ps.MauSo;
        }
        #endregion
        #region Methods
        public void Nhap()
        {
            Console.Write("Nhap tu so: ");
            TuSo = int.Parse(Console.ReadLine());
            Console.Write("Nhap mau so: ");
            MauSo = int.Parse(Console.ReadLine());
        }
        public void Xuat()
        {
            Console.WriteLine("Phan so: {0}/{1}", TuSo, MauSo);
        }
        public override string ToString()
        {
            return $"{TuSo}/{MauSo}";
        }
        public void RutGon()
        {
            int gcd = UCLN(TuSo, MauSo);
            TuSo /= gcd;
            MauSo /= gcd;
        }
        private int UCLN(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
        #endregion
        #region Phép toán
        public CPhanSo Cong(CPhanSo ps)
        {
            CPhanSo result = new CPhanSo();
            result.TuSo = TuSo * ps.MauSo + MauSo * ps.TuSo;
            result.MauSo = MauSo * ps.MauSo;
            result.RutGon();
            return result;
        }
        public CPhanSo Tru(CPhanSo ps)
        {
            CPhanSo result = new CPhanSo();
            result.TuSo = TuSo * ps.MauSo - MauSo * ps.TuSo;
            result.MauSo = MauSo * ps.MauSo;
            result.RutGon();
            return result;
        }
        public CPhanSo Nhan(CPhanSo ps)
        {
            CPhanSo result = new CPhanSo();
            result.TuSo = TuSo * ps.TuSo;
            result.MauSo = MauSo * ps.MauSo;
            result.RutGon();
            return result;
        }
        public CPhanSo Chia(CPhanSo ps)
        {
            CPhanSo result = new CPhanSo();
            result.TuSo = TuSo * ps.MauSo;
            result.MauSo = MauSo * ps.TuSo;
            result.RutGon();
            return result;
        }
        public static CPhanSo operator +(CPhanSo ps1, CPhanSo ps2)
        {
            return ps1.Cong(ps2);
        }
        public static CPhanSo operator -(CPhanSo ps1, CPhanSo ps2)
        {
            return ps1.Tru(ps2);
        }
        public static CPhanSo operator *(CPhanSo ps1, CPhanSo ps2)
        {
            return ps1.Nhan(ps2);
        }
        public static CPhanSo operator /(CPhanSo ps1, CPhanSo ps2)
        {
            return ps1.Chia(ps2);
        }
        #endregion
        #region So sanh
        public static bool operator ==(CPhanSo ps1, CPhanSo ps2)
        {
            return (ps1.TuSo * ps2.MauSo == ps2.TuSo * ps1.MauSo);
        }
        public static bool operator !=(CPhanSo ps1, CPhanSo ps2)
        {
            return !(ps1 == ps2);
        }
        public static bool operator >(CPhanSo ps1, CPhanSo ps2)
        {
            return ((float)ps1.TuSo / ps1.MauSo > (float)ps2.TuSo / ps2.MauSo);
        }
        public static bool operator <(CPhanSo ps1, CPhanSo ps2)
        {
            return ((float)ps1.TuSo / ps1.MauSo < (float)ps2.TuSo / ps2.MauSo);
        }
        public static bool operator >=(CPhanSo ps1, CPhanSo ps2)
        {
            return (ps1 > ps2 || ps1 == ps2);
        }
        public static bool operator <=(CPhanSo ps1, CPhanSo ps2)
        {
            return (ps1 < ps2 || ps1 == ps2);
        }
        #endregion
        #region Sort
        public void SortTang(CPhanSo[] arr)
        {
            Array.Sort(arr, (x, y) => x > y ? 1 : (x < y ? -1 : 0));
        }
        public void SortGiam(CPhanSo[] arr)
        {
            Array.Sort(arr, (x, y) => x < y ? 1 : (x > y ? -1 : 0));
        }
        #endregion

    }
}
