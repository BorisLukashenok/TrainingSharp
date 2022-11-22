Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a < 0)
{
    a = -a;
}
int b = - a;

while( b <= a)
{
   Console.WriteLine(b); 
   b = b + 1;
}