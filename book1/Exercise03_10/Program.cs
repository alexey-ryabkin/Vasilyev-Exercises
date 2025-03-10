namespace Exercise03_10
{
    internal class Program
    {
        static void Main()
        {
            long number = 0, sum = 0;

            try
            {
                number = long.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Бе");
            }

            for (int i = 0; number > 0; i++)
            {
                if (i % 523 == 2 && i % 301 == 1)
                {
                    Console.Write(i + " ");
                    sum += i;
                    number -= 1;
                }
            }
            Console.WriteLine();
            Console.WriteLine(sum);
        }
    }
}
