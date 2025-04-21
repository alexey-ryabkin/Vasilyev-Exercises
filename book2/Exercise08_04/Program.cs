// Данное упражнение написано с помощью DeepSeek, потому что мне не нравится возиться с элементами Windows.Forms
namespace Exercise08_04
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    public class TextDuplicatorForm : Form
    {
        private TextBox inputTextBox;
        private Label outputLabel;
        private CheckBox boldCheckBox;
        private CheckBox italicCheckBox;

        public TextDuplicatorForm()
        {
            // Настройка формы
            this.Text = "Текстовый дубликатор";
            this.ClientSize = new Size(400, 200);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;

            // Поле ввода
            inputTextBox = new TextBox();
            inputTextBox.Location = new Point(20, 20);
            inputTextBox.Size = new Size(360, 20);
            inputTextBox.TextChanged += InputTextBox_TextChanged;
            this.Controls.Add(inputTextBox);

            // Метка для отображения текста
            outputLabel = new Label();
            outputLabel.Location = new Point(20, 60);
            outputLabel.Size = new Size(360, 40);
            outputLabel.BorderStyle = BorderStyle.FixedSingle;
            this.Controls.Add(outputLabel);

            // Чекбокс для жирного текста
            boldCheckBox = new CheckBox();
            boldCheckBox.Text = "Жирный";
            boldCheckBox.Location = new Point(20, 120);
            boldCheckBox.Size = new Size(100, 20);
            boldCheckBox.CheckedChanged += StyleCheckBox_CheckedChanged;
            this.Controls.Add(boldCheckBox);

            // Чекбокс для курсивного текста
            italicCheckBox = new CheckBox();
            italicCheckBox.Text = "Курсив";
            italicCheckBox.Location = new Point(140, 120);
            italicCheckBox.Size = new Size(100, 20);
            italicCheckBox.CheckedChanged += StyleCheckBox_CheckedChanged;
            this.Controls.Add(italicCheckBox);
        }

        private void InputTextBox_TextChanged(object sender, EventArgs e)
        {
            outputLabel.Text = inputTextBox.Text;
        }

        private void StyleCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            FontStyle style = FontStyle.Regular;

            if (boldCheckBox.Checked)
                style |= FontStyle.Bold;

            if (italicCheckBox.Checked)
                style |= FontStyle.Italic;

            outputLabel.Font = new Font(outputLabel.Font, style);
        }

        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles(); // Не знал, круто
            Application.Run(new TextDuplicatorForm());
        }
    }
}
