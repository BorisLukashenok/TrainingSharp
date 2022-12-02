Console.Clear();
Console.Write("Введите размерность квадратного массива массива: ");
int rowsandcols = int.Parse(Console.ReadLine()!);
int[,] array = new int[rowsandcols, rowsandcols];

Console.Write("Вы хотите чтобы спираль шла по возрастанию или убыванию? Введите: UP или DOWN: ");
string answer = Convert.ToString(Console.ReadLine()!);

int tempnumber = 1;
int tempnumberdown = rowsandcols * rowsandcols;

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            if (inArray[i,j] < 10)
            {
                Console.Write($"0{inArray[i,j]}  ");
            }
            else
                Console.Write($"{inArray[i,j]}  ");
        }
        Console.WriteLine();
    }
}
void GetSpiralArrayUp(int[,] array, int n, int tempnumber)
{
    for (int i = 0; i < n; i++)
    {
        array[0, i] = tempnumber;
        tempnumber++;
    }
    for (int j = 1; j < n; j++)
    {
        array[j, n - 1] = tempnumber;
        tempnumber++;
    }
    for (int i1 = n - 2; i1 >= 0; i1--)
    {
        array[n - 1, i1] = tempnumber;
        tempnumber++;
    }
    for (int j1 = n - 2; j1 > 0; j1--)
    {
        array[j1, 0] = tempnumber;
        tempnumber++;
    }
    int c = 1;
    int d = 1;
    while (tempnumber < Math.Pow(n, 2))
    {
        while (array[c, d + 1] == 0)
        {
            array[c, d] = tempnumber;
            tempnumber++;
            d++;
        }
        while (array[c + 1, d] == 0)
        {
            array[c, d] = tempnumber;
            tempnumber++;
            c++;
        }
        while (array[c, d - 1] == 0)
        {
            array[c, d] = tempnumber;
            tempnumber++;
            d--;
        }
        while (array[c - 1, d] == 0)
        {
            array[c, d] = tempnumber;
            tempnumber++;
            d--;
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (array[i, j] == 0)
                {
                    array[i, j] = tempnumber;
                }
            }
        }

    }
}
void GetSpiralArrayDown(int[,] array, int n, int tempnumberdown)
{
    for (int i = 0; i < n; i++)
    {
        array[0, i] = tempnumberdown;
        tempnumberdown--;
    }
    for (int j = 1; j < n; j++)
    {
        array[j, n - 1] = tempnumberdown;
        tempnumberdown--;
    }
    for (int i1 = n - 2; i1 >= 0; i1--)
    {
        array[n - 1, i1] = tempnumberdown;
        tempnumberdown--;
    }
    for (int j1 = n - 2; j1 > 0; j1--)
    {
        array[j1, 0] = tempnumberdown;
        tempnumberdown--;
    }
    int c = 1;
    int d = 1;
    while (tempnumberdown > 1)
    {
        while (array[c, d + 1] == 0)
        {
            array[c, d] = tempnumberdown;
            tempnumberdown--;
            d++;
        }
        while (array[c + 1, d] == 0)
        {
            array[c, d] = tempnumberdown;
            tempnumberdown--;
            c++;
        }
        while (array[c, d - 1] == 0)
        {
            array[c, d] = tempnumberdown;
            tempnumberdown--;
            d--;
        }
        while (array[c - 1, d] == 0)
        {
            array[c, d] = tempnumberdown;
            tempnumberdown--;
            d--;
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (array[i, j] == 0)
                {
                    array[i, j] = tempnumberdown;
                }
            }
        }

    }
}

if (answer == "UP")
{
    GetSpiralArrayUp(array,rowsandcols,tempnumber);
}
if (answer == "DOWN")
{
    GetSpiralArrayDown(array,rowsandcols,tempnumberdown);
}
if (answer != "UP" && answer != "DOWN")
{
    Console.WriteLine("Команда не распознана. Спираль не будет создана.");
}
PrintArray(array);
