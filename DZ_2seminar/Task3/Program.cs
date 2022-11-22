// Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.

using static System.Console;
Clear();

int dayOfWeek =0;
do
{
    WriteLine("Введите число, от 1 до 7, обозначающее день недели");
    dayOfWeek = Convert.ToInt32(ReadLine());
    if(dayOfWeek>0 && dayOfWeek<8)
        break;
} while (true);
    if (dayOfWeek == 6 || dayOfWeek == 7)
        WriteLine("Сегодня выходной!");
    else
        WriteLine("Сегодня рабочий день.");

