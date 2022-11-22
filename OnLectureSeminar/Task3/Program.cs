//Напишите программу, которая принимает на вход число и проверяет,
// кратно ли оно одновременно 7 и 23.
//14 -> нет 
//46 -> нет 
//161 -> да


using static System.Console;
Clear();
int m = int.Parse(ReadLine()!);
if (m % 7 == 0 && m % 23 == 0)
{
    WriteLine("Да");
}
else
{
    WriteLine("Нет");
}