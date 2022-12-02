//дано натуральное n. вычислить: 1 + 1/2 + 1/3 + 1/4 + 
//... + 1/n.


using static System.Console;
Clear();

int n = Convert.ToInt32(ReadLine());
double sum = 1;
for (int i = 2; i <= n; i++)
    sum = sum + (double)1 / i;
WriteLine(sum);