// Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// Результат запишите в новом массиве.


using static System.Console;
Clear();

int[] array = { 1, 3, 5, 5, 7 };
int lenght = (array.Length % 2 == 0) ? array.Length / 2 : array.Length / 2 + 1;
int[] output = new int[lenght];

for (int i = 0; i < lenght; i++)
{
    output[i] = array[i] * array[array.Length - i - 1];
}
if(lenght%2 != 0)
output[lenght/2+1] =array[array.Length/2+1];
for (int i = 0; i < lenght; i++)
{
    Write(output[i]+" ");
}