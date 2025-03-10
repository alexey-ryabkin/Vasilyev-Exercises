using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Exercise01_01b
{
    internal class Program
    {
        static void Main()
        {
            string name, surname;
            name = Interaction.InputBox("Введите ваше имя", "Запрос имени", "Алексей");
            surname = Interaction.InputBox("Введите вашу фамилию", "Запрос фамилии", "Рябкин");
            MessageBox.Show(
                "Вас зовут " + name + " " + surname + "!!!!", 
                "Я знаю о вас всё",
                MessageBoxButtons.RetryCancel, 
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button2);
        }
    }
}
