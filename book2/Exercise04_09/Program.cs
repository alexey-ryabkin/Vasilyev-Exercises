namespace Exercise04_09
{
    unsafe internal class Program
    {
        static void Main(string[] args)
        {
            string a = "Изучаем C#";
            fixed(char* p = a)
            {
                char[] copy = new char[a.Length];
                a.CopyTo(copy);
                for (int i = 0; i < a.Length; i++)
                {
                    p[i] = copy[a.Length - 1 - i];
                }
            }
            Console.WriteLine(a);
        }
    }
}
