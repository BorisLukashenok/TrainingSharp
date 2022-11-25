// Задайте массив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве.

using static System.Console;
Clear();

int[] number = { 6, 7, 19, 345, 3 };
int find = 67;
bool d = false;

for (int i = 0; i < 5; i++)
{
    if (find == number[i])
        d = true;
}
if (d)
    WriteLine("Да");
else
    WriteLine("Нет");