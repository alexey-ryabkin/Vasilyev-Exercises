namespace Exercise06_07
{
    internal class Program
    {
        static Random random = new Random();
        static void ShowMatrix(int[,] matrix)
        {
            Console.WriteLine("Матрица:");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j],15}");
                }
                Console.WriteLine();
            }
        }
        static bool IsAnyAlive(Thread[] threads)
        {
            for (int i = 0; i < threads.Length; i++)
            {
                if (threads[i].IsAlive) return true;
            }
            return false;
        }
        static void FillRow(int[,] matrix, int row, int numBase)
        {
            int length = matrix.GetLength(1);
            if (length == 0 || matrix.GetLength(0) <= row) return;
            matrix[row, 0] = 1;
            for (int i = 1; i < length; i++)
            {
                matrix[row, i] = matrix[row, i - 1] * numBase;
                Thread.Sleep(random.Next(100,3000));
            }

        }
        static void Main(string[] args)
        {
            int rows = random.Next(4, 100),
                columns = random.Next(4, 10);
            int[,] matrix = new int[rows, columns];
            Thread[] threads = new Thread[rows];
            for (int i = 0; i < threads.Length; i++)
            {
                int r = i; // Капец, полчаса на это потраил.. Я же читал об этом в книжке. Без этой строки работает в 80% случаев.
                ThreadStart threadStart = new ThreadStart
                (
                    delegate() 
                    {
                        FillRow(matrix, r, r); 
                    }
                );
                threads[i] = new Thread(threadStart);
                threads[i].Start();
            }
            
            while (IsAnyAlive(threads))
            {
                ShowMatrix(matrix);
                Thread.Sleep(1000);
            }
            
            for (int i = 0; i < threads.Length; i++)
            {
                threads[i].Join();
            }
            Console.WriteLine("Выполнение программы завершено.");
            ShowMatrix(matrix);
        }
    }
}
