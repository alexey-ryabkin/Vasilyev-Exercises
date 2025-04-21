using System.IO;

namespace Exercise09_06
{
    internal class Program
    {
        // args: путь к исходному файлу, путь к целевому файлу, который будет создан
        static void Main(string[] args)
        {
            string inputPath = "input.txt",
                outputPath = "output.txt";
            char? letter = null;

            if (args.Length >= 1) inputPath = args[0];
            if (args.Length >= 2) outputPath = args[1];

            try
            {
                FileStream inputFile = new FileStream(inputPath, FileMode.Open);
                StreamReader i = new StreamReader(inputFile);
                FileStream outputFile = new FileStream(outputPath, FileMode.CreateNew);
                StreamWriter o = new StreamWriter(outputFile);

                while (!i.EndOfStream)
                {
                    int l = i.Peek();
                    letter = (char)i.Read();
                    if (letter == ' ') letter = '_';
                    letter = Char.ToLower((char)letter);

                    o.Write(letter);
                }
                i.Close();
                o.Close();
                Console.WriteLine("Результат выполнения записан в файл " + outputPath);
            }
            catch(FileNotFoundException e)
            {
                Console.WriteLine("Файл не найден.");
            }
            catch(IOException e)
            {
                Console.WriteLine("Файл, который вы пытаетесь создать, уже существует. Я не буду перезаписывать то, что уже есть.");
            }
            catch(Exception e)
            {
                Console.WriteLine("К сожалению, произошна неизвестная ошибка.\n" + e.Message + "\n" + e.StackTrace + "\n");
            }
        }
    }
}
