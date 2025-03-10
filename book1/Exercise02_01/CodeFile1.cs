using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Exercise02_01
{
    internal class Class1
    {
        static void Main()
        {
            int number;
            bool check;
            string output, result;
            const string caption = "Проверка числа на деление на 3";

            string input, result1, input1;
            int sum;

            input = Interaction.InputBox("Введите целое число", caption);
            input1 = input;
            sum = Int32.Parse(input1);
            while (input1.Length > 1)
            {
                sum = 0;
                foreach (char character in input1)
                {
                    if (Char.IsDigit(character))
                    {
                        sum += (int)Char.GetNumericValue(character);
                    }
                    input1 = sum.ToString();
                }
            }
            result1 = sum == 3 || sum == 0 ? "делится на 3" : "не делится на 3";

            number = Int32.Parse(input);
            check = number % 3 == 0;
            result = check ? "делится на 3" : "не делится на 3";
            output = "Число " + number + " " + result + "!"
                + "\n" + "Число " + number + " " + result1 + "!";
            MessageBox.Show(output, caption, MessageBoxButtons.OK);
        }
    }
}
