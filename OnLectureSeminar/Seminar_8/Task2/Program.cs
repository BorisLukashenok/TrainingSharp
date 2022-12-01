// Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы.
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

using static System.Console;
Clear();

int[,] GetArray(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(0); j++)
        {
            result[i, j] = new Random().Next(100);
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

int[,] ChangeArray(int[,] inArray)
{
    int[,] temparray = new int[inArray.GetLength(0), inArray.GetLength(1)];
    for (int i = 0; i < inArray.GetLength(0); i += 1)
        for (int j = 0; j < inArray.GetLength(1); j++)

            temparray[i, j] = inArray[j, i];

    return temparray;
}


try
{
    WriteLine();
    Console.Clear();
    Console.Write("Введите кол-во строк массива: ");
    int rows = int.Parse(Console.ReadLine()!);
    Console.Write("Введите кол-во столбцов массива: ");
    int cols = int.Parse(Console.ReadLine()!);

    int[,] myArray = GetArray(rows, cols);
    PrintArray(myArray);
    WriteLine();
    PrintArray(ChangeArray(myArray));
}
catch
{
    WriteLine("Количество столбцов должно быть равно количесву строк");
}

