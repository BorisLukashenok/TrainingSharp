// Напишите программу, которая принимает на вход три числа
// и проверяет, может ли существовать треугольник со сторонами такой длины.

using static System.Console;

WriteLine("Введите три числа:");
int A = int.Parse(ReadLine()!);
int B = int.Parse(ReadLine()!);
int C = int.Parse(ReadLine()!);

bool IsNotTriangl(int A, int B, int C)
{
    return !((A > B + C) || (B > A + C) || (C > A + B));
}

if (IsNotTriangl(A,B,C))
    WriteLine("Да");
else
    WriteLine("Нет");
