// S Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.

using static System.Console;
Clear();

int ReadNumder(string str)
{
    Write($"Переменная {str}: ");
    return int.Parse(ReadLine()!);
}
double FindX((int k1, int b1, int k2, int b2) pushRatio)
{
    return (double)(pushRatio.b2 - pushRatio.b1) / (pushRatio.k1 - pushRatio.k2);
}
double FindY((int k1, int b1, int k2, int b2) pushRatio)
{
    return (double)pushRatio.k1*FindX(pushRatio)+pushRatio.b1;
}

var ratio = (a: 0, b: 0, c: 0, d: 0);
WriteLine("Введите переменные a и b первого уравнения прямой y=ax-b.");
ratio.a = ReadNumder("a=");
ratio.b = ReadNumder("b=");
WriteLine("Введите переменные a и b второго уравнения прямой y=ax-b.");
ratio.c = ReadNumder("a=");
ratio.d = ReadNumder("b=");

if (ratio.a==ratio.c)
    if(ratio.b==ratio.d)
        WriteLine("Линии совпадают");
        else
        WriteLine("Линии парралельны");
  else
  WriteLine($"Линии пересекаются в точке с координатами: x = {FindX(ratio)} y = {FindY(ratio)}");      


