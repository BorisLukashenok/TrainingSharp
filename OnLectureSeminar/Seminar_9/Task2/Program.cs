// int[,] SizeMatrix(){

//     int rows = int.Parse(Console.ReadLine());
//     int colons = int.Parse(Console.ReadLine());
//     return FillArray(new int[rows,colons]);
// }

// int[,] FillArray(int[,] matrix){

//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i,j] = new Random().Next(10);
//         }
//     }
//     return matrix;
// }
// int[,] ProducrMatrix(int[,] matrix1, int[,] matrix2){
    
//     if(matrix1.GetLength(1) != matrix2.GetLength(0)){
//         System.Console.WriteLine("Матрицы невозможно перемножить в таком порядке");
//         return matrix1;
//     }
//     int[,] matrix3 = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

//     for (int i = 0; i < matrix1.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix2.GetLength(1); j++)
//         {
//             for (int k = 0; k < matrix1.GetLength(1); k++)
//             {
//                 matrix3[i,j]+= matrix1[i,k] * matrix2[k,j];
//             }
//         }
//     }
//     return matrix3;
// }


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

bool FindElement(int element, int[,,] array){

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if(array[i,j,k] == element) return true;
            }
        }
    }
    return false;
}

int x = int.Parse(Console.ReadLine());
int y = int.Parse(Console.ReadLine());
int z = int.Parse(Console.ReadLine());

int[,,] baseArray = new int[x,y,z];
for (int i = 0; i < baseArray.GetLength(0); i++)
{
    for (int j = 0; j < baseArray.GetLength(1); j++)
    {
        int k = 0;
        while(k < baseArray.GetLength(2)){
            var rnd = new Random().Next(10,100);
            if(!FindElement(rnd,baseArray)){
                baseArray[i,j,k] = rnd;
                k++;
            }
        }
    }
}

