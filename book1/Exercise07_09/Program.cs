namespace Exercise07_09
{
    class MyClass
    {
        string myString;
        char myChar;

        public MyClass(string myString, char myChar)
        {
            this.myString = myString;
            this.myChar = myChar;
        }

        public string[] GetSplitted()
        {
            return myString.Split(myChar);
        }

        public override string ToString()
        {
            return "Строка: \"" + myString + "\"\nСимвол-разделитель: '" + myChar + "'";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass a = new MyClass("Большое предложение", 'о');
            Console.WriteLine(a);
            foreach (string b in a.GetSplitted())
            {
                Console.WriteLine(b);
            }
        }
    }
}
