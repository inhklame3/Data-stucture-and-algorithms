using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThuChiGiadinh
{
    internal class Thuchi
    {
        int sothutu;
        int ngay;
        int mathuchi;
        int tien;
        string lydo;
        public int Sothutu {  get => sothutu;set=> sothutu = value; }
        public int Ngay { get => ngay; set => ngay = value; }
        public int Mathuchi { get => mathuchi; set => mathuchi = value; }
        public int Tien { get => tien; set => tien = value; }
        public string Lydo { get => lydo;set =>lydo = value; }
        public Thuchi() { }
        public Thuchi(int stt, int ng, int mathuchi, int tien, string lydo)
        {
            sothutu = stt;
            ngay = ng;
            this.mathuchi = mathuchi;
            this.tien = tien;   
            this.lydo = lydo;
        }
        public Thuchi(Thuchi tc)
        {
            sothutu = tc.sothutu;
            ngay = tc.ngay;
            mathuchi = tc.mathuchi;
            tien = tc.tien;
            lydo = tc.lydo;
        }
        //method
        public void InputTC()
        {
            Console.WriteLine("Nhap So thu tu : ");
             sothutu=int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap Ngay : ");
             ngay=int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap Ma thu chi : ");
             mathuchi = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap tien : ");
             tien = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap ly do thu chi : ");
            lydo = Console.ReadLine();
        }
        public void OutputTC()
        {
            Console.WriteLine(sothutu+ngay+mathuchi+tien+lydo);
        }

    }
}
