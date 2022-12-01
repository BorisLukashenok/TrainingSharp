// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
using static System.Console;
Clear();

Random rnd = new Random();

void FillArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = Math.Round(rnd.Next(-99, 100) + rnd.NextDouble(), 2);
}

void PrintArray(double[,] printArray)
{
    for (int i = 0; i < printArray.GetLength(0); i++)
    {
        for (int j = 0; j < printArray.GetLength(1); j++)
        {
            Write($"{printArray[i, j]} \t");
        }
        WriteLine();
    }
}

double[,] myArray = new double[rnd.Next(2, 10), rnd.Next(2, 10)];
FillArray(myArray);
PrintArray(myArray);
