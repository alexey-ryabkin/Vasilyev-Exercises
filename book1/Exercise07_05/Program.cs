namespace Exercise07_05
{
    internal class Program
    {
        // Вспомогательный метод, чтобы не писать это каждый раз
        static int[] Add(int[] input, int num)
        {
            int[] result = new int[input.Length + 1];
            for (int i = 0; i <= input.Length - 1; i++) result[i] = input[i];
            result[input.Length] = num;
            return result;
        }
        static int[] GetCharPos(string text, char letter)
        {
            int[] indexes = new int[0];
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == letter) indexes = Add(indexes, i);
            }
            // Если буквы в тексте не обнаружены, нужно вернуть массив из -1
            if (indexes.Length == 0) return new int[1] {-1};
            else return indexes;
        }
        static void PrintArray(int[] array)
        {
            string output = "";
            for (int i = 0; i <= array.Length - 2; i++)
            {
                output += array[i] + ", ";
            }
            output += array[array.Length - 1];
            Console.WriteLine(output);
        }
        static void PrintStringIndexes(string input)
        {
            string output, numbers;
            output = numbers = "";
            for (int i = 0; i < input.Length; i++)
            {
                if (output.Length + i.ToString().Length > 80)
                {
                    Console.WriteLine(numbers);
                    Console.WriteLine(output);
                    output = "";
                    numbers = "";
                }
                output += input[i] + new string(' ', i.ToString().Length);
                numbers += i + " ";

            }
            Console.WriteLine(numbers);
            Console.WriteLine(output);
        }
        static void Main(string[] args)
        {
            string str = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam ut suscipit magna. Sed imperdiet, massa congue blandit maximus, ante leo iaculis mi, sed vulputate mi erat et orci. Fusce vehicula bibendum elit nec molestie. Phasellus ac est vel enim tempus dignissim. Nam ullamcorper arcu a ornare semper. Proin congue imperdiet sollicitudin. Aliquam sed ligula pretium, rhoncus ipsum tincidunt, facilisis diam.";
            PrintStringIndexes(str);
            PrintArray(GetCharPos(str, 'o'));
            PrintArray(GetCharPos(str, 'e'));
            PrintArray(GetCharPos(str, '!'));
            PrintArray(GetCharPos(str, '2'));
        }
    }
}
