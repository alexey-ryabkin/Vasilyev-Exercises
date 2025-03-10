namespace Exercise10_08
{
    class DigitalNumber
    {
        public ulong _value;
        public DigitalNumber(ulong value)
        {
            _value = value;
        }
        public void p()
        {
            Console.WriteLine(this);
        }
        public override string ToString()
        {
            return "Исходное число = " + _value.ToString();
        }
        public virtual char this[int index]
        {
            set
            {
                ulong val = (ulong)value - 48;
                ulong cur = (ulong)this[index] - 48;
                for (int i = 0; i < index; i++)
                {
                    cur *= 10;
                    val *= 10;
                }
                _value = _value - cur + val;
            }
            get
            {
                ulong val = _value;
                for (int i = 0; i < index; i++)
                {
                    val /= 10;
                }
                val %= 10;
                char res = (char)(val + 48);
                return res;
            }
        }
    }
    class DigitalPair: DigitalNumber
    {
        public ulong _value;
        public DigitalPair(ulong value, ulong value2): base(value)
        {
            _value = value2;
        }
        public override string ToString()
        {
            return "Исходное число базы = " + base._value.ToString() + "\nИсходное число кринжа = " + _value.ToString();
        }
        public char this[int choice, int index]
        {
            get
            {
                ulong val;
                if (choice == 1) val = base._value;
                else val = _value;
                for (int i = 0; i < index; i++)
                {
                    val /= 10;
                }
                val %= 10;
                char res = (char)(val + 48);
                return res;
            }
        }
        public override char this[int index]
        {
            get
            {
                ulong val = _value + base._value;
                for (int i = 0; i < index; i++)
                {
                    val /= 10;
                }
                val %= 10;
                char res = (char)(val + 48);
                return res;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            DigitalNumber num = new DigitalNumber(10589);
            num.p();
            char a = num[1];
            num.p();
            Console.WriteLine("Применение индексатора не меняет значение числа.\n");

            char temp;
            for (int i = -10; i < 10; i++)
            {
                Console.Write(num[i]);
            }
            Console.WriteLine();
            num.p();
            for (int i = 5; i < 15; i++)
            {
                num[i] = (char)(i%10 + 48);
            }
            num.p();

            Console.WriteLine();

            DigitalPair pair = new DigitalPair(6543210, 101231456);
            pair.p();
            Console.WriteLine(pair[1,0]);
            Console.WriteLine(pair[1,2]);
            Console.WriteLine(pair[1,5]);
            Console.WriteLine(pair[0,1]);
            Console.WriteLine(pair[0,2]);
            Console.WriteLine(pair[0,5]);
            Console.WriteLine(pair._value + ((DigitalNumber)pair)._value);
            Console.WriteLine(pair[0]);
            Console.WriteLine(pair[1]);
            Console.WriteLine(pair[2]);
            Console.WriteLine(pair[3]);
        }
    }
}
