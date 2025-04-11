namespace Testing06_02
{
    internal class Program
    {
        const int a = 3;
        static int[] counts = new int[a];
        static void Calculations(int a)
        {
            while (true)
            {
                counts[a]++;
                //Thread.Sleep(1);
                Slow();
            }
        }
        static void Main(string[] args)
        {
            Thread[] Calculations = new Thread[a];
            for (int i = 0; i < a; i++)
            {
                counts[i] = 0;
                int r = i;
                ThreadStart tsCalculations = new ThreadStart(() => Program.Calculations(r));
                Calculations[r] = new Thread(tsCalculations);
                int caseKeeper = 5 * r / a;
                switch (caseKeeper)
                {
                    case 0:
                        Calculations[r].Priority = ThreadPriority.Lowest;
                        break;
                    case 1:
                        Calculations[r].Priority = ThreadPriority.BelowNormal;
                        break;
                    case 2:
                        Calculations[r].Priority = ThreadPriority.Normal;
                        break;
                    default:
                        Calculations[r].Priority = ThreadPriority.AboveNormal;
                        break;
                }
            }
            Thread Printer = new Thread(() =>
            {
                while (true)
                {
                    Console.Clear();
                    string print = string.Empty;
                    for (int i = 0; i < a; i++)
                    {
                        print += String.Format("В потоке {0, 2} вычисления выполнены {1,12} раз, приоритет потока {2}\n", i, counts[i], Calculations[i].Priority);
                    }
                    Console.WriteLine(print);
                    Thread.Sleep(200);
                }
            });
            Thread.CurrentThread.Priority = ThreadPriority.Highest;
            Printer.Priority = ThreadPriority.Highest;
            for (int i = 0; i < a; i++) Calculations[i].Start();
            Printer.Start();
        }
        // https://stackoverflow.com/a/13001749
        static public void Slow()
        {
            long nthPrime = FindPrimeNumber(10); //set higher value for more time
        }
        static public long FindPrimeNumber(int n)
        {
            int count = 0;
            long a = 2;
            while (count < n)
            {
                long b = 2;
                int prime = 1;// to check if found a prime
                while (b * b <= a)
                {
                    if (a % b == 0)
                    {
                        prime = 0;
                        break;
                    }
                    b++;
                }
                if (prime > 0)
                {
                    count++;
                }
                a++;
            }
            return (--a);
        }
    }
}
