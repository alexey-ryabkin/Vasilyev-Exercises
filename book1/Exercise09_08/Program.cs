using System.Globalization;
using System.Numerics;

namespace Exercise09_08
{
    class number
    {
        private ulong num;
        public number(ulong num)
        {
            this.num = num;
        }
        public int this[int index]
        {
            set
            {
                ulong digit = (ulong)(Math.Abs(value % 10));
                ulong power = 1;
                for (int i = 0; i < index; i++)
                {
                    power *= 10;
                }
                num = num / (10 * power) * (10 * power) + num % power + digit * power;
                /* 10948
                 * 43210
                 * % 10^index
                 * / 10^index + 1 * 10^index + 1 + % + value * 10^index
                 */
            }
        }
        public override string ToString()
        {
            return num.ToString();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            number a = new number(100);
            Console.WriteLine(a);
            a[2] = 155;
            Console.WriteLine(a);
            a[10] = 1001;
            Console.WriteLine(a);
            a[-5] = 9;
            Console.WriteLine(a);
            a[0] = 12;
            Console.WriteLine(a);
            a[1] = -13;
            Console.WriteLine(a);
        }
    }
}
