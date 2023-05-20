// // Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// // Например, задан массив:
// // 1 4 7 2
// // 5 9 2 3
// // 8 4 2 4
// // Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// // сгенерировать массив из целых чисел
// // найти среднее арифметическое каждого столбца
// // вывести результат




void PrintAvgAsString(double[] mean)
{
    Console.Write("Среднее арифметическое каждого столбца:");
for (int i = 0; i < mean.Length ; i++) 
{
Console.Write($"{mean[i].ToString("F1")}");
if (i != mean.Length - 1)
{
    Console.Write("; ");
}
}
Console.Write(".");
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

double[] GetArithmetMeanColum(int[,] array)
{
    double[] mean = new double[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(1); i++) 
    {
    double sum = 0;
        for (int j = 0; j < array.GetLength(0); j++) 
        {
        sum += array[j, i];
        }
        mean[i] = sum / array.GetLength(0);  
    } 
    return mean;
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
double[] mean = GetArithmetMeanColum(array);
PrintAvgAsString(mean);




