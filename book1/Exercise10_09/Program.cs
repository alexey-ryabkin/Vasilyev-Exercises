using System.Numerics;
using System.Runtime.CompilerServices;

namespace Exercise10_09
{
    class Animal
    {
        protected string name;
        public Animal(string name) { this.name = name; }
        public virtual string Name
        {
            get { return name; }
            set { name = value; }
        }
        public override string ToString()
        {
            return String.Format("Экземпляр класса Animal по имени {0}", this.Name);
        }
    }
    class Human: Animal
    {
        protected string family_name;
        public Human(string name, string family_name): base(name)
        {
            this.family_name = family_name;
        }
        public Human(Animal animal): base(animal.Name)
        {
            family_name = "Животнович";
        }
        public override string Name
        {
            get 
            { 
                return String.Format("{0}— {1}", name, family_name); 
            }
            set
            {
                string[] strings = value.Split(null, 2);
                name = strings[0];
                if (strings.Length == 1) family_name = String.Empty;
                else family_name = strings[1];
            }
        }

        public override string ToString()
        {
            return String.Format("Экземпляр класса Human по имени {0}", this.Name);
        }
        /*
        public static explicit operator Human(Animal animal)
        {
            return new Human(animal.Name, "Животнович");
        }
        */
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal a, b = new Animal("Бобрик");
            Human c, d = new Human("Гжегож", "Бжеджешчикевич");
            Console.WriteLine(b);
            Console.WriteLine(d);
            Console.WriteLine(b.Name);
            Console.WriteLine(d.Name);
            b.Name = "Брыксик";
            d.Name = "Гжегош";
            Console.WriteLine(b);
            Console.WriteLine(d);
            d.Name = "Шога Иванович";
            Console.WriteLine(d);
            d.Name = "Шога Иванович Прусикин";
            Console.WriteLine(d);

            Console.WriteLine();

            a = d;
            c = new Human(b);

            Console.WriteLine(c);
            Console.WriteLine(a);
            Console.WriteLine(c.Name);
            Console.WriteLine(a.Name);
            c.Name = "Брыксик";
            a.Name = "Гжегош";
            Console.WriteLine(c);
            Console.WriteLine(a);
            a.Name = "Шога Иванович";
            Console.WriteLine(a);
            a.Name = "Шога Иванович Прусикин";
            Console.WriteLine(a);

        }
    }
}
