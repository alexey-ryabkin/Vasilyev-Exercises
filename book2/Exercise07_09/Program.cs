namespace Exercise07_09
{
    public class WrappingArray<T>
    {
        T[] array;
        public WrappingArray(T[] array) { this.array = array; }
        public static WrappingArray<T> operator + (WrappingArray<T> first, WrappingArray<T> second)
        {
            T[] array = new T[first.array.Length + second.array.Length];
            int i = 0;
            foreach (T item in first.array) array[i++] = item;
            foreach (T item in second.array) array[i++] = item;
            return new WrappingArray<T> (array);
        }
        public override string ToString()
        {
            string a = string.Empty;
            foreach (T item in array) a += item + " ";
            return a;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] a = new int[random.Next(8)];
            int[] b = new int[random.Next(4)];
            for (int i = 0; i < a.Length; i++) a[i] = random.Next(100);
            for (int i = 0; i < b.Length; i++) b[i] = random.Next(100);
            WrappingArray<int> A = new WrappingArray<int>(a);
            WrappingArray<int> B = new WrappingArray<int>(b);
            Console.WriteLine(A);
            Console.WriteLine(B);
            Console.WriteLine(A + B);
        }
    }
}
