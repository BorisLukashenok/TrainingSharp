using static System.Console;
Clear();

int number = Convert.ToInt32(ReadLine()!);
int number2 = Convert.ToInt32(ReadLine()!);


if (number % number2 == 0)
{
    WriteLine("Первое число является квадратом второго");
}
else
{
    WriteLine("Остаток от деления = " + (number % number2));
}
