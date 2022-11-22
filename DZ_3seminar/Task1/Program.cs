// Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

using static System.Console;
Clear();

bool СorrectInput(string str, int depth, out int number)
{
    number = 0;
    bool test = false;
    if (depth == str.Length && int.TryParse(str, out number))
    {
        test = true;
    }
    return test;
}

string numberOfString;
do
{
    Write("Введите пятизначное число: ");
    numberOfString = ReadLine()!;
    if (СorrectInput(numberOfString, 5, out int result))
        break;
    else
        WriteLine("Вы ввели не пятизначное число!!!");
} while (true);

if (numberOfString[0] == numberOfString[4] && numberOfString[1] == numberOfString[3])
    WriteLine("Да");
else
    WriteLine("Нет");



