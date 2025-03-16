namespace Exercise04_04
{
    internal class Program
    {
        unsafe static void Main(string[] args)
        {
            Random r = new Random();
            int a, test, b;
            a = test = b = r.Next(int.MinValue, int.MaxValue);
            byte* ap = (byte*)&a;
            byte temp;
            temp = ap[3];
            for (int i = 3; i > 0; i--) ap[i] = ap[i - 1];
            ap[0] = temp;

            // Проверка
            test = test << 8 | test >> 24 & 255;

            Console.WriteLine(test == a ? "Программа выполнена успешно" : "Значения не равны!");
            Console.WriteLine($"{Convert.ToString(b, toBase: 2).PadLeft(32, '0'),32}");
            Console.WriteLine($"{Convert.ToString(a, toBase: 2).PadLeft(32, '0'),32}");
            Console.WriteLine($"{Convert.ToString(test, toBase: 2).PadLeft(32, '0'),32}");
        }
    }
}
