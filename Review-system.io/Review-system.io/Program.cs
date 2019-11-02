using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Review_system.io
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\temp\MyTest.txt";

            // Tạo thư mục cha.
            Directory.CreateDirectory(@"D:\temp");

            // Tạo một đối tượng Stream thông qua constructor của FileStream.
            // FileMode.Create: Tạo file mới để ghi, nếu file đã tồn tại ghi đè file này.
            Stream writingStream = new FileStream(path, FileMode.Create);

            try
            {
                // Một mảng các byte (1byte < 2^8).
                // Mảng này tương ứng với: {'H','e','l','l','o',' ','W','o','r','l','d'}.
                byte[] bytes = new byte[] { 72, 101, 108, 108, 111, 32, 87, 111, 114, 108, 100 };

                if (writingStream.CanWrite)
                {
                    writingStream.Write(bytes, 0, bytes.Length);

                    // Ghi thêm một byte (33 = '!')
                    writingStream.WriteByte(33);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error:" + e);
            }
            finally
            {
                // Đóng Stream, giải phóng tài nguyên.
                writingStream.Close();
            }
            Console.ReadLine();
        }
    }
}
