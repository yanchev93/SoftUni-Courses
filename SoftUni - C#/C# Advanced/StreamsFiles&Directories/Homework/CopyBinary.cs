using System;
using System.IO;

namespace _04._CopyBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "copyMe.png";
            string save = "myFile.png";

            using var pngFile = new FileStream(path, FileMode.Open);
            using var pngCreate = new FileStream(save, FileMode.Create);

            byte[] buffer = new byte[4096];
            
            while (true)
            {
                int counter = pngFile.Read(buffer, 0, buffer.Length);

                if (counter == 0)
                {
                    break;
                }

                pngCreate.Write(buffer);
            }
        }
    }
}
