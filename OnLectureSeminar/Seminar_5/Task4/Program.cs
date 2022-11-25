// Задайте одномерный массив из 123 случайных чисел. 
//Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// 

using static System.Console;
Clear();

int[] array = new int[123];
for (int i = 0; i < 123; i++)
{
    array[i] = new Random().Next(1, 150);
}
for (int i = 0; i < 123; i++)
{
    Write(array[i]+" ");
}
WriteLine();
int count = 0;
for (int i = 0; i < 123; ++i)
{
    if (array[i] >= 10 && array[i] < 100)
        count += 1;
}
WriteLine(count);