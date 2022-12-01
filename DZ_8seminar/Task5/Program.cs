//  Напишите программу, которая заполнит спирально массив 4 на 4.

using static System.Console;
Clear();

void FillSpiralArray(int[,] array)
{
    int currentCol = 0,
        currentRow = 0,
        stepX = 1,
        stepY = 0,
        decrementLenghtPath = 0,
        limiter = array.GetLength(1);
    for (int i = 1; i <= array.Length ; i++)
    {
        array[currentRow, currentCol] = i;
        if (--limiter == 0)
        {
            limiter = array.GetLength(1) * (decrementLenghtPath % 2) + 
                      array.GetLength(0) * ((decrementLenghtPath + 1) % 2) - 
                      (decrementLenghtPath / 2 - 1) - 2;
            int temp = stepX;
            stepX = -stepY;
            stepY = temp;
            decrementLenghtPath++;
        }
        currentCol += stepX;
        currentRow += stepY;
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int currentCol = 0; currentCol < array.GetLength(1); currentCol++)
            Write($"{array[i, currentCol]} \t");
        WriteLine();
    }
}

WriteLine();
Console.Clear();
Console.Write("Введите кол-во строк массива: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите кол-во столбцов массива: ");
int cols = int.Parse(Console.ReadLine()!);
int[,] myArray = new int[rows, cols];
FillSpiralArray(myArray);
PrintArray(myArray);