namespace Listing01_06
{
    internal class InputFromConsole
    {
        static void Main()
        {
            string? cardNumber;
            Console.Title = "Введите номер карты";
            Console.Write("Введите ваш номер карты: ");
            cardNumber = Console.ReadLine();
            Console.Title = "Номер лоха получен";
            Console.WriteLine("Номер лоха: " + cardNumber);
            cardNumber = Console.ReadLine();
        }
    }
}
