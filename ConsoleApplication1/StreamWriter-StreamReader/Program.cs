using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StreamWriter_StreamReader
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\NTT2000\blabla3.txt";
            StreamWriter sw = File.CreateText(path);
            sw.Write("this is random name");
            sw.WriteLine("and this is random name of ntt");
            sw.WriteLine("another ntt");
            sw.Close();

            StreamReader sr = File.OpenText(path);
            Console.WriteLine("Peek: {0}",Convert.ToChar(sr.Peek()));
            Console.WriteLine("read 1 line:  {0}", sr.ReadLine());
            Console.WriteLine("read all line:  {0}", sr.ReadToEnd());
            sr.Close();
            Console.ReadLine();

        }
    }
}
