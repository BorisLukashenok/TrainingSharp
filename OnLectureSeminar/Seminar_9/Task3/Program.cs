// int[,] MatrixArray1 = SizeMatrix();
// int[,] MatrixArray2 = SizeMatrix();
// int[,] Matrix = ProducrMatrix(MatrixArray1,MatrixArray2);
// for (int i = 0; i < Matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < Matrix.GetLength(1); j++)
//     {
//         System.Console.Write($"{Matrix[i,j]}\t");
//     }
//     System.Console.WriteLine();
// }

// int rows = int.Parse(Console.ReadLine());
// int[,] array = new int[rows,rows];
// int temp = 1;
// int i = 0;
// int j = 0;
// while(temp <= rows*rows)
// {
//     array[i,j] = temp;
//     if(i <= j + 1 && i + j < rows-1) j++;
//     else if(i < j && i + j >= rows - 1) i++;
//     else if(i >= j && i+ j > rows - 1) j--;
//     else i--;
//     temp++;
// }
// for (int x = 0; x < array.GetLength(0); x++)
// {
//     for (int y = 0; y < array.GetLength(1); y++)
//     {
//         System.Console.Write($"{array[x,y]}\t");
//     }
//     System.Console.WriteLine();
// }