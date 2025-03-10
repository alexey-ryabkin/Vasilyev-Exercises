namespace Exercise07_01
{
    internal class Program
    {
        static System.String AddSpaces(System.String arg)
        {
            System.String output = System.String.Empty;
            foreach (System.Char letter in arg)
            {
                output += letter.ToString() + ' ';
            }
            output = output.Substring(0,output.Length - 1);
            return output;
        }
        static void Main(string[] args)
        {
            Console.WriteLine('|' + AddSpaces("Hello, World!") + '|');
        }
    }
}
