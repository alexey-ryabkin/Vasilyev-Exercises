using Microsoft.VisualBasic;
using System.Windows.Forms;

namespace Ryabkin
{
    class Program
    {
        static void Main()
        {
            double input1 = 0, input2 = 0;
            string text, caption = "Сравнение чисел";
            MessageBoxIcon icon = MessageBoxIcon.Information;
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            bool failure = true;

            while (failure)
            {
                try
                {
                    input1 = double.Parse(Interaction.InputBox("Введите первое число", caption));
                    input2 = double.Parse(Interaction.InputBox("Введите второе число", caption));
                    failure = false;
                    icon = MessageBoxIcon.Information;
                }
                catch (System.Exception)
                {
                    text = "К сожалению, произошла ошибка. Пожалуйста, введите корректные числа.";
                    icon = MessageBoxIcon.Hand;
                    MessageBox.Show(text, caption, buttons, icon);
                }
            }


            if (input1 > input2)
            {
                text = "Первое число больше второго:\n" + input1 + " > " + input2;
            }
            else if (input1 < input2)
            {
                text = "Второе число больше первого:\n" + input2 + " > " + input1;
            }
            else 
            {
                text = "Числа равны:\n" + input2 + " = " + input1;
            }

            MessageBox.Show(text,caption,buttons,icon);
        }
    }
}