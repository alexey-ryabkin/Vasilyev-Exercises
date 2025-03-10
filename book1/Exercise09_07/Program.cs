namespace Exercise09_07
{
    class Bit
    {
        uint n;
        public Bit(uint n)
        {
            this.n = n;
        }

        public uint this[int m]
        {
            get
            {
                // Сдвиг вправо на нужное количество битов
                uint temp = this.n >> m - 1;
                // 19 = 10011
                //      54321
                //      11111
                //      00001
                // Очистка всех битов, кроме одного
                temp = temp & 1;

                return temp;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Bit a = new Bit(1000);
            for (int i = 1; i < 20; i++)
            {
                Console.WriteLine(a[i]);
            }
        }
    }
}
