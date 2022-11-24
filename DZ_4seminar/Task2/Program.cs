// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

using static System.Console;
Clear();

// Проверяет что строка str это число разрядности depth и возвращает его в численном виде в numder
// Если depth == 0 то любой разрядности, просто копирует int.TryParse
 
bool СorrectInput(string str, int depth, out int number) 
{
    number = 0;
    bool test = false;
    if (depth == str.Length && int.TryParse(str, out number) ||
        depth == 0 && int.TryParse(str, out number))
    {
        test = true;
    }
    return test;
}

int SumDigitOfNumders(int inputNumders)
{
    string stringNumders = inputNumders.ToString();
    WriteLine(stringNumders);
    int result = 0;
    for (int i = 0; i < stringNumders.Length; i++)
        result = result + int.Parse(stringNumders[i].ToString());
    return result;
}

int output;
string numberOfString;
do
{
    Write("Введите число: ");
    numberOfString = ReadLine()!;
    if (СorrectInput(numberOfString, 0, out output))
        break;
    else
        WriteLine("Вы ввели не число!!!");
} while (true);
WriteLine($"Сумма цыфр числа {numberOfString} равна {SumDigitOfNumders(output)}");
