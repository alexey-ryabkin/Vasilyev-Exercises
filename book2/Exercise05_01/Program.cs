string? input;
uint? size = null;
int[] nums;

Console.Write("Введите длину последовательности натуральных чисел: ");
while (size == null)
{
    input = Console.ReadLine();
    try
    {
        size = UInt32.Parse(input);
    }
    catch (FormatException e)
    {
        Console.Write("Вы ввели не число. Произошла ошибка {0} Попробуйте ещё раз: ", e.GetType().Name);
    }
    catch
    {
        Console.WriteLine("Произошла поправимая ошибка.");
    }
}
nums = new int[(int)size];
for (int i = 0; i < size; i++)
{
    nums[i] = i + 1;
}
for (int i = 0; i < size; i++)
{
    Console.Write("/ " + nums[i] + " ");
}
Console.WriteLine("/");

int index = 1;
try
{
    while (true)
    {
        nums[index - 1] = index;
        Console.Write("/ " + nums[index - 1] + " ");
        index++;
    }
}
catch
{
    Console.WriteLine("/");
}