//  Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// сгенерировать двумерный массив
// вывести массив на экран
// упорядочить по убыванию элементы каждой строки
// вывести новый массив

int[,] SortRowsArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        
        int[] row = new int[array.GetLength(1)];

        for (int j = 0; j < array.GetLength(1); j++)
        {
            row[j] = array[i, j];
        }

        Array.Sort(row);
        Array.Reverse(row);

        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = row[j];
        }
    }
    return array;
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

int[,] array = GetMatrix(3,4);
PrintArray(array);
int[,] sortArray = SortRowsArray(array);
Console.WriteLine("В итоге получается вот такой массив: ");
PrintArray(sortArray);