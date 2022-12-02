/* Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец,
 на пересечении которых расположен наименьший элемент массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Наименьший элемент - 1, на выходе получим 
следующий массив:
9 4 2
2 2 6
3 4 7*/

using static System.Console;
Clear();

int[,] GetArray(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(0); j++)
        {
            result[i, j] = new Random().Next(1, 10);
        }
    }
    return result;
}


void PrintArray(int[,] printArray)
{
    for (int i = 0; i < printArray.GetLength(0); i++)
    {
        for (int j = 0; j < printArray.GetLength(1); j++)
        {
            Write($"{printArray[i, j]}\t ");
        }
        WriteLine();
    }
}

int[,] myArray = GetArray(4, 4);
PrintArray(myArray);

int indexRow = 0,
    indexCol = 0,
    min = myArray[0, 0];
for (int i = 0; i < myArray.GetLength(0); i++)
    for (int j = 0; j < myArray.GetLength(1); j++)
    {
        if (myArray[i, j] < min)
        {
            min = myArray[i, j];
            indexRow = i;
            indexCol = j;
        }

    }
int[,] newArray = new int[myArray.GetLength(0) - 1, myArray.GetLength(1) - 1];
int a = 0,
    b = 0;
for (int i = 0; i < newArray.GetLength(0); i++)
    for (int j = 0; j < newArray.GetLength(1); j++)
    {
        if (indexRow >= i)
            a = 1;
        else
            a = 0;
        if (indexCol >= j)
            b = 1;
        else
            b = 0;
        newArray[i, j] = myArray[i + a, j + b];
    }
WriteLine();
PrintArray(newArray);