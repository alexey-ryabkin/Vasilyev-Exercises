using System.Drawing;

namespace Exercise06_05
{
    class Data
    {
        public int[] nums;
        public char[] chars;
        public Data()
        {
            Random rng = new Random();
            int size = rng.Next(10, 20);
            nums = new int[size];
            chars = new char[size];
            for (int i = 0; i < size; i++)
            {
                nums[i] = 0;
                chars[i] = '0';
            }
        }
        public override string ToString()
        {
            string textNums = nums[0].ToString(),
                   textChars = chars[0].ToString();
            for (int i = 0; i < nums.Length; i++)
            {
                textNums += " " + string.Format("{0, 2}",nums[i].ToString());
                textChars += " " + string.Format("{0, 2}", chars[i].ToString());
            }
            return textNums + "\n" + textChars + "\n";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Data obj = new Data();
            Random rng = new Random();
            Thread numsFiller = new Thread(() =>
            {
                for (int i = 0; i < obj.nums.Length; i++)
                {
                    obj.nums[i] = rng.Next(100);
                    Console.WriteLine(obj);
                    Thread.Sleep(200);
                }
            });
            Thread charsFiller = new Thread(() =>
            {
                for (int i = 0; i < obj.chars.Length; i++)
                {
                    obj.chars[i] = (char)('A' + rng.Next(53));
                    Console.WriteLine(obj);
                    Thread.Sleep(180);
                }
            });
            numsFiller.Start();
            charsFiller.Start();
            numsFiller.Join();
            Console.WriteLine("Готово");
        }
    }
}
