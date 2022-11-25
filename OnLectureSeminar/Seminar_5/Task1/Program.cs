// Задайте массив из 12 элементов, заполненный случайными числами
// из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
using static System.Console;
Clear();


int[] array = new int[12];
Random numbers = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = numbers.Next(-9, 9);
    Console.Write($"{array[i]} ");
}
int sum_of_max = 0;
int sum_of_min = 0;
for (int j = 0; j < array.Length; j++)
{
    if (array[j] > 0)
        sum_of_max += array[j];
    else if (array[j] < 0)
        sum_of_min += array[j];
}
Console.WriteLine($"{sum_of_max} {sum_of_min}");
