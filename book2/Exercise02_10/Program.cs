namespace Exercise02_10
{
    internal delegate void DPrint(string text);
    internal class Person
    {
        private string _name;
        private DPrint _event;
        public Person(string name)
        {
            _name = name;
        }
        public event DPrint Grown
        {
            add
            {
                _event += value;
            }
            remove
            {
                _event -= value;
            }
        }
        public event DPrint Died;
        public void WaitShort()
        {
            if (_event is not null)
            {
                _event(_name);
            }
        }
        public void WaitLong()
        {
            if (Died is not null)
            {
                Died(_name);
            }
        }
    }
    class Printer
    {
        public void Pring(string text)
        {
            Console.WriteLine(text);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person a = new Person("George");
            Person b = new Person("Gregor");
            Printer p = new Printer();
            a.Grown += p.Pring;
            a.Died += p.Pring;
            b.Grown += p.Pring;
            b.Died += p.Pring;
            a.WaitShort();
            b.WaitShort();
            b.WaitLong();
            a.WaitLong();
        }
    }
}
