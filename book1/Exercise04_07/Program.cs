namespace Exercise04_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = 10;
            char[] a = new char[size], temp;
            Random rng = new Random();

            for (int i = 0; i < size; i++)
            {
                a[i] = (char) rng.Next('a','a' + 26);
            }

            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(a[i]);
            }

            temp = new char[a.Length];
            for (int i = a.Length - 1, j = 0; i >= 0; i--, j++)
            {
                temp[j] = a[i];
            }
            a = temp;


            Console.WriteLine("Инвертированный массив:");
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(a[i]);
            }
        }
    }
}
