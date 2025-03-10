using System.Drawing;
using System.Runtime.Serialization.Formatters;
using System.Security.Cryptography;

namespace Exercise09_02
{
    class MyClass
    {
        private int[] nums;
        private int current_index = 0;

        public MyClass(int size)
        {
            Random rng = new Random();

            this.nums = new int[size];
            for (int i = 0; i < size; i++)
            {
                this.nums[i] = rng.Next(100);
            }
        }

        public MyClass()
        {
            Random rng = new Random();
            int size = rng.Next(20);

            this.nums = new int[size];
            for (int i = 0; i < size; i++)
            {
                this.nums[i] = rng.Next(100);
            }
        }

        public int numbers
        {
            get
            {
                current_index++;
                int value = nums[(current_index - 1)];
                current_index %= nums.Length;
                return value;
            }

            set
            {
                nums[current_index] = value;
            }
        }

        public override string ToString()
        {
            string output = string.Empty;
            output += "Текущий индекс: " + current_index + ".\n";
            output += "Массив:\n";
            for (int i = 0; i < nums.Length; i++)
            {
                output += i;
                if (i != nums.Length - 1)
                {
                    int tab = 1 + nums[i].ToString().Length - i.ToString().Length;
                    output += new string(' ', tab);
                }
            }
            output += "\n";
            output += nums[0];
            for (int i = 1; i < nums.Length; i++)
                {
                    output += " " + nums[i].ToString();
                }

            return output;
        }

        public void p()
        {
            Console.WriteLine(this);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass a = new MyClass();
            a.p();
            for (int i = 0; i < 10;i++)
            {
                Console.WriteLine(a.numbers);
            }
            a.p();
            a.numbers = 69;
            a.p();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(a.numbers);
            }
            a.p();
            a.numbers = 69;
            a.p();
        }
    }
}
