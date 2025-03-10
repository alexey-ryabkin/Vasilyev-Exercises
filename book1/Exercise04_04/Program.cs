namespace Exercise04_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int len = 10, counter = 'A' - 1;
            char[] chars = new char[len];
            bool success;

            for (int i = 0; i < chars.Length; i++)
            {
                success = false;
                while (!success)
                {
                    counter++;
                    if (counter != 'A' && counter != 'E' && counter != 'I') success = true;
                }

                chars[i] = (char) counter;
            }

            for (int i = 0; i < chars.Length; i++)
            {
                Console.Write("{0,2}", chars[i]);
            }
        }
    }
}
