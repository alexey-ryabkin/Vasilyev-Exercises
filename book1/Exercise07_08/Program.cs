namespace Exercise07_08
{
    class MyString
    {
        private string text;
        public MyString(string s = "Default")
        {
            this.text = s;
        }

        public void Insert(int index, string text)
        {
            try
            {
                this.text = this.text.Insert(index, text);
            }
            catch
            {
                Console.WriteLine("Заданный индекс находится вне допустимого диапазона.");
            }
        }

        public override string ToString()
        {
            return this.text;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyString obj = new MyString("0123456789");
            Console.WriteLine(obj);
            obj.Insert(5,"_56789_"); 
            Console.WriteLine(obj);
            obj.Insert(-5,"_56789_");
            Console.WriteLine(obj);
            obj.Insert(50,"_56789_");
            Console.WriteLine(obj);
            obj.Insert(5,"");
            Console.WriteLine(obj);
        }
    }
}
