using System.Xml;

namespace Exercise07_02
{
    internal class Program
    {
        static string ReverseWords (string arg)
        {
            string output = "";
            string[] words = arg.Split (' ');
            foreach (string word in words)
            {
                output = word + " " + output;
            }
            output = output.Trim(' ');
            return output;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("|" + Program.ReverseWords("      1 2 3 4 5 6 7 8 9                   ") + "|");
        }
    }
}
