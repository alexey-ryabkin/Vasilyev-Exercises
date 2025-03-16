namespace Exercise04_05
{
    unsafe internal class Program
    {
        struct MyStr
        {
            public char letter;
            public int number;
            public void show()
            {
                Console.WriteLine("{0}, {1}", letter, number);
            }
        }
        static void Main(string[] args)
        {
            MyStr MyStr;
            MyStr* MyStrP = &MyStr;
            (*MyStrP).letter = 'B';
            MyStrP -> number = 69;
            MyStrP->show();
        }
    }
}
