// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

using static System.Console;
Clear();

Random rnd = new Random();

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = rnd.Next(10);
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Write($"{array[i, j]} \t");
        WriteLine();
    }
}


int[,] myArray = new int[rnd.Next(2, 5), rnd.Next(2, 5)];
FillArray(myArray);
PrintArray(myArray);
WriteLine();
int sumRow = 0,
    rowMinSum = Int32.MaxValue,
    indexRowMinSum = 0;
for (int i = 0; i < myArray.GetLength(0); i++)
{
    for (int j = 0; j < myArray.GetLength(1); j++)
        sumRow += myArray[i, j];
    if (sumRow < rowMinSum)
    {
        rowMinSum = sumRow;
        indexRowMinSum = i;
    }
    sumRow = 0;
}
WriteLine($"В {indexRowMinSum + 1} строке минимальная сумма.");
