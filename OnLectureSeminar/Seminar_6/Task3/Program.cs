// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.

using static System.Console;
Clear();

int a1 = 0,
    a2 = 1,
    bb, a3;

bb = int.Parse(ReadLine()!);

Write($"{a1} {a2} ");
for (int i = 3; i <= bb; i++)
{
    a3 = a1 + a2;
    Write($"{a3} ");
    a1 = a2;
    a2 = a3;
}

