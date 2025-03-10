namespace Exercise07_04
{
    internal class Program
    {
        // Можно было бы просто сделать .Contains() на каждую букву
        // из каждого аргумента на соседний аргумент,
        // но в задании явно сказано определить наборы букв и сравнить их.
        // Но я не умею сортировать наборы букв...
        // Ладно, научился
        // Wrong тоже работает
        static bool CompareLettersUsedWrong(string arg1, string arg2)
        {
            Console.WriteLine("Сравниваются строки \"{0}\" и \"{1}\"", arg1, arg2);
            foreach (char c in arg1)
            {
                if (!arg2.Contains(c))
                {
                    Console.WriteLine("Во втором аргументе нет буквы {0} из первого аргумента", c);
                    return false;
                }
            }
            foreach (char c in arg2)
            {
                if (!arg1.Contains(c))
                {
                    Console.WriteLine("В первом аргументе нет буквы {0} из второго аргумента", c);
                    return false;
                }
            }
            Console.WriteLine("Наборы букв в строках равны.");
            return true;
        }
        static bool CompareLettersUsed(string arg1, string arg2)
        {
            Console.WriteLine("Сравниваются строки \"{0}\" и \"{1}\"", arg1, arg2);
            char[] letters1 = { }, letters2 = { };
            // Создание наборов букв
            foreach (char letter in arg1)
            {
                // Если в наборе ещё нет соответствующей буквы
                if (!letters1.Contains(letter))
                {
                    char[] temp = new char[letters1.Length + 1];
                    for (int i = 0; i < letters1.Length; i++)
                    {
                        temp[i] = letters1[i];
                    }
                    temp[temp.Length - 1] = letter;
                    letters1 = temp;
                }
            }
            foreach (char letter in arg2)
            {
                // Если в наборе ещё нет соответствующей буквы
                if (!letters2.Contains(letter))
                {
                    char[] temp = new char[letters2.Length + 1];
                    for (int i = 0; i < letters2.Length; i++)
                    {
                        temp[i] = letters2[i];
                    }
                    temp[temp.Length - 1] = letter;
                    letters2 = temp;
                }
            }
            // Сортировка наборов, чтобы их можно было сравнить
            Array.Sort(letters1);
            Array.Sort(letters2);
            // Перевод наборов в строку, чтобы их можно было сравнить не поэлементно.
            // Можно было бы сравнить и поэлементно.
            string 
                strLetters1 = new string(letters1), 
                strLetters2 = new string(letters2);
            bool test = strLetters1 == strLetters2;
            if (test)
            {
                Console.WriteLine("Наборы букв в строках равны.\n{0}", strLetters1);
                return true;
            }
            else
            {
                Console.WriteLine("Наборы букв в строках не равны\n{0}\n{1}", strLetters1, strLetters2);
                return false;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(CompareLettersUsed("Hello, World!", "!dlroW ,eH"));
            CompareLettersUsed("Hello, World!", "!dlroW ,eH1");
            CompareLettersUsed("Hello, World!1", "!dlroW ,eH1");
            CompareLettersUsed("Hello, World!12", "!dlroW ,eH1");
            CompareLettersUsed("H", "");
            CompareLettersUsed("", "");
            CompareLettersUsed("", "р");
        }
    }
}
