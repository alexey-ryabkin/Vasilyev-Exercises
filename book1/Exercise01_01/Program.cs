using System;

namespace Exercise01_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? name, surname;
            Console.Write("Введите ваше имя: ");
            name = Console.ReadLine();
            Console.Write("Введите вашу фамилию: ");
            surname = Console.ReadLine();
            Console.WriteLine("Ваше имя: {0}", name);
            Console.WriteLine("Ваша фамилия: {0}", surname);
        }
    }
}
