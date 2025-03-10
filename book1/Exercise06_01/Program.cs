namespace Exercise06_01
{
    class MyClass
    {
        private char character;

        public void set(char input)
        {
            this.character = input;
            Console.WriteLine("Объекту " + this + " назначен символ " + this.character);
        }

        public int getInt()
        {
            return (int)this.character;
        }

        public void show()
        {
            Console.WriteLine("Символ: " + this.character + ", его номер: " + (int)this.character);
        }

        ~MyClass() 
        {
            Console.WriteLine("Объект уничтожен.");
        }
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass a = new MyClass();

            a.show();
            a.set('ъ');
            Console.WriteLine(a.getInt());
            a.show();
        }
    }
}
