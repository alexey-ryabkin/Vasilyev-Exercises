namespace Exercise05_08
{
    internal class Program
    {
        static int[] fromTo(int a, int b)
        {
            int length = b - a + 1;
            int[] result = new int[length];
            for (int i = a, j = 0; i <= b; i++, j++)
            {
                result[j] = i;
            }
            return result;
        }
        static char[] fromTo(char a, char b)
        {
            int length = b - a + 1;
            char[] result = new char[length];
            for (int i = a, j = 0; i <= b; i++, j++)
            {
                result[j] = (char)i;
            }
            return result;
        }
        static void Main(string[] args)
        {
            int[] a = fromTo(-8, 16);
            char[] b = fromTo('\t', 'L');

            foreach (char c in b) Console.Write(c + " ");
            Console.WriteLine();
            foreach (int d in a) Console.Write(d + " ");
        }
    }
}
