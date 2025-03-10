using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Listing02_01_self
{
    internal class Class1
    {
        static void Main()
        {
            int number;
            bool check;
            string output, result;
            const string caption = "Проверка числа на чётность";

            number = Int32.Parse(Interaction.InputBox("Введите целое число", caption));
            check = number % 2 == 0;
            result = check?"чётное":"нечётное";
            output = "Число " + number + " " + result + "!";
            MessageBox.Show(output, caption, MessageBoxButtons.OK);
        }
    }
}
