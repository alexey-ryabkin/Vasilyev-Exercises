using System;
using System.Management.Instrumentation;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using IB = Microsoft.VisualBasic.Interaction;

namespace Exercise09_01
{
    internal class Class1
    {
        internal static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Random rng = new Random();
            int number = rng.Next(1, 11);
            while (true)
            {
                string input = IB.InputBox("Введите число от 1 до 10, нужно ввести " + number, "Угадайка", "1");
                if (number.ToString() == input)
                {
                    MessageBox.Show("Правильно", "Угадайка", MessageBoxButtons.OK);
                    Environment.Exit(0);
                }
                else
                {

                    if (MessageBox.Show("Неправильно.\nПродолжить?", "Угадайка", MessageBoxButtons.YesNo) == DialogResult.No) Environment.Exit(0);
                }
            }
        }
    }
}
