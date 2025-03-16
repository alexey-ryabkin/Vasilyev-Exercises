namespace Exercise04_06
{
    class MyClass
    {
        public int number;
    }
    unsafe internal class Program
    {
        static void Main(string[] args)
        {
            MyClass a = new MyClass();
            fixed(int* MCp = &a.number)
            {
                char* cp = (char*)MCp;
                *cp = 'A';
                cp[1] = 'B';
            }
            Console.WriteLine(a.number);
            Console.WriteLine(65 + 66 * 16*16*16*16);
        }
    }
}
