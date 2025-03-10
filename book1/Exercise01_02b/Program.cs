namespace Exercise01_02b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? name;
            int age;
            Console.WriteLine("Введите ваше имя");
            name = Console.ReadLine();
            Console.WriteLine("Введите ваш возраст");
            age = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Вас зовут {0}, а ваш возраст — {1}", name, age);
        }
    }
}
