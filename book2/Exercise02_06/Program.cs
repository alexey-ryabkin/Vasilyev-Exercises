namespace Exercise02_06
{
    internal delegate string Weekdays();
    class Calendar
    {
        public Calendar()
        {
            c_weekday = "Воскресенье";
            weekday = delegate ()
            {
                switch (c_weekday)
                {
                    case "Воскресенье":
                        c_weekday = "Понедельник";
                        break;
                    case "Понедельник":
                        c_weekday = "Вторник";
                        break;
                    case "Вторник":
                        c_weekday = "Среда";
                        break;
                    case "Среда":
                        c_weekday = "Четверг";
                        break;
                    case "Четверг":
                        c_weekday = "Пятница";
                        break;
                    case "Пятница":
                        c_weekday = "Суббота";
                        break;
                    case "Суббота":
                        c_weekday = "Воскресенье";
                        break;
                }
                return c_weekday;
            };
        }
        private string c_weekday;
        public Weekdays weekday;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Calendar a = new Calendar();
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(a.weekday());
            }
        }
    }
}
