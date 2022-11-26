// Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.

using static System.Console;
Clear();

double[] GreatRandomArray(int lenghtArray)
{
    double[] newArray = new double[lenghtArray];
    for (int i = 0; i < lenghtArray; i++)
        newArray[i] = new Random().Next(100) + new Random().NextDouble();
    return newArray;
}

void PrintsDoubleArrayBeautifully(double[] workArray)
{
    Write("[ ");
    for (int i = 0; i < workArray.Length; i++)
        if (i == workArray.Length - 1)
            WriteLine($"{Math.Round(workArray[i], 2)} ]");
        else
            Write($"{Math.Round(workArray[i], 2)} ; ");

}

double[] array = GreatRandomArray(new Random().Next(3, 10));
PrintsDoubleArrayBeautifully(array);
WriteLine(Math.Round(array.Max()-array.Min(),2));
