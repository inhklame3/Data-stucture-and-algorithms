using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace ThuChiGiadinh
{
    internal class SoThuchi
    {
        Thuchi[] sotc;
        public Thuchi[] Sotc { get => sotc; set => sotc = value; }
        public SoThuchi() { }
        public void FileToList(string filePath)
        {          
            string[] lines;
            if (File.Exists(filePath)) // kiểm tra sự tồn tại của file
            {      // Đọc các dòng trong file  array lines
                lines = File.ReadAllLines(filePath);           
                sotc = new Thuchi[lines.Length];
                for (int i = 0; i < lines.Length; i++)
                {
                    string[] s = lines[i].Split('\t');
                    int stt = Convert.ToInt32(s[0]); int ng = Convert.ToInt32(s[1]);int mathuchi = Convert.ToInt32(s[2]); int tien = Convert.ToInt32(s[3]);
                    string lydo = s[4];                             
                    Thuchi stc = new Thuchi(stt,ng, mathuchi, tien,lydo); 
                    sotc[i] = stc;
                }
            }
            else
            {
                Console.WriteLine("  Không tìm thấy File DSSV.txt");
            }
            Thuchi tc = new Thuchi();
            // Tạo đường dẫn file dùng làm tham số
            filePath = "../../TextFile/ThuChi.txt";
            FileToList(filePath);    // Đọc file -> ds
        }
       
        public void PrintSoThuchi()
        {
            Console.WriteLine("         Sổ Thu Chi: ");
            Console.WriteLine("         Tổng Thu: ");
            for (int i = 0; i < sotc.Length; i++)
                sotc[i].OutputTC();
            Console.WriteLine("         Tổng Chi: ");
            for (int i = 0; i < sotc.Length; i++)
                sotc[i].OutputTC();
            Console.WriteLine("         Số Dư: ");
            for (int i = 0; i < sotc.Length; i++)
                sotc[i].OutputTC();
                
            
        }




    }
}
