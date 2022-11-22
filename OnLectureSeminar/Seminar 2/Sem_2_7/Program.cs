
using static System.Console;
Clear();

int n = Convert.ToInt32(ReadLine());

for (int i = 1; i < n; i++)
{

    if  ((int)Math.Pow(i, 2) > n)
        break;
    WriteLine((int)Math.Pow(i, 2));
}
  