namespace Exercise07_06
{
    internal class Program
    {
        static char[] GetUniqueLetters(string input)
        {
            string UL = "";
            foreach (char letter in input)
            {
                if (Char.IsLetterOrDigit(letter))
                {
                    bool notdone = true;
                    int i = 0;
                    while (notdone)
                    {
                        if (i == UL.Length)
                        {
                            UL = UL.Insert(i, letter.ToString());
                            notdone = false;

                        }
                        else if (UL[i] > letter)
                        {
                            UL = UL.Insert(i, letter.ToString());
                            notdone = false;
                        }
                        else if (UL[i] == letter)
                        {
                            notdone = false;
                        }
                        i++;
                    }
                }
            }
            return UL.ToCharArray();
        }
        /*
        static char[] GetUniqueLetters(string input)
        {
            char[] UL = new char[0];
            foreach (char letter in input)
            {
                bool a = Char.IsLetterOrDigit(letter);
                bool b = UL.Contains(letter);
                if (a && !b)
                {
                    bool inserted = false;
                    char[] temp = new char[UL.Length + 1];
                    if (UL.Length == 0)
                    {

                    }
                    for (int i = 0; i <= UL.Length - 1; i++)
                    {
                        if (letter > UL[i])
                        {
                            temp[i] = UL[i];
                        }
                        else
                        {
                            if (!inserted)
                            {
                                inserted = true;
                                temp[i] = letter;
                                temp[i + 1] = UL[1];
                            }
                            else
                            {
                                temp[i + 1] = UL[i];
                            }
                        }
                    }
                }
            }
            // Сделал в цикле, так как Васильев меня сортировке пока не учил
            // Array.Sort(UL);
            return UL;
        }
        */
        static void Main(string[] args)
        {
            Console.WriteLine(GetUniqueLetters("Hello, World!!"));
            Console.WriteLine(GetUniqueLetters("aaaaaaaaaabbbbzzzzzzzzzzcccccccc44587956,,::?:;,  ;;,    \\\\\\"));
        }
    }
}
