// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

using static System.Console;
Clear();

int[] GreatRandomArray(int lenghtArray)
{
    int[] newArray = new int[lenghtArray];
    for (int i = 0; i < lenghtArray; i++)
        newArray[i] = new Random().Next(-50, 50);
    return newArray;
}

int CalculateSumNumbersOnNegativPos(int[] workArray)
{
    int count = 0;
    for (int i = 1; i < workArray.Length; i += 2)
        count += workArray[i];
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
WriteLine(CalculateSumNumbersOnNegativPos(array));