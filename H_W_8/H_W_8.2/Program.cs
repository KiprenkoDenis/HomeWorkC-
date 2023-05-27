// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// генерируем двумерный массив
// выводим его на экран
// находим строку с наименьшей суммой элементов
// выводим ее на экран

void MinSumRow(int[,] array)
{
     int minRowIndex = 0;
        int minRowSum = int.MaxValue;

        for (int i = 0; i < array.GetLength(0); i++) 
        {
            int rowSum = 0;
            for (int j = 0; j < array.GetLength(1); j++) 
            {
                rowSum += array[i,j];
            }
            if (rowSum < minRowSum) 
            {
                minRowIndex = i + 1;
                minRowSum = rowSum;
            }
        }

        Console.WriteLine($"Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: {minRowIndex} строка");
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
MinSumRow(array);

