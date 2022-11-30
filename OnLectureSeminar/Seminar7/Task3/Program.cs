using static System.Console;
Clear();

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(0); j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue+1);
        }
    }
    return result;
}

void GArray(int[,] result)
{
    for (int i = 0; i < result.GetLength(0); i+=2)
    {
        for (int j = 0; j < result.GetLength(0); j+=2)
        {
            result[i, j] *= result[i, j];
        }
    }
    
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

WriteLine();
Console.Clear();
Console.Write("Введите кол-во строк массива: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите кол-во столбцов массива: ");
int cols = int.Parse(Console.ReadLine()!);
int[,] array = GetArray(rows, cols, 0, 10);
PrintArray(array);
WriteLine();
GArray(array);
PrintArray(array);