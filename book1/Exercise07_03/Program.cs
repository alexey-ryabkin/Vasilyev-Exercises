namespace Exercise07_03
{
    internal class Program
    {
        static bool CompareStringsApprox(string arg1, string arg2)
        {
            Console.WriteLine("Сравниваются строки \"{0}\" и \"{1}\"", arg1, arg2);
            int l = arg1.Length;
            if (l != arg2.Length)
            {
                Console.WriteLine("Длина строк не равна");
                return false;
            }
            for (int i = 0; i <= l - 1; i++)
            {
                int codesDifference = arg1[i] - arg2[i];
                if (codesDifference > 1 || codesDifference < -1)
                {
                    Console.WriteLine("Неравны даже примерно символы \'{0}\' и '{1}'.", arg1[i], arg2[i]);
                    return false;
                }
            }
            return true;
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine(CompareStringsApprox("000", "001"));
            Console.WriteLine(CompareStringsApprox("000", "002"));
            Console.WriteLine(CompareStringsApprox("000", "501"));
            Console.WriteLine(CompareStringsApprox("БАТЯ", "батя"));
            Console.WriteLine(CompareStringsApprox("БВГ", "АБВ"));
            Console.WriteLine(CompareStringsApprox("БВГДЛИННОЕ", "АБВ"));
        }
    }
}
