using Microsoft.VisualBasic;
using System;
using System.Windows.Forms;

namespace Exercise01_02a
{
    class Program
    {
        static void Main()
        {
            string name;
            int age;
            name = Interaction.InputBox("Введите имя");
            age = Int32.Parse(Interaction.InputBox("Введите возраст"));
            MessageBox.Show("Вас зовут " + name + ", а ваш возраст — " + age);
        }
    }
}