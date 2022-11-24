// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
// Не понял где тут 8 элементов

using static System.Console;
Clear();

int[] FillArrayOfNumders(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
        array[i] = new Random().Next(1, 100);
    return array;
}

int[] InputArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        Write($"Введите {i + 1} элемент массива: ");
        array[i] = int.Parse(ReadLine()!);
    }
    return array;
}

void PrintArray(int[] printArray)
{
    Write("[");
    for (int i = 0; i < printArray.Length; i++)
        Write($"{printArray[i]}, ");
    WriteLine("]");
}

void PrintArrayInterval(int[] printArray, int indexA, int indexB)
{
    Write("[");
    for (int i = indexA; i <= indexB; i++)
    {
        Write($"{printArray[i]}, ");
        if (i == printArray.Length - 1)
            break;
    }
    WriteLine("]");
}

// Так как я не понял условие задачи, то делаю несколько вариантов

WriteLine("Вариант 1"); // Рандомной длинны от 2 до 8
PrintArray(FillArrayOfNumders(new Random().Next(2, 9))); 
WriteLine();
WriteLine("Вариант 2"); // Вводим 8 элементов
int[] arrayNumbers = InputArray(8);
PrintArray(arrayNumbers); // Рапечатываем целиком
WriteLine();
WriteLine("Вариант 3"); // Рапечатываем интервалами
PrintArrayInterval(arrayNumbers, 0, 4);
PrintArrayInterval(arrayNumbers, 5, 7);