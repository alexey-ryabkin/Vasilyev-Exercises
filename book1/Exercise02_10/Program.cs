﻿namespace Exercise02_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte input, output;

            Console.WriteLine("Введите целое число");
            input = Byte.Parse(Console.ReadLine());
            output = (byte)(input & 2) == 0 ?(byte)(input | 2):(byte)(input & (255-2));
            Console.WriteLine(output);
            Console.WriteLine(Convert.ToString(input, 2));
            Console.WriteLine(Convert.ToString(output, 2));
        }
    }
}
