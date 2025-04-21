// Данное упражнение сделано с помощью DeepSeek, потому что мне не нравится возиться с повторяющимся кодом WinForms

namespace Exercise08_05
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    public class NumberComparisonForm : Form
    {
        private TextBox textBox1;
        private TextBox textBox2;
        private Label resultLabel;

        public NumberComparisonForm()
        {
            // Настройка формы
            this.Text = "Сравнение чисел";
            this.ClientSize = new Size(300, 150);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;

            // Первое текстовое поле
            textBox1 = new TextBox();
            textBox1.Location = new Point(20, 20);
            textBox1.Size = new Size(100, 20);
            textBox1.TextChanged += UpdateComparison;
            this.Controls.Add(textBox1);

            // Второе текстовое поле
            textBox2 = new TextBox();
            textBox2.Location = new Point(160, 20);
            textBox2.Size = new Size(100, 20);
            textBox2.TextChanged += UpdateComparison;
            this.Controls.Add(textBox2);

            // Метка для результата
            resultLabel = new Label();
            resultLabel.Location = new Point(20, 60);
            resultLabel.Size = new Size(260, 60);
            resultLabel.Text = "Введите числа для сравнения";
            this.Controls.Add(resultLabel);
        }

        private void UpdateComparison(object sender, EventArgs e)
        {
            int num1, num2;
            // Узнал про TryParse, я планировал делать через ловлю исключений
            bool isNum1Valid = int.TryParse(textBox1.Text, out num1);
            bool isNum2Valid = int.TryParse(textBox2.Text, out num2);

            if (textBox1.Text == "" || textBox2.Text == "")
            {
                resultLabel.Text = "Введите числа для сравнения";
                return;
            }

            if ((!isNum1Valid || !isNum2Valid))
            {
                resultLabel.Text = "Ошибка: введите целые числа в оба поля";
                return;
            }

            if (num1 > num2)
            {
                resultLabel.Text = $"{num1} больше {num2}";
            }
            else if (num1 < num2)
            {
                resultLabel.Text = $"{num1} меньше {num2}";
            }
            else
            {
                resultLabel.Text = "Числа равны";
            }
        }

        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.Run(new NumberComparisonForm());
        }
    }
}
