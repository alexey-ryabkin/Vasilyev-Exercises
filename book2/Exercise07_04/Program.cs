namespace Exercise07_04
{
    internal class ArrayWrapper<T>
    {
        private T[] values;
        public ArrayWrapper(T[] values)
        {
            this.values = values;
        }
        public T this[int index]
        {
            get
            {
                return values[index];
            }
            set
            {
                values[index] = value;
            }
        }
        public override string ToString()
        {
            string output = string.Empty;
            if (values.Length != 0) output += values[0].ToString();
            for (int i = 1; i < values.Length; i++)
            {
                output += ", " + values[i];
            }
            return output;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayWrapper<int> a = new ArrayWrapper<int>([ 1, 2, 3, 4 ]);
            ArrayWrapper<string> b = new ArrayWrapper<string>([ "0", "1", "", "2", "4" ]);
            Console.WriteLine(a);
            Console.WriteLine(a[2]);
            Console.WriteLine(b);
            Console.WriteLine(b[0]);
            a[2] = 10;
            b[0] = "15";
            Console.WriteLine(a);
            Console.WriteLine(a[2]);
            Console.WriteLine(b);
            Console.WriteLine(b[0]);
            /* 1, 2, 3, 4
             * 3
             * 0, 1, , 2, 4
             * 0
             * 1, 2, 10, 4
             * 10
             * 15, 1, , 2, 4
             * 15
             */ 

        }
    }
}
