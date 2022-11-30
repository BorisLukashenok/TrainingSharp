//  Напишите программу, которая будет преобразовывать десятичное число в двоичное.

using static System.Console;
Clear();

int decimals = int.Parse(ReadLine()!);
string ret = string.Empty;
while (decimals >= 1)
{
    ret = decimals % 2+ret;
    decimals /= 2;
}

WriteLine(ret);
