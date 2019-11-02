using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            DirectoryInfo currdir = new DirectoryInfo(".");

            DirectoryInfo Ddir = new DirectoryInfo(@"D:\Nguyến Thành Tân Đang Testing\Testing");
            Console.WriteLine(Ddir.FullName);
            Console.WriteLine(Ddir.Name);
            Console.WriteLine(Ddir.Parent);
            Console.WriteLine(Ddir.Attributes);
            Console.WriteLine(Ddir.CreationTime);

            string[] custormer = { "nguyễn", "thành", "tân" };
            string path = @"D:\cake\cake birday.txt";

            File.WriteAllLines(path, custormer);

            foreach (string cust in File.ReadAllLines(path))
            {
                Console.WriteLine("customer : {0}",cust);
            }

            DirectoryInfo dir = new DirectoryInfo(@"D:\cake\cake birday\");
            FileInfo[] fileinf = dir.GetFiles("*.txt", SearchOption.AllDirectories);
            Console.WriteLine("Maths : {0}", fileinf.Length);

            foreach (FileInfo file in fileinf)
            {
                Console.WriteLine(file.Name);
                Console.WriteLine(file.Length);
            }

            Console.ReadLine(); 

        }
    }
}
