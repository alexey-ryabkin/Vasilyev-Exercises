namespace Exercise06_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo? LastPressedKey = null;
            int number = 0;
            Random rng = new Random();
            Thread stopping = new Thread( () => { LastPressedKey = Console.ReadKey(true); } );
            Thread checkingIfEven = new Thread(() =>
            {
                while (LastPressedKey == null)
                {
                    if (number % 2 == 0) Console.WriteLine("Системная оппозиция: Чётное!");
                    Thread.Sleep(1100);
                }
            });
            Thread checkingIfDivisibleBy3 = new Thread(() =>
            {
                while (LastPressedKey == null)
                {
                    if (number % 3 == 0) Console.WriteLine("Несистемная оппозиция: Делится на три!");
                    Thread.Sleep(900);
                }
            });
            stopping.Start();
            checkingIfEven.Start();
            checkingIfDivisibleBy3.Start();
            while (LastPressedKey == null)
            {
                number = rng.Next(101);
                Console.WriteLine("Королевский указ! Новое значение — " + number.ToString());
                Thread.Sleep(1000);
            }
        }
    }
}
