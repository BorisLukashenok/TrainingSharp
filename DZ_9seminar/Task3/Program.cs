//  Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

uint Akkerman(uint m, uint n)
{
    if (m == 0)
        return n + 1;
    else
      if ((m != 0) && (n == 0))
        return Akkerman(m - 1, 1);
    else
        return Akkerman(m - 1, Akkerman(m, n - 1));
}

Console.Clear();
Console.WriteLine("Введите два неотрицательных целых чисела для функции Аккермана.");
Console.WriteLine("!!!!!!Желательно значения M не больше 3!!!!!!!");
Console.Write("Введите M: ");
uint M = uint.Parse(Console.ReadLine()!);
Console.Write("Введите N: ");
uint N = uint.Parse(Console.ReadLine()!);
Console.WriteLine($"A({M},{N}) = {Akkerman(M, N)}");