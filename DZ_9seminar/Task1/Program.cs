// Задайте значение N. Напишите программу, которая выведет все натуральные числа
// в промежутке от N до 1. Выполнить с помощью рекурсии

void PrintNat(int otN)
{
    if (otN == 1)
    {
        Console.Write($"{otN}'");
        return;
    }
    else
    {
        Console.Write($"{otN}, ");
        PrintNat(otN - 1);
    }
}
Console.Clear();
Console.Write("Введите N: ");
int N = int.Parse(Console.ReadLine()!);
Console.Write("'");
PrintNat(N);

