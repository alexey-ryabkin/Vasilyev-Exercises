namespace Exercise06_04
{
    class MyClass
    {
        char character;
        int number;

        public MyClass(char character, int number)
        {
            this.character = character;
            this.number = number;
        }
        public MyClass(double frankenstein)
        {
            // Целая часть — номер символа. Автоматическое приведение double в int с отбрасыванием дробной части, а потом приведение int в char
            this.character = (char)frankenstein;
            // Десятые и сотые — число
            this.number = (int)(frankenstein % 1 * 100);
        }
        public void show()
        {
            Console.WriteLine("Символ — {0}, число — {1}", this.character, this.number);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass
                a = new MyClass('a', 10),
                b = new MyClass(65.897),
                c = new MyClass(1089.4);
            a.show();
            b.show();
            c.show();
        }
    }
}
