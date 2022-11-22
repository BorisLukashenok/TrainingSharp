// Вычислить : 1+2+4+8+...+ 2 в 10 степени.



using static System.Console;
Clear();
int sum = 0;
for (int i = 0; i <= 10; i++)
{
    sum = sum+(int)Math.Pow(2, i);
    WriteLine(sum);
}
WriteLine(sum);