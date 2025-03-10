namespace Exercise05_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = {0, 1, 2, 3, 4, 5, 6};
            int[] b;

            b = reverse(a);

            foreach (int i in b) Console.Write("{0}\t", i);
        }

        static int[] reverse(int[] a)
        {
            int[] b = new int[a.Length];
            int l = a.Length, max = l - 1;

            for (int i = 0; i < l; i++)
            {
                int c = max - i;
                b[c] = a[i];
            }
            return b;
        }
    }
}
