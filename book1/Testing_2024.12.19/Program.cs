namespace Testing_2024._12._19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 0, 1, 2 }, 
                b = a, 
                c = { 0, 1, 2 };

            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + ", ");
            }
            Console.WriteLine("{0}, {1}, {2}", a, b, c);
            a[0] = 2;

            Console.WriteLine("{0}, {1}, {2}", a, b, c);
        }
    }
}
