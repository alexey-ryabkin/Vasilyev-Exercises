namespace Exercise07_07
{
    internal class Program
    {
        // Сам Substring() использовать нельзя. В задании это не прописано.
        static string RyabSubstring(string text, int first, int length)
        {
            string substring = string.Empty;
            for (int i = first; i != first + length;)
            {
                if (0 <= i && i < text.Length) substring += text[i];
                i += Math.Sign(length);
            }
            return substring;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("0 " + "5 " +   RyabSubstring("012345678901234567890", 0, 5));
            Console.WriteLine("2 " + "5 " +   RyabSubstring("012345678901234567890", 2, 5));
            Console.WriteLine("10 " + "5 " +  RyabSubstring("012345678901234567890", 10, 5));
            Console.WriteLine("10 " + "0 " +  RyabSubstring("012345678901234567890", 10, 0));
            Console.WriteLine("40 " + "0 " +  RyabSubstring("012345678901234567890", 40, 0));
            Console.WriteLine("40 " + "10 " + RyabSubstring("012345678901234567890", 40, 10));
            Console.WriteLine("18 " + "10 " + RyabSubstring("012345678901234567890", 18, 10));
            Console.WriteLine("-18 " + "10 " + RyabSubstring("012345678901234567890", -18, 10));
            Console.WriteLine("-18 " + "-10 " + RyabSubstring("012345678901234567890", -18, -10));
            Console.WriteLine("18 " + "-10 " + RyabSubstring("012345678901234567890", 18, -10));
            Console.WriteLine("-0 " + "-0 " + RyabSubstring("012345678901234567890", -0, -0));
            Console.WriteLine("-5 " + "20 " + RyabSubstring("012345678901234567890", -5, 20));
        }
    }
}
