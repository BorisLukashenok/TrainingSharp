// Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.

using static System.Console;
Clear();

// Попробовал написать функцию, проверяющуу, что введены цыфры
// и они нужной разрядности и возвращает число

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

int result = 0;
do
{
    Write("Введите трехзначное число: ");
    if (СorrectInput(ReadLine()!, 3, out result))
        break;
    else
        WriteLine("Вы ввели не трехзначное число!!!");

}
while (true);

WriteLine($"Средняя цифра: {(result%100)/10}");
