//  Задайте значения M и N.
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int SumRec(int otM, int doN)
{

    if (doN == otM) return otM;
    else return doN + SumRec(otM, doN - 1);
}
Console.Clear();
Console.Write("Введите M: ");
int M = int.Parse(Console.ReadLine()!);
Console.Write("Введите N: ");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Сумма чисел от {M} до {N}: {SumRec(M, N)}");