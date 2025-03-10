using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Exercise03_03
{
    struct Letters
    {
        private char[] letters;
        public Letters(string text)
        {
            letters = text.ToCharArray();
        }
        public Letters(int number, char letter)
        {
            letters = new string(letter, number).ToCharArray();
        }
        public char this[int index]
        {
            get
            {
                if (letters != null) return letters[index];
                else return (char)0;
            }
            set
            {
                if (letters != null) letters[index] = value;
            }
        }
        public void reverse0()
        {
            if (letters != null)
            {
                Array.Reverse(letters);
            }
        }
        public void reverse1()
        {
            if (letters != null)
            {
                int length = letters.Length;
                char[] temp = new char[length];
                for (int index = 0; index < length; index++)
                {
                    int reversed_index = length - 1 - index;
                    temp[index] = letters[reversed_index];
                }
                letters = temp;
            }
        }
        public override string ToString()
        {
            string output = "Объект Letters:";
            if (letters != null)
            {
                foreach (char letter in letters)
                {
                    output += string.Format("\n\'{0}\' с числовым кодом {1}", letter.ToString(), (int)letter);
                }
            }
            else
            {
                output += "\nПуст";
            }
                output += "\nКонец объекта.";
            return output;
        }
        public int Length => letters != null ? letters.Length : 0;
    }
    internal class Program
    {
        static void Test(Letters patient)
        {
            Console.WriteLine("Начало теста. —————————————————");
            Console.WriteLine(patient);
            Random rng = new Random();
            int index = rng.Next(patient.Length);
            char new_letter = (char)rng.Next(300);
            Console.WriteLine("Буква {0} заменена на {1}", patient[index], new_letter);
            patient[index] = new_letter;
            patient.reverse0();
            Console.WriteLine(patient);
            patient.reverse1();
            Console.WriteLine(patient);
            Console.WriteLine("Конец теста. ——————————————————");
        }
        static void Main(string[] args)
        {
            Letters a = new Letters();
            //Console.WriteLine("Привет"[6]); //System.IndexOutOfRangeException: "Index was outside the bounds of the array."
            Test(a);
            Letters b = new Letters("Я добрый морячок.");
            Letters c = new Letters(10, 'Ж');
            Test(b);
            Test(c);
        }
    }
}
