using System.Linq.Expressions;
using static System.Console;

namespace Exercise09_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? input;
            string[] numbers;
            int day, month, year, dayNow, monthNow, yearNow, dayDiff, monthDiff, yearDiff, prevMonth;
            bool success, negative;
            DateTime DoB, now;
            string yearString, monthString, dayString;

            DoB = new DateTime();
            day = month = year = 1;
            success = false;
            negative = false;
            while (!success)
            {
                Write("Введите дату своего рождения в формате дд.мм.гггг: ");
                input = ReadLine();
                try
                {
                    if (input != null)
                    {
                        numbers = input.Split(".");
                        day = int.Parse(numbers[0]);
                        month = int.Parse(numbers[1]);
                        year = int.Parse(numbers[2]);
                        DoB = new DateTime(year, month, day);
                    }
                    success = true;
                }
                catch
                {
                    WriteLine("Формат ввода неверный. Попробуйте ещё раз.");
                }
            }
            now = DateTime.Now.Date;

            if (DoB > now)
            {
                negative = true;
                (DoB, now) = (now, DoB);
            }
            day = DoB.Day;
            month = DoB.Month;
            year = DoB.Year;

            dayNow = now.Day;
            monthNow = now.Month;
            yearNow = now.Year;

            yearDiff = yearNow - year;
            monthDiff = monthNow - month;
            if (monthDiff < 0)
            {
                yearDiff--;
                monthDiff += 12;
            }
            dayDiff = dayNow - day;
            if (dayDiff < 0)
            {
                monthDiff--;
                if (monthNow == 12)
                {
                    dayDiff += 31;
                }
                else
                {
                    dayDiff += DateTime.DaysInMonth(yearNow, monthNow - 1);
                }
            }

            yearString = monthString = dayString = string.Empty;
            if (yearDiff != 0) yearString = string.Format("{0} лет, ", yearDiff);
            if (monthDiff != 0) monthString = string.Format("{0} месяцев, ", monthDiff);
            if (dayDiff != 0) dayString = string.Format("{0} дней", dayDiff);
            if (DoB == now)
            {
                WriteLine("День рождения сегодня.");
            }
            else if (negative)
            {
                WriteLine("До момента рождения осталось полных {0}{1}{2}.", yearString, monthString, dayString);
            }
            else
            {
                WriteLine("С момента рождения прошло полных {0}{1}{2}.", yearString, monthString, dayString);
            }
        }
    }
}
