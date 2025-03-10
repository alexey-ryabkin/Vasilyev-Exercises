namespace Exercise06_09
{
    class RyabMath
    {
        public static int max(params int[] input)
        {
            int max = input[0];
            foreach (int i in input)
            {
                if (i > max) max = i;
            }
            return max;
        }
        public static int min(params int[] input)
        {
            int min = input[0];
            foreach (int i in input)
            {
                if (i < min) min = i;
            }
            return min;
        }
        public static double mean(params int[] input)
        {
            int sum = 0;
            foreach (int i in input) sum += i;
            double mean = (double)sum / input.Length;
            return mean;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RyabMath.max(0, 1, 21, 40, 8000, 5));
            Console.WriteLine(RyabMath.min(0, 1, 21, 40, 8000, 5));
            Console.WriteLine(RyabMath.mean(0, 1, 21, 40, 8000, 5));
            Console.WriteLine(RyabMath.max([0, 1, 21, 40, 8000, 5]));
            Console.WriteLine(RyabMath.min([0, 1, 21, 40, 8000, 5]));
            Console.WriteLine(RyabMath.mean([0, 1, 21, 40, 8000, 5]));
        }
    }
}
