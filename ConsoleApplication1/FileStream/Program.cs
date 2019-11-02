using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text;

namespace FileStream1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string Path = @"D:\NTT2000\blabla2.txt";
            FileStream fs = File.Open(Path, FileMode.Create);

            string randstring = "hello this is nguyen thanh tan, so good to see you hahfhasdifhsado";
            byte[] rsbytestring = Encoding.Default.GetBytes(randstring);
            fs.Write(rsbytestring, 0, rsbytestring.Length);
            fs.Position = 0;
            byte[] newbyte = new byte[rsbytestring.Length];
            for (int i = 0; i < rsbytestring.Length; i++)
            {
                newbyte[i] = (byte)fs.ReadByte();
            }
            Console.WriteLine(Encoding.Default.GetString(newbyte));
            fs.Close();
            Console.ReadLine();
        }
    }
}
