namespace Exercise04_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создание массива случайного размера и его заполнение
            Random rnd = new Random();
            int 
                rows = rnd.Next(1, 11),
                columns = rnd.Next(1, 11),
                delRow = rnd.Next(rows),
                delColumn = rnd.Next(columns);
            int[,]
                ints = new int[rows, columns],
                intsNew = new int[rows - 1, columns - 1];

            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < ints.GetLength(0); i++)
            {
                for (int j = 0; j < ints.GetLength(1); j++)
                {
                    ints[i, j] = rnd.Next(100);
                    Console.Write(ints[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Массив с удалёнными {0} строкой и {1} столбцом:", delRow, delColumn);
            for (int i = 0; i < ints.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < ints.GetLength(1) - 1; j++)
                {
                    // Перевод старых координат в новые координаты (пропуск одной строчки и одного столбца)
                    int k, l;
                    if (i < delRow) k = i;
                        else k = i + 1;
                    if (j < delColumn) l = j;
                        else l = j + 1;

                    intsNew[i, j] = ints[k, l];
                    Console.Write(intsNew[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
