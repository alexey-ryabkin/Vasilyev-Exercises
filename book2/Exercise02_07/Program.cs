using System.Diagnostics;
using System.Runtime.ExceptionServices;
using System.Runtime.Serialization.Formatters;

namespace Exercise02_07
{
    internal delegate int Calculation(int number);
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] data = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] wrong_result0 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            int[] wrong_result1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 12 };
            int[] result = CalculateMethod(data, Add1);
            foreach (int num in result) Console.WriteLine(num);
            TestAdd1(data, result);
            //TestAdd1(data, wrong_result0);
            TestAdd1(data, wrong_result1);
        }
        static int Add1(int number)
        {
            return number + 1;
        }
        static int[] CalculateMethod(int[] input, Calculation method)
        {
            int l = input.Length;
            int[] result = new int[l];
            for (int i = 0; i < l; i++)
            {
                result[i] = method(input[i]);
            }
            return result;
        }
        static void TestAdd1(int[] input, int[] result)
        {
            if (input.Length != result.Length) throw new Exception("Длины списков различны");
            bool success = true;
            for (int i = 0; i < input.Length; i++)
            {
                int check = Add1(input[i]);
                if (result[i] != check)
                {
                    success = false;
                    Console.WriteLine("Тест не пройден!\nВвод: {0}\nРезультат: {1}\nДолжен быть: {2}", input[i], result[i], check);
                }
            }
            if (success) Console.WriteLine("Тест пройден успешно");
            else Console.WriteLine("Тест не пройден!");
        }
    }
}
