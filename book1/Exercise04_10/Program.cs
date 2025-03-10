namespace Exercise04_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int
                rows = rnd.Next(10, 16),
                columns = rnd.Next(10, 16);
            int[,] snake = new int[rows, columns];

            bool adding, horizontal;
            adding = horizontal = true;
            int i, j, subtractor;
            i = j = subtractor = 0;

            Console.WriteLine("Для змейки нажмите возврат каретки..");
            Console.ReadLine();
            Console.Clear();

            for (int counter = 0; counter < rows * columns; counter++)
            {
                snake[i, j] = counter;

                if (horizontal)
                {
                    if (adding)
                    {
                        j++;
                        if (j == snake.GetLength(1) - subtractor - 1)
                        {
                            horizontal = false;
                        }
                    }
                    else
                    {
                        j--;
                        if (j == subtractor)
                        {
                            horizontal = false;
                        }
                    }
                }
                else
                {
                    if (adding)
                    {
                        i++;
                        if (i == snake.GetLength(0) - subtractor - 1)
                        {
                            horizontal = true;
                            adding = false;
                        }
                    }
                    else
                    {
                        i--;
                        if (i == subtractor + 1)
                        {
                            horizontal = true;
                            adding = true;
                            subtractor += 1;
                        }
                    }
                }

                Console.Clear();
                for (int k = 0; k < snake.GetLength(0); k++)
                {
                    for (int l = 0; l < snake.GetLength(1); l++)
                    {
                        Console.Write(snake[k, l] + "\t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                System.Threading.Thread.Sleep(33);
            }
        }
    }
}
