using System.Diagnostics;

namespace Exercise09_04
{
    class Oct
    {
        private int number;
        private string oct;
        public Oct()
        {
            Random rng = new Random();
            dec = rng.Next(100) + 1;
        }
        public int dec
        {
            set
            {
                oct = string.Empty;
                number = value;
                int quotient = value, remainder;
                do
                {
                    remainder = quotient % 8;
                    quotient = quotient / 8;
                    oct = remainder + oct;
                    /*Console.WriteLine("число: {0}\n" +
                        "неполное частное: {1}\n" +
                        "остаток: {2}\n" +
                        "текущее восьмеричное: {3}",
                        number, quotient, remainder, oct);
                    */
                }
                while (quotient > 0);
            }
        }

        public string octal
        {
            get
            {
                return oct;
            }
        }

        public override string ToString()
        {
            return number + "/10 = " + oct + "/8";
        }

        public static implicit operator Oct(int num)
        {
            Oct temp =  new Oct();
            temp.dec = num;
            return temp;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Oct obj = new Oct();
            for (int i = 0; i < 10;  i++)
            {
                obj = new Oct();
                Console.WriteLine(obj);
            }
            obj.dec = 16;
            Console.WriteLine(obj);
            obj = 16;
            Console.WriteLine(obj);
            obj = 7;
            Console.WriteLine(obj);
            obj = 9;
            Console.WriteLine(obj);
            obj = 24;
            Console.WriteLine(obj);
            obj.dec = 33;
            Console.WriteLine(obj);
        }
    }
}
