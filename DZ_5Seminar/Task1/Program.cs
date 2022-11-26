// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

using static System.Console;
Clear();

int[] GreatRandomArray(int lenghtArray)
{
    int[] newArray =new int[lenghtArray];
    for (int i = 0; i < lenghtArray; i++)
        newArray[i] = new Random().Next(100, 1000);
    return newArray;
}

int CalculatePositiveNumbers(int[] workArray)
{
    int count=0;
    for (int i = 0; i < workArray.Length; i++)
    {
        if(workArray[i]%2==0)
        count++;
    }
    return count;
}

void PrintsArrayBeautifully(int[] workArray)
{
    Write("[ ");
    for (int i = 0; i < workArray.Length; i++)
    if (i==workArray.Length-1 )   
         WriteLine($"{workArray[i]} ]");
         else
         Write($"{workArray[i]}, ");
    
}

int[] array=GreatRandomArray(new Random().Next(3,10));
PrintsArrayBeautifully(array);
WriteLine(CalculatePositiveNumbers(array));