using System.Collections.Generic;

namespace Exercise07_05
{
    public class LinkedList<A>
    {
        public A Item;
        LinkedList<A>? _Next;
        public LinkedList(A[] items) 
        {
            Item = items[0];
            if (items.Length != 1)
            {
                A[] NextItems = new A[items.Length - 1];
                for (int i = 1; i < items.Length; i++)
                {
                    NextItems[i - 1] = items[i];
                }
                _Next = new LinkedList<A>(NextItems);
            }
            else _Next = null;
        }
        public override string ToString()
        {
            return Item.ToString();
        }
        public LinkedList<A>? Next => _Next;
        public void SetNext(LinkedList<A> item)
        {
            _Next = item;
        }
    }
    internal class Program
    {
        static void printLinkedList<A>(LinkedList<A> FirstItem)
        {
            LinkedList<A>? NextItem = FirstItem.Next;
            Console.Write(FirstItem);
            while (NextItem != null)
            {
                Console.Write(", {0}", NextItem);
                NextItem = NextItem.Next;
            }
            Console.WriteLine();
        }
        static void Set<A>(A[] items, LinkedList<A> LL)
        {
            for (int i = 0; i < items.Length; i++)
            {
                LL.Item = items[i];
                if (LL.Next == null && i != items.Length - 1)
                {
                    LinkedList<A> NewLL = new LinkedList<A>([items[i]]);
                    LL.SetNext(NewLL);
                }
                LL = LL.Next;
            }
        }
        static void Main(string[] args)
        {
            LinkedList<int> a = new LinkedList<int>([1, 2, 3, 4, 5, 6, 7, 8]);
            Console.WriteLine(a);
            printLinkedList(a);
            Set([10, 11, 12], a);
            printLinkedList(a);
            int[] b = new int[10];
            for (int i = 0; i < b.Length; i++)
            {
                b[i] = i;
            }
            Set(b, a);
            printLinkedList(a);
            // Exercise07_05.LinkedList<int> или что-то такое. Нет, забыл, что переопределил ToString
            // 1, 2, 3, 4, 5, 6, 7, 8
            // 10, 11, 12, 4, 5, 6, 7, 8
            // 0, 1, 2, 3, 4, 5, 6, 7, 8, 9
        }
    }
}
