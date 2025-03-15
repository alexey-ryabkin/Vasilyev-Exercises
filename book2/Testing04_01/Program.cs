namespace Testing04_01
{
    internal class Program
    {
        struct Struc
        {
            int a, b, c;
            //int[] d; // cs8500, но выдаёт 24 вместо 12
        }
        class Nums
        {
            public static byte deaths = 0;
            public int nums;
            public Nums(int nums)
            {
                this.nums = nums;
            }
            ~Nums()
            {
                deaths++;
                Console.WriteLine("Был убит объект Nums {0} {1}", nums, this);
            }
        }
        unsafe static void Main(string[] args)
        {
            int number = 10;
            int* pointer = &number;
            Console.WriteLine((byte)pointer);
            Console.WriteLine((int)pointer);
            Console.WriteLine("int: {0}, char: {1}, byte: {2}, double: {3}, Struc: {4} = {5}, bool: {6}",
                sizeof(int),
                sizeof(char),
                sizeof(byte),
                sizeof(double),
                sizeof(Struc),
                sizeof(int) * 3,
                sizeof(bool)
            );
            double frac;
            double* fracpointer = &frac;
            byte* bytepointerlow = (byte*)fracpointer;
            byte* bytepointerhigh = bytepointerlow + 4;
            int* intpointerlow = (int*)fracpointer;
            int* intpointerhigh = (int*)bytepointerhigh;
            Console.WriteLine("{0} = {1}", intpointerhigh - intpointerlow, 1);
            bytepointerhigh = bytepointerlow + 3;
            intpointerhigh = (int*)bytepointerhigh;
            Console.WriteLine("{0} = {1}", (double)(intpointerhigh - intpointerlow), 0.75);
            Console.WriteLine("{0} = {1}", (double)(intpointerlow - intpointerhigh), -0.75);
            Console.WriteLine("{0} = {1}", (uint)intpointerhigh - (uint)intpointerlow, 3);
            // Видимо, результат вычитания указателей — int, а int не может быть дробным, поэтому обрезается до целого числа

            fixed(int* classpointer = &new Nums(10).nums) // Гарантированный деструктор? Не гарантирован даже в fixed
            {
                Nums unit = new Nums(11); // Негарантированный деструктор
                new Nums(12); // Негарантированный деструктор
            }
            int i = 0;
            while (Nums.deaths == 0) //300000
            //while (i < 1000000) //143
            {
                new Nums(i);
                i++;
            }
            Console.WriteLine("Всего было создано {0} объектов и вызвано {1} деструкторов", i, Nums.deaths);

            int a = 4;
            int* pointera = &a;
            (*pointera) *= (*pointera);
            *pointera *= *pointera;
            * pointera *= * pointera;
            // Скобки у Васильева, видимо, для понимания
            Console.WriteLine(a);

            string b = "abc";
            //b[0] = 'd'; //Доступ только для чтения, а я думал, что уже использовал такое. Видимо, создавал новый экземпляр

        }
    }
}
