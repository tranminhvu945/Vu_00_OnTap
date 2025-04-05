using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Random rand = new Random();
            Console.WriteLine("Nhập phân số A:");
            CPhanSo A = new CPhanSo();
            A.Nhap();
            Console.WriteLine("Nhập phân số B tạo ngẫu nhiên:");
            CPhanSo B = new CPhanSo(rand.Next(10), rand.Next(1,20));
            
            Console.WriteLine("Phân số A: {0}", A);
            Console.WriteLine("Phân số B: {0}", B);
            Console.WriteLine("Phân số A + B: {0}", A + B);
            Console.WriteLine("Phân số A - B: {0}", A - B);
            Console.WriteLine("Phân số A * B: {0}", A * B);
            Console.WriteLine("Phân số A / B: {0}", A / B);
            Console.WriteLine("Phân số A == B: {0}", A == B);
            Console.WriteLine("Phân số A != B: {0}", A != B);

            Console.ReadKey(); 
        }
    }
}
