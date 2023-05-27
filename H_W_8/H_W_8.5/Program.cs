// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


int[,] GetMatrix(int rows, int colums)
{
    int[,] array = new int[rows, colums];
    int value = 1;
    int maxIndex = 3;
    int minIndex = 0;

    while (maxIndex >= minIndex)
        {
            for (int i = minIndex; i <= maxIndex; i++)
            {
                array[minIndex, i] = value++;
            }

            for (int i = minIndex + 1; i <= maxIndex; i++)
            {
                array[i, maxIndex] = value++;
            }

            for (int i = maxIndex - 1; i >= minIndex; i--)
            {
                array[maxIndex, i] = value++;
            }

            for (int i = maxIndex - 1; i >= minIndex + 1; i--)
            {
                array[i, minIndex] = value++;
            }

        minIndex++;
        maxIndex--;
        }
    return array;
}

void PrintArray(int[,] array)
{
 for(int i = 0; i < array.GetLength(0) ; i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if(array[i,j] <= 9)
            {
                Console.Write($"0{array[i,j]} ");
            }
            else
            {
                Console.Write($"{array[i,j]} ");
            }
        }
    Console.WriteLine();
    }
}

int[,] array = GetMatrix(4,4);
PrintArray(array);