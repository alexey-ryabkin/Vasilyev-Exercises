namespace Exercise08_06
{
    class Number
    {
        public int a;

        public Number()
        {
            Random rng = new Random();
            a = rng.Next(15);
        }

        public static bool MyTrue (Number obj)
        {
            switch (obj.a)
            {
                case 2:
                case 3:
                case 5:
                case 7:
                    return true;
                default:
                    return false;
            }
        }

        public static bool operator true (Number obj)
        {
            return MyTrue (obj);
            /*
            switch (obj.a)
            {
                case 2:
                case 3:
                case 5:
                case 7:
                    return true;
                default:
                    return false;
            }
            */
        }

        public static bool MyFalse(Number obj)
        {
            if (obj.a < 1 || obj.a > 10) return true;
            else return false;
        }

        public static bool operator false (Number obj)
        {
            return MyFalse (obj);
            /*
            if (obj.a < 1 || obj.a > 10) return true;
            else return false;
            */
        }

        public static Number operator & (Number obj0, Number obj1)
        {
            if (obj0) return obj1;
            else return obj0;
        }

        public static Number operator | (Number obj0, Number obj1)
        {
            if (obj0) return obj0;
            else return obj1;
        }

        public override string ToString()
        {
            return a.ToString();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Number[] a = new Number[12];

            for (int i = 0; i < a.Length; i++)
            {
                a[i] = new Number();
                Console.WriteLine(a[i]);
            }

            for (int i = 0; i < a.Length - 1; i++)
            {
                Console.WriteLine("{0} ({3}, {4}) && {1} ({5}, {6}) = {2}", a[i], a[i + 1], a[i] && a[i + 1], Number.MyFalse(a[i]), Number.MyTrue(a[i]), Number.MyFalse(a[i + 1]), Number.MyTrue(a[i + 1]));
                Console.WriteLine("{0} ({3}, {4}) || {1} ({5}, {6}) = {2}", a[i], a[i + 1], a[i] || a[i + 1], Number.MyFalse(a[i]), Number.MyTrue(a[i]), Number.MyFalse(a[i + 1]), Number.MyTrue(a[i + 1]));
                
            }
        }
    }
}
