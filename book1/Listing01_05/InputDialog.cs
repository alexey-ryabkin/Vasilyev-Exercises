

namespace Listing01_05
{
    class InputDialog
    {
        static void Main()
        {
            string cardNumber = Microsoft.VisualBasic.Interaction.InputBox(
                "Пожалуйста, введите номер своей карты",
                "Покупка автомобиля Лада",
                "Плачу наличкой",
                600,
                0);
            string message = "С вашей карты " + cardNumber + " списано миллион ₽.";
            System.Windows.Forms.MessageBox.Show(message, "Вы лох!!");
        }
    }
}
