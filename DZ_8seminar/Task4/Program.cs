// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Пример Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

using static System.Console;
Clear();

Random rnd = new Random();

void FillArray(int[,,] fillArray)
{
    bool notStopRandom;
    int tempRandom = 0;
    for (int i = 0; i < fillArray.GetLength(0); i++)
        for (int j = 0; j < fillArray.GetLength(1); j++)
            for (int k = 0; k < fillArray.GetLength(2); k++)
            {
                do
                {
                    notStopRandom = false;
                    tempRandom = rnd.Next(10, 100);
                    foreach (int n in fillArray)
                        if (tempRandom == n)
                            notStopRandom = true;
                } while (notStopRandom);
                fillArray[i, k, j] = tempRandom;
            }

}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(1); i++)

        for (int j = 0; j < array.GetLength(0); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
                Write($"{array[j, k, i]}({j},{k},{i}) ");
            WriteLine();
        }
}

const int lenght = 3;
int[,,] myArray = new int[lenght, lenght, lenght];
FillArray(myArray);
PrintArray(myArray);