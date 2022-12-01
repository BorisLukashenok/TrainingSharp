// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию
// элементы каждой строки двумерного массива.

using static System.Console;
Clear();

Random rnd = new Random();

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = rnd.Next(100);
}

void PrintArray(int[,] myArray)
{
    for (int i = 0; i < myArray.GetLength(0); i++)
    {
        for (int j = 0; j < myArray.GetLength(1); j++)
            Write($"{myArray[i, j]} \t");
        WriteLine();
    }
}


int[,] myArray = new int[rnd.Next(2, 10), rnd.Next(2, 10)];
FillArray(myArray);
WriteLine("Неотсортированный массив.");
PrintArray(myArray);
WriteLine("Массив отсортированный построчно.");
int index, temp;
for (int k = 0; k < myArray.GetLength(0); k++)
    for (int i = 0; i < myArray.GetLength(1); i++)
    {
        index = i;
        for (int j = i; j < myArray.GetLength(1); j++)
            if (myArray[k, j] > myArray[k, index])
                index = j;
        if (myArray[k, index] == myArray[k, i])
            continue;
        temp = myArray[k, i];
        myArray[k, i] = myArray[k, index];
        myArray[k, index] = temp;
    }
PrintArray(myArray);
