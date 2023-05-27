// // Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// // Например, даны 2 матрицы:
// // 2 4 | 3 4
// // 3 2 | 3 3
// // Результирующая матрица будет:
// // 18 20
// // 15 18

int[,] MultiplyMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] result = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                sum += matrix1[i, k] * matrix2[k, j];
            }
            result[i, j] = sum;
        }
    }

    return result;
}


void PrintMatrix12(int[,] matrix1, int[,] matrix2)
{
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            Console.Write($"{matrix1[i, j]} ");
        }
        Console.Write("| ");
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            Console.Write($"{matrix2[i, j]} ");
        }
        Console.WriteLine();
    }
}

void PrintArray(int[,] array)
{
 for(int i = 0; i < array.GetLength(0) ; i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
    Console.WriteLine();
    }
}

int[,] GetMatrix(int rows, int colums)
{
    int[,] array = new int[rows, colums];
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < colums; j++)
        {
            array[i,j] = new Random().Next(1, 10);
        }
    }
    return array;
}

int[,] matrix1 = GetMatrix(2,2);
int[,] matrix2 = GetMatrix(2,2);
PrintMatrix12(matrix1, matrix2);
Console.WriteLine("Результирующая матрица будет:");
int[,] matrix3 = MultiplyMatrix(matrix1, matrix2);
PrintArray(matrix3);



