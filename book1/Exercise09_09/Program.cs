using System;

namespace Exercise09_09
{
    class Plane
    {
        private int[,] plane;

        public Plane()
        {
            Random random = new Random();
            int rows = random.Next(3, 8),
                columns = random.Next(5,12);
            plane = new int[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    plane[i, j] = random.Next(100);
                }
            }
        }

        public int this[int row, int column]
        {
            get
            {
                return plane[row, column];
            }
            set
            {
                plane[row, column] = value;
            }
        }

        public int this[int row]
        {
            get
            {
                int max = plane[row, 0],
                    max_index = 0;
                for (int i = 1; i < plane.GetLength(1); i++)
                {
                    if (max < plane[row, i]) max = plane[row, i];
                }
                return max;
            }
            set
            {
                int max = plane[row, 0],
                    max_index = 0;
                for (int i = 1; i < plane.GetLength(1); i++)
                {
                    if (max < plane[row, i])
                    {
                        max = plane[row, i];
                        max_index = i;
                    }
                }
                plane[row, max_index] = value;
            }
        }



        public override string ToString()
        {
            string result = string.Empty;
            for (int i = 0; i < plane.GetLength(0); i++)
            {
                if (i!= 0) result += "\n";
                result += plane[i, 0];
                for (int j = 1; j < plane.GetLength(1); j++)
                {
                    result += "\t" + plane[i, j];
                }
            }
            return result;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Plane a;
            for (int i = 0; i < 10; i++)
            {
                a = new Plane();
                Console.WriteLine(a);
                a[0, 0] = 69;
                Console.WriteLine(a[0,0]);
                a[0] = 70;
                Console.WriteLine(a[0]);
                Console.WriteLine(a + "\n");
            }
        }
    }
}
