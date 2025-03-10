namespace Exercise10_01
{
    class Base
    {
        protected string name;
        public Base(string name)
        {
            this.name = name;
        }
        public override string ToString()
        {
            return "Класс Base, значение \"" + name + "\".";
        }
    }
    class Derived: Base
    {
        protected string surname;
        public Derived(string surname) : base("Иван")
        {
            this.surname = surname;
        }
        public Derived(string surname, string name): base(name)
        {
            this.surname = surname;
        }
        public override string ToString()
        {
            return "Класс Derived, значения \"" + name + "\" и \"" + surname + "\".";
        }
    }
    internal class Program
    {
        static void Main()
        {
            Base person = new Base("Валера");
            Derived person1 = new Derived("Иванов");
            Derived person2 = new Derived("Чижиков", "Аркадий");
            Console.WriteLine(person);
            Console.WriteLine(person1);
            Console.WriteLine(person2);
        }
    }
}
