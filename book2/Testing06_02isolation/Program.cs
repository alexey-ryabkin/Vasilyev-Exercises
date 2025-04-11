namespace Testing06_02isolation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread[] threads = new Thread[5];
            for (int i = 0; i < threads.Length; i++)
            {
                int r = i;
                threads[r] = new Thread(() => 
                {
                    while (true)
                    {
                        Thread.Sleep(100);
                        Console.WriteLine(Thread.CurrentThread.Priority);
                    }
                });
                int caseKeeper = 5 * r / 5;
                switch (caseKeeper)
                {
                    case 0:
                        threads[r].Priority = ThreadPriority.Lowest;
                        break;
                    case 1:
                        threads[r].Priority = ThreadPriority.BelowNormal;
                        break;
                    case 2:
                        threads[r].Priority = ThreadPriority.Normal;
                        break;
                    case 3:
                        threads[r].Priority = ThreadPriority.AboveNormal;
                        break;
                    case 4:
                        threads[r].Priority = ThreadPriority.Highest;
                        break;
                    default:
                        threads[r].Priority = ThreadPriority.Highest;
                        break;
                }
                threads[r].Start();
                Console.WriteLine(threads[r].Priority);
            }
            //while (true) Console.WriteLine(threads[0].Priority);
        }
    }
}
