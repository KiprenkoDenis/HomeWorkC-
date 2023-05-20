// Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// запрашиваем два числа
// генерируем двухмерный массив
// выводим массив 

int EnterData(string text)
{
    Console.WriteLine(text);
    return (int.Parse(Console.ReadLine()));
}

double[,] GetMatrix(int rows, int colums)
{
    double[,] array = new double[rows, colums];
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < colums; j++)
        {
            array[i,j] = Math.Round( new Random().NextDouble() * (10.0 - -9.0)  + -9.0, 1);
        }
    }
    return array;
}

void PrintMatrix(double[,] array)
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

int m = EnterData("Введите число m: ");
int n = EnterData("Введите число n: ");
double[,] matrix = GetMatrix(m,n);
PrintMatrix(matrix);