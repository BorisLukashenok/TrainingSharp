// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

using static System.Console;
Clear();

Write("Введите число: ");
var number = int.Parse(ReadLine()!);
for (int i = 1; i <= number; i++)
    WriteLine(Math.Pow(i, 3));
