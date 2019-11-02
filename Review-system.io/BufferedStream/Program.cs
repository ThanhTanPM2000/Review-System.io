using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CSharpStreamsTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            String fileName = @"D:\temp\MyFile.txt";

            FileInfo file = new FileInfo(fileName);

            // Đảm bảo thư mục tồn tại.
            file.Directory.Create();

            // Tạo file mới, nếu nó đã tồn tại nó sẽ bị ghi đè.
            // Trả về một đối tượng FileStream.
            using (FileStream fileStream = file.Create())
            {
                // Tạo một đối tượng BufferedStream bao lấy FileStream.
                // (Chỉ định bộ đệm (buffer) có sức chứa 10000 bytes).
                using (BufferedStream bs = new BufferedStream(fileStream, 10000))
                {
                    int index = 0;
                    for (index = 1; index < 2000; index++)
                    {
                        String s = "This is line " + index + "\n";

                        byte[] bytes = Encoding.UTF8.GetBytes(s);

                        // Ghi vào bộ đệm (buffer), 
                        // khi bộ đệm đầy nó sẽ tự động đẩy dữ liệu xuống file.
                        bs.Write(bytes, 0, bytes.Length);
                    }

                    // Đẩy các dữ liệu còn lại trên bộ đệm xuống file.
                    bs.Flush();
                }

            }

            Console.WriteLine("Finished!");
            Console.Read();
        }
    }
}
