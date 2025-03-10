using System;

namespace Листинг01_07
{
    class Листинг01_07
    {
        static void Main()
        {
            string input, output;
            int currentYear = 2024, age, birthYear;
            input = Microsoft.VisualBasic.Interaction.InputBox(
                "В каком году вы родились?",
                "Сбор персональных данных",
                "2001",
                0,
                0
                );
            birthYear = Int32.Parse(input);
            age = currentYear - birthYear;
            output = "Значит вам " + age + " полных лет или на один год меньше!!!!";
            System.Windows.Forms.MessageBox.Show(output, "ВАШ ВОЗРАСТ!!!!!!!");
        }
    }
}
