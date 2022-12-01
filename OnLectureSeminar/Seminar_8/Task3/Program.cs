// Составить частотный словарь элементов двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент входных данных.

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

int[] number = new int[10];

for (int i = 0; i < myArray.GetLength(0); i++)
    for (int j = 0; j < myArray.GetLength(1); j++)
    {

        number[myArray[i, j]]++;

    }

for (int i = 0; i < number.Length; i++)
{
    if (number[i] != 0)
        WriteLine($"Число {i} встречается в массиве {number[i]} раз");
}