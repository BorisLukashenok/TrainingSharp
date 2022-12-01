// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

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


int[,] myArray = new int[rnd.Next(2, 10), rnd.Next(2, 10)];
FillArray(myArray);
PrintArray(myArray);
int row, col;
WriteLine("Незабываем, что индексы начинааются с 0");
WriteLine("Введите индексы массива.");
Write("Строка: ");
row = int.Parse(ReadLine()!);
Write("Столбец: ");
col = int.Parse(ReadLine()!);

if (row > myArray.GetLength(0) - 1 || col > myArray.GetLength(1) - 1)
    WriteLine("Нет элемента массива с таким индексом.");
else
    WriteLine($"Элемент с индексом [{row},{col}] = {myArray[row, col]}");