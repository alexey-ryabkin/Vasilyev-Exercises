namespace Exercise06_03
{
    internal class Program
    {
        static char[] letters;
        static void FillEvenIndexes()
        {
            int index = 0;
            while (index < letters.Length)
            {
                letters[index] = (char)('A' + index/2);
                index += 2;
                Thread.Sleep(100);
            }
        }
        static void FillOddIndexes()
        {
            int index = 1;
            while (index < letters.Length)
            {
                letters[index] = (char)('А' + (index - 1)/2);
                index += 2;
                Thread.Sleep(200);
            }
        }
        static void Show()
        {
            //Console.Clear();
            Console.Write(letters[0]);
            for (int i = 1; i < letters.Length; i++)
            {
                Console.Write(letters[i]);
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Random rng = new Random();
            letters = new char[rng.Next(80, 100)];
            for (int i = 0; i < letters.Length; i++) letters[i] = '*';
            ThreadStart threadStartEven = new ThreadStart(FillEvenIndexes);
            ThreadStart threadStartOdd = new ThreadStart(FillOddIndexes);
            Thread threadEven = new Thread(FillEvenIndexes);
            Thread threadOdd = new Thread(FillOddIndexes);
            threadEven.Start();
            threadOdd.Start();
            while (threadEven.IsAlive || threadOdd.IsAlive)
            {
                Show();
                Thread.Sleep(100);
            }
        }
    }
}
