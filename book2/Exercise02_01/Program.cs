namespace Exercise02_01
{
    internal delegate int StringInfo(char letter, string text);
    internal class Program
    {
        static int CountLetter(char letter, string text)
        {
            Console.WriteLine("Вызван CountLetter");
            int counter = 0;
            foreach (char current_letter in text)
            {
                if (letter == current_letter) counter++;
            }
            return counter;
        }
        static int GetLetterIndex(char letter, string text)
        {
            Console.WriteLine("Вызван GetLetterIndex");
            int index = 0;
            foreach (char current_letter in text)
            {
                if (letter == current_letter) return index;
                index++;
            }
            return -1;
            throw new NotImplementedException();
        }
        static void Main(string[] args)
        {
            StringInfo MyDelegate = new StringInfo(Program.CountLetter);
            MyDelegate = GetLetterIndex;
            Test(MyDelegate);// L0 L4 L-1 L-1 
            MyDelegate -= GetLetterIndex;
            Test(MyDelegate); // без вывода
            MyDelegate += CountLetter;
            Test(MyDelegate); // C1 C2 C0 C0
            MyDelegate += GetLetterIndex;
            Test(MyDelegate); // CL0 CL4 CL-1 CL-1 
        }
        static void Test(StringInfo mydelegate)
        {
            if (mydelegate is not null) // is not как в Python, не знал, не гуглил, обнаружил
            {
                Console.Write(mydelegate('L', "Lorem ipsum") + " ");
                Console.Write(mydelegate('m', "Lorem ipsum") + " ");
                Console.Write(mydelegate('d', "Lorem ipsum") + " ");
                Console.Write(mydelegate('d', ""));
                Console.WriteLine();
            }
        }
    }
}
