namespace Exercise01_08
{
    interface IName { string Name { get; } }
    interface ISurname { string Name { get; } }
    class Employee: IName, ISurname
    {
        private string _name, _surname;
        public Employee(string name, string surname)
        {
            _name = name;
            _surname = surname;
        }
        public string Name
        {
            get
            {
                return String.Format("Сотрудник по имени {0} по фамилии {1}", _name, _surname);
            }
        }
        string IName.Name
        {
            get
            {
                return String.Format("Сотрудник по имени {0}", _name);
            }
        }
        string ISurname.Name
        {
            get
            {
                return String.Format("Сотрудник по фамилии {1}", _name, _surname);
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Test("Валера","Шишипов");
        }
        static void p(string msg)
        {
            Console.WriteLine(msg);
        }
        static int Test(string name, string surname)
        {
            Employee e = new Employee(name, surname);
            IName n = e;
            ISurname s = e;
            p("Employee: " + e.Name);
            p("IName: " + n.Name);
            p("ISurname: " + s.Name);
            p("");
            return 1;
        }
    }
}
