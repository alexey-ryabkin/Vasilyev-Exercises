namespace Exercise04_02
{
    internal class Program
    {
        unsafe static void Main(string[] args)
        {
            double a;
            double* apdouble = &a;
            byte* apbyte;
            char* apchar;
            int* apint;
            apbyte = (byte*)apdouble; // 0
            apchar = (char*)(apbyte + 1); // 1
            apint = (int*)(apchar + 1); // 3

            *apbyte = 1; // 0
            *apchar = 'A'; // 1
            *apint = 2; // 3
            apbyte[7] = 3; // 7

            for (int i = 0; i < sizeof(double); i++)
            {
                Console.WriteLine($"{Convert.ToString(apbyte[i], toBase: 2).PadLeft(8, '0'), 8}");
            }
            /*
             * 00000001
             * 01000001
             * 00000000
             * 00000010
             * 00000000
             * 00000000
             * 00000000
             * 00000011
             * +
             */

        }
    }
}
