// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

using static System.Console;
Clear();

void InputArray(int[] array)
{
    for (int i = 1; i <= array.Length; i++)
    {
        Write($"Введите {i} число: ");
        array[i-1] = int.Parse(ReadLine()!);
    }

}

int DiffersFrom(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] > 0)
            count++;
    return count;
}

int numberOfNumbers = new Random().Next(1, 8);
int[] numbers = new int[numberOfNumbers];

WriteLine($"Введите {numberOfNumbers} {numberOfNumbers switch
{
    1 => "целое число.",
    > 1 and < 5 => "целых числа.",
    _ => "целых чисел."
}}");

InputArray(numbers);
WriteLine($"Чисел больше 0: {DiffersFrom(numbers)}");