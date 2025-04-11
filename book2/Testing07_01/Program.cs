namespace Testing07_01
{
    internal delegate void IntegerDelegate(int a);
    internal delegate ReturnedType GenericDelegate<ReturnedType, InputType> (InputType a);
    internal class Program
    {
        static void Method0(int a)
        {
            Console.WriteLine(a);
        }
        static void Main(string[] args)
        {
            IntegerDelegate del0 = new IntegerDelegate(Method0);
            GenericDelegate<void, int> del1 = new GenericDelegate<void, int>(Method0); // NOPE
        }
    }
}
