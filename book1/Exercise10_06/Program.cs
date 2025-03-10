namespace Exercise10_06
{
    class Doggy
    {
        protected string name;
        public Doggy()
        {
            name = "Барсик";
        }
        public Doggy(string name)
        {
            this.name = name;
        }
        public virtual void print()
        {
            Console.WriteLine(this);
        }
        public override string ToString()
        {
            return String.Format("Собачку зовут {0}", name);
        }
    }
    class Kitten: Doggy
    {
        protected int age;
        public Kitten(string name, int age): base(name)
        {
            this.age = age;
        }
        // Не уверен, из print базового класса запустится этот ToString.
        // Предполагаю, что запустится в зависимости от класса объекта.
        // Я был прав)
        public override string ToString()
        {
            return String.Format("Котика зовут {0}, ему {1} лет", name, age);
        }
    }
    class Antilope: Doggy
    {
        protected char grade;
        public Antilope(string name, char grade) : base(name)
        {
            this.grade = grade;
        }
        new public void print()
        {
            Console.WriteLine(String.Format("Антилопу зовут {0}, она оценена в {1} баллов", name, grade));
        }
        public override string ToString()
        {
            return String.Format(String.Format("Антилопу зовут {0}, её мясо на {1} баллов", name, grade));
        }
    }
    class Antiloped: Doggy
    {
        protected char grade;
        public Antiloped(string name, char grade) : base(name)
        {
            this.grade = grade;
        }
        public override void print()
        {
            Console.WriteLine(String.Format("Антилопу зовут {0}, она оценена в {1} баллов", name, grade));
        }
        new public string ToString()
        {
            return String.Format(String.Format("Антилопу зовут {0}, её мясо на {1} баллов", name, grade));
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Doggy doggy = new Doggy();
            doggy.print();
            Kitten kitten = new Kitten("Бублик", 8);
            // ??++
            kitten.print();
            doggy = kitten;
            doggy.print();
            Antilope antilope = new Antilope("Бявлик", 'f');
            antilope.print();
            Console.WriteLine(antilope);
            doggy = antilope;
            doggy.print();
            Console.WriteLine(doggy);
            Antiloped antiloped = new Antiloped("Бявлик", 'f');
            antiloped.print();
            Console.WriteLine(antiloped);
            doggy = antiloped;
            doggy.print();
            Console.WriteLine(doggy);
        }
    }
}
