namespace Exercise04_01
{
    internal class Program
    {
        unsafe static void Main(string[] args)
        {
            int a;
            byte* pab = (byte*)&a;
            pab[0] = 2;
            char* pac = (char*)(pab + 1);
            *pac = 'A';
            pab[3] = 1;
            for (int i = 0; i < 4; i++) Console.WriteLine(pab[i]);
            // 1 0 65 1
            // Ошибся, 1 65 0 1, потому что меньшие биты — более ранние биты
            // 2 65 0 1?
            // 0000 0001  [000 0000  0100 0001]  0000 0002
            // 3          2          1           0
        }
    }
}
