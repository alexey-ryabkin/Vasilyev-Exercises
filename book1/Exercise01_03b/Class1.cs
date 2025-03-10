using Microsoft.VisualBasic;
using System;
using System.Windows.Forms;

namespace Exercise01_03b
{
    class Program
    {
        static void Main()
        {
            string weekday, month;
            int day;
            weekday = Interaction.InputBox("Введите текущий день недели");
            month = Interaction.InputBox("Введите текущий месяц");
            day = Int32.Parse(Interaction.InputBox("Введите текущее число месяца"));
            MessageBox.Show("Сегодня " + weekday + ", " + day + " месяца " + month);
        }
    }
}