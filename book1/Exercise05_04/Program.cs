namespace Exercise05_04
{
    internal class Program
    {
        static int[] get_Codes(char[] chars)
        {
            int[] codes = new int[chars.Length];
            for (int i = 0; i < codes.Length; i++)
            {
                codes[i] = chars[i];
            }
            return codes;
        }
        
        static void Main(string[] args)
        {
            char[] chars = {'a', 'b', '6', 'п', ' ', '\n', '\t', '€'};
            int[] ints;
            ints = get_Codes(chars);

            foreach (int i in ints)
            {
                Console.WriteLine(i);
            }
        }
    }
}
