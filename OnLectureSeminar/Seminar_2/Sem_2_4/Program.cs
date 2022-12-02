//Напишите программу, которая принимает на вход два 
//числа и проверяет, является ли одно число квадратом другого.

using static System.Console;
Clear();

int number1 = Convert.ToInt32(ReadLine());
int number2 = Convert.ToInt32(ReadLine());

if (number1 == (int)Math.Pow(number2, 2) ||
    number2 == (int)Math.Pow(number1, 2) )
{
    WriteLine("Являются ");
}
else
{
    WriteLine("Неявляются");
}
