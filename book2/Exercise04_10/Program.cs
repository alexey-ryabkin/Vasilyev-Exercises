namespace Exercise04_10
{
    unsafe internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            char* p;
            char** pp;
            pp = &p;
            p = (char*)&number;
            (*pp)[0] = 'A';
            (*pp)[1] = 'B';

            Console.WriteLine(number);
            Console.WriteLine(65 + 66*256*256);
        }
    }
}
