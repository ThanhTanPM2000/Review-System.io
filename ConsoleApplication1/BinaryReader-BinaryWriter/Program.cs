using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BinaryReader_BinaryWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string path = @"D:\NTT2000\blabla4.txt";
            FileInfo fi = new FileInfo(path);

            BinaryWriter bw = new BinaryWriter(fi.OpenWrite());
            string name = "nguyễn thành tân";
            string name2 = "tân tồ";
            int digit = 200;
            double number = 2.33;
            bw.Write(name);
            bw.Write(name2);
            bw.Write(digit);
            bw.Write(number);
            bw.Close();

            BinaryReader br = new BinaryReader(fi.OpenRead());
            Console.WriteLine(br.ReadString());
            Console.WriteLine(br.ReadString());
            Console.WriteLine(br.ReadInt32());
            Console.WriteLine(br.ReadDouble());
            br.Close();

            Console.ReadLine();
        }
    }
}
