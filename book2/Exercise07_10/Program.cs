namespace Exercise07_10
{
    internal class TwoArrays<A, B> where B : IEquatable<B>
    {
        private A[] a;
        private B[] b;
        public TwoArrays(A[] a, B[] b)
        {
            int l = Math.Min(a.Length, b.Length);
            this.a = new A[l];
            this.b = new B[l];
            for (int i = 0; i < l; i++)
            {
                this.a[i] = a[i];
                this.b[i] = b[i];
            }
        }
        public A this[B publicIndex]
        {
            get
            {
                int privateIndex = Array.IndexOf(b, publicIndex);
                return a[privateIndex];
            }
            set 
            {
                if (this.ContainsIndex(publicIndex))
                {
                    int privateIndex = Array.IndexOf(b, publicIndex);
                    a[privateIndex] = value;
                }
                else
                {
                    this.Append(publicIndex, value);
                }
            }
        }
        public bool ContainsIndex(B publicIndex)
        {
            return Array.IndexOf(b, publicIndex) != -1;
        }
        public void Append(B publicIndex, A value)
        {
            int l = a.Length;
            A[] newA = new A[a.Length + 1];
            B[] newB = new B[a.Length + 1];
            for (int i = 0; i < l; i++)
            {
                newA[i] = a[i];
                newB[i] = b[i];
            }
            newA[l] = value;
            newB[l] = publicIndex;
            a = newA;
            b = newB;
        }
        public void Delete(B publicIndex)
        {
            int count = 0;
            int l = a.Length;
            for (int i = 0; i < l; i++)
            {
                if (b[i].Equals(publicIndex)) count++;
            }
            A[] newA = new A[a.Length - count];
            B[] newB = new B[a.Length - count];
            int diff = 0;
            for (int i = 0; i < l; i++)
            {
                if (b[i].Equals(publicIndex)) diff++;
                else
                {
                    newA[i - diff] = a[i];
                    newB[i - diff] = b[i];
                }
            }
            a = newA;
            b = newB;
        }
        public override string ToString()
        {
            string text = string.Empty;
            for (int i = 0; i < a.Length - 1; i++)
            {
                text += string.Format("{0, 8}{1, 8}\n", a[i], b[i]);
            }
            text += string.Format("{0, 8}{1, 8}", a[a.Length - 1], b[a.Length - 1]);
            return text;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = new int[15];
            char[] chars = new char[15];
            Random rng = new Random();
            for (int i = 0; i < ints.Length; i++)
            {
                //ints[i] = rng.Next(15);
                ints[i] = i + 100;
                chars[i] = (char)('k' + rng.Next(5));
                Console.WriteLine("{0, 8}{1, 8}", ints[i], chars[i]);
            }
            Console.WriteLine("—————————————————————————————");
            TwoArrays<char, int> ta = new TwoArrays<char, int>(chars, ints);
            Console.WriteLine(ta);
            Console.WriteLine("—————————————————————————————");
            ta[100] = 'Ж';
            ta[101] = 'А';
            ta[102] = 'Р';
            ta[103] = 'Р';
            Console.WriteLine(ta);
            Console.WriteLine("—————————————————————————————");
            Console.WriteLine("" + ta[100] + ta[101] + ta[102]);
            Console.WriteLine("—————————————————————————————");
            Console.WriteLine("—————————————————————————————");
            //Console.Clear();
            ta.Append(148, 'Р');
            ta[149] = 'Ж';
            ta.Append(148, 'Р');
            ta.Append(148, 'Р');
            ta.Append(148, 'Р');
            ta.Append(148, 'Р');
            ta.Append(148, 'Р');
            Console.WriteLine(ta);
            Console.WriteLine("—————————————————————————————");
            ta.Delete(148);
            Console.WriteLine(ta);
            Console.WriteLine("—————————————————————————————");
            // Это было интересно
        }
    }
}
