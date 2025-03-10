namespace Exercise08_04
{
    class Person
    {
        public int number;
        public string name;
        private static int current_num;
        private static string[] names = {"Lorem","Ipsum","Dolores","Joana","Pipsum","Вупсень","Пупсень"};

        public Person()
        {
            current_num++;
            number = current_num;
            name = names[number % names.Length];
        }

        public static bool operator > (Person obj0, Person obj1)
        {
            return obj0.name.Length > obj1.name.Length;
        }

        public static bool operator < (Person obj0, Person obj1)
        {
            return obj1 > obj0;
        }

        public static bool operator >= (Person obj0, Person obj1)
        {
            return obj0.number >= obj1.number;
        }

        public static bool operator <= (Person obj0, Person obj1)
        {
            return obj1 >= obj0;
        }

        public static bool operator == (Person obj0, Person obj1)
        {
            return obj0.number == obj1.number && obj0.name == obj1.name;
        }

        public static bool operator != (Person obj0, Person obj1)
        {
            return !(obj0 == obj1);
        }

        public override bool Equals(object obj)
        {
            Person person = obj as Person;
            return this == person;
        }

        public override int GetHashCode()
        {
            return number + name.Length;
        }

        public override string ToString()
        {
            return "Человек №" + this.number.ToString() + " по имени " + this.name;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] a = new Person[15];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = new Person();
                Console.WriteLine(a[i].ToString());
            }

            for (int i = 0; i < a.Length - 1; i++)
            {
                Console.WriteLine("{0} < {1} = {2}", a[i], a[i + 1], a[i] < a[i + 1]);
                Console.WriteLine("{0} > {1} = {2}", a[i], a[i + 1], a[i] > a[i + 1]);
                Console.WriteLine("{0} <= {1} = {2}", a[i], a[i + 1], a[i] <= a[i + 1]);
                Console.WriteLine("{0} >= {1} = {2}", a[i], a[i + 1], a[i] >= a[i + 1]);
                Console.WriteLine("{0} == {1} = {2}", a[i], a[i + 1], a[i] == a[i + 1]);
                Console.WriteLine("{0} != {1} = {2}", a[i], a[i + 1], a[i] != a[i + 1]);
                Console.WriteLine("{0}.Equals({1}) = {2}", a[i], a[i + 1], a[i].Equals(a[i + 1]));
                Console.WriteLine("{0} Hash = {1}", a[i], a[i].GetHashCode());
            }
        }
    }
}
