using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace BaiTap03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            
            while (true)
            {
                DateTime currentTime = DateTime.Now;
                Console.WriteLine($"Thời gian hiện tại là: {currentTime:dddd, dd/MM/yyyy, HH:mm:ss}");
                Thread.Sleep(1000);
            }
        }
    }
}
