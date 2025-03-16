using System.Runtime.Serialization.Formatters;
using System.Security.Cryptography;

namespace Exercise04_08
{
    internal class Program
    {
        unsafe static void Main(string[] args)
        {
            double number;
            byte diff = sizeof(double) / sizeof(byte);
            byte*[] pointers = new byte*[diff];
            pointers[0] = (byte*)&number;
            for (int i = 1; i < 4; i++)
            {
                pointers[i] = pointers[i - 1] + 2;
            }
            for (byte i = 0; i < diff; i++)
            {
                pointers[i / 2][i % 2] = (byte)(i + 1);
            }
            // Проверка
            byte* p = (byte*)&number;
            for (int i = 0; i < diff; i++) Console.WriteLine(p[i]);
            Console.WriteLine(number);
        }
    }
}
