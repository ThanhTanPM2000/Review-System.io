using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StreamReadDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            String path = @"D:\temp\MyTest.txt";

            if (!File.Exists(path))
            {
                Console.WriteLine("File " + path + " does not exists!");
                return;
            }

            // Tạo một đối tượng Stream thông qua Constructor của lớp FileStream.
            // FileMode.Open: Mở file để đọc. 
            using (Stream readingStream = new FileStream(path, FileMode.Open))
            {
                byte[] temp = new byte[10];
                UTF8Encoding encoding = new UTF8Encoding(true);

                int len = 0;

                // Đọc các phần tử trên Stream và gán vào các phần tử của mảng 'temp'.
                // (Gán vào các vị trí bắt đầu từ 0, mỗi lần đọc tối đa 'temp.Length' phần tử)
                // Đồng thời trả về số byte vừa đọc được.
                while ((len = readingStream.Read(temp, 0, temp.Length)) > 0)
                {
                    // Chuyển thành chuỗi (String).
                    // ('len' phần tử bắt đầu từ vị trí 0).
                    String s = encoding.GetString(temp, 0, len);
                    Console.WriteLine(s);
                }
            }

            Console.ReadLine();
        }
    }
}
