namespace Exercise03_07
{
    struct Letter
    {
        private char letter;
        public Letter(char letter)
        {
            this.letter = letter;
        }
        public override string ToString()
        {
            return letter.ToString();
        }

        public static Letter[] Letterize(string text)
        {
            int l = text.Length,
                i = 0;
            Letter[] letters = new Letter[l];
            foreach (char letter in text)
            {
                letters[i] = new Letter(letter);
                i++;
            }
            return letters;
        }
        public static string Deletterize(Letter[] letters)
        {
            string text = string.Empty;
            foreach (Letter letter in letters)
            {
                text += letter;// ToString()?? Я не прописывал type conversion.
            }
            return text;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Letter.Letterize("abc")); // мой тип
            Console.WriteLine(Letter.Letterize("abc")[0]); // a
            Console.WriteLine(Letter.Deletterize(Letter.Letterize("Привет!"))); // Привет
        }
    }
}
