namespace Exercise05_08
{
    class CharExeption: ApplicationException
    {
        public char[] message;
        public CharExeption(int size)
        {
            message = new char[size];
            for (int i = 0; i < size; i++)
            {
                message[i] = (char)('A' + i);
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                throw new CharExeption(46);
            }
            catch (CharExeption e)
            {
                Console.WriteLine(e.message);
            }
        }
    }
}
