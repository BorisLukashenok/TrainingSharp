// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

using static System.Console;
Clear();

Random rnd = new Random();

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = rnd.Next(100);
}

void PrintArray(int[,] printArray)
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

void PrintArithmeticMeanColumnInColumns(int[,] array)
{
    int sumColumn = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sumColumn += array[j, i];
        }
        Write($"{Math.Round((double)sumColumn / array.GetLength(0), 2)} \t");
        sumColumn = 0;
    }
}

int[,] myArray = new int[rnd.Next(2, 10), rnd.Next(2, 10)];
FillArray(myArray);
PrintArray(myArray);
WriteLine("Среднее арифметическое по столбцам.");
PrintArithmeticMeanColumnInColumns(myArray);
