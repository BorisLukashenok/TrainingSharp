// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

using static System.Console;
Clear();

Random rnd = new Random();

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = rnd.Next(1, 5);
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


int[,] MultiplicationMatrix(int[,] firstMatrix, int[,] secondMatrix)
{

    var resultMatrix = new int[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];
    for (int i = 0; i < firstMatrix.GetLength(0); i++)
        for (int j = 0; j < secondMatrix.GetLength(1); j++)
            for (int k = 0; k < secondMatrix.GetLength(0); k++)
                resultMatrix[i, j] += firstMatrix[i, k] * secondMatrix[k, j];
    return resultMatrix;
}

int[,] firstArray = new int[rnd.Next(2, 5), rnd.Next(2, 5)],
       secondArray = new int[firstArray.GetLength(1), firstArray.GetLength(0)];
FillArray(firstArray);
WriteLine("Первая матрица.");
PrintArray(firstArray);
FillArray(secondArray);
WriteLine("Вторая матрица.");
PrintArray(secondArray);
var multiplicationArray = MultiplicationMatrix(firstArray, secondArray);
WriteLine("Произведение матриц.");
PrintArray(multiplicationArray);
