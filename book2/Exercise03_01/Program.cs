namespace Exercise03_01
{
    internal class Program
    {
        enum Weekdays : sbyte { Понедельник, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday };
        static void Main(string[] args)
        {
            Weekdays a = Weekdays.Saturday;
            Console.WriteLine(a);
            for (int i = -10; i <= 10; i++)
            {
                Weekdays day = GetWeekday(i);
                Console.WriteLine("{0} — {1}", i, day);
                Console.WriteLine(
                    "Между {0} и {1} {2} дней.", 
                    Weekdays.Tuesday, 
                    day, 
                    GetDifference(Weekdays.Tuesday, day)
                );
            }
        }
        static Weekdays GetWeekday(int day)
        {
            return (Weekdays)((day % 7 + 7) % 7);
        }
        static int GetDifference(Weekdays first, Weekdays second)
        {
            int max = 7;
            int diff = Math.Abs(first - second);
            Console.WriteLine(diff);
            if (diff > max / 2) diff = max - diff;
            return diff;
        }
    }
}
