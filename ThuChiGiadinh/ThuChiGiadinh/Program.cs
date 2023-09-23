using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThuChiGiadinh
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thuchi thuchi = new Thuchi();
            thuchi.InputTC();
            thuchi.OutputTC();
            Console.ReadLine();
        }
    }
}
