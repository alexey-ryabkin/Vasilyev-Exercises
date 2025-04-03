namespace Exercise07_08
{
    internal class Program
    {
        static void Describe<T>(T item)
        {
            //Type type = typeof(T);
            // Тоже работает, но в книжке пишут про GetType()
            // А вот switch case использовать не получилось, не очень понял, почему
            Type type = item.GetType();
            if (type == typeof(int)) Console.WriteLine("{0} Эт целое число", item);
            else if (type == typeof(char)) Console.WriteLine("\'{0}\' Эт буква", item);
            else Console.WriteLine("\"{0}\" Эт мы не проходили", item);
        }
        static void Main(string[] args)
        {
            Describe(5);
            Describe('5');
            Describe("5");
        }
    }
}
