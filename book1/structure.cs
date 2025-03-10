/*
class Program
{
	// Описание класса
	static void Main()
	{
		// Главный (Main) метод
		// static — не нужен объект для вызова
		// void — не возвращает результат
		// public — доступен за пределами класса
		// Код программы
	}
}
*/

// Главный класс программы
class HelloWorld
{
	// Главный метод программы
	static void Main()
	{
		// Отображение сообщений в консольном окне
		System.Console.WriteLine("Изучаю язык C#");
	}
}

// Главный класс программы
class HelloWorld{static void Main(){System.Console.WriteLine("Изучаю язык C#");}}




// Использование пространства имён
using System.Windows.Forms;

// Класс с главным методом программы
class Dialog
{
    // Главный метод программы
    static void Main()
    {
        // Отображение диалогового окна
        MessageBox.Show("Я окошко!!!!");
    }
}








namespace Exercise01_02b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? name;
            int age;
			Console.Title = "1";
            Console.WriteLine("Введите ваше имя");
            name = Console.ReadLine();
            Console.WriteLine("Введите ваш возраст");
            age = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Вас зовут {0}, а ваш возраст — {1}", name, age);
        }
    }
}


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