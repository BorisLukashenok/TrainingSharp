using static System.Console;
Clear();

int Factorial(int N)
{
int i = 1;

for (int j = 1; N >= j; j++)
{
    i = i * j;
}
return i;
}

Write("Введите число, факториал которого надо посчитать: ");
int fact = Convert.ToInt32(ReadLine());
WriteLine($"факториал числа {fact} , равен - {Factorial(fact)} ");
