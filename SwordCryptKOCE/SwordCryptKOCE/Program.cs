using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SwordCrypt;
using System.IO;

namespace SwordCryptKOCE
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public static void PackDirectory(string directoryName, string password,  string fileName)
        {

        }

        public static byte[] GetFileContents(string fileName)
        {
            BinaryReader reader = new BinaryReader(new FileStream(fileName, FileMode.Open));
            byte[] buffer = new byte[1024];
            using (MemoryStream ms = new MemoryStream())
            {
                while (true)
                {
                    int read = reader.Read(buffer, 0, buffer.Length);
                    if (read <= 0)
                    {
                        return ms.ToArray();
                    }
                    ms.Write(buffer, 0, read);
                }
            }
        }

        public byte[] GetEncodedFile(int key, string fileName)
        {
            //taken from swordcrypt
            Encoding EUC = Encoding.GetEncoding(949);
            Encoding UTF = UTF8Encoding.UTF8;
            byte[] bytes = GetFileContents(fileName);
            bytes = Encoding.Convert(UTF, EUC, bytes);
            // encode using phantom's crypto table
            List<byte> output = new List<byte>();
            foreach (byte b in bytes)
            {
                output.Add(
                    Convert.ToByte(SwordCrypt.Crypto.encode(key, b))
                );
            }

            return output.ToArray();
        }
    }
}
