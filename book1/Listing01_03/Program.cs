// Использование пространства имён
using System.Windows.Forms;

// Класс с главным методом программы
class Dialog
{
    // Главный метод программы
    static void Main()
    {
        // Отображение диалогового окна
        DialogResult a = MessageBox.Show("Я окошко!!!!", 
            "Очень важное сообщение", 
            MessageBoxButtons.AbortRetryIgnore, 
            MessageBoxIcon.Asterisk
            );
        if ( a == DialogResult.Retry)
        {
            MessageBox.Show("Я окошко!!!!");
        }
    }
}