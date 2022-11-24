// Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.

using static System.Console;
Clear();

int NaturalDegree(int basisDegree, int indicatorDegree)
{
    int result = 1;
    for (int i = 1; i <= indicatorDegree; i++)
        result *= basisDegree;
    return result;
}
int number, degree;

Write("Введите Число: ");
number = int.Parse(ReadLine()!);
Write("Введите степень: ");
degree = int.Parse(ReadLine()!);
WriteLine($"Натуральная степень числа {number}");
WriteLine($"в степени {degree} равна: {NaturalDegree(number,degree)}");
