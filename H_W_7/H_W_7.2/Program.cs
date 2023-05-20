// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// сгенерировать массив
// принять позицию элемента массива
// вывести значение элемента

void PrintMatrix(int[,] array)
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

void FindElement(int[,] array, int rows, int colums)
{
    if(rows > array.GetLength(0) || colums > array.GetLength(1) )
    {
        Console.WriteLine($"{rows},{colums} -> такого элемента в массиве нет");
    }
    else
    {
        Console.WriteLine(array[rows,colums]);
    }
}

int EnterData(string text)
{
    Console.WriteLine(text);
    return (int.Parse(Console.ReadLine()));
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

int[,] array = GetMatrix(3, 4);
int rows = EnterData("Введите номер строки: ");
int colums = EnterData("Введите номер столбца: ");
PrintMatrix(array);
FindElement(array, rows, colums);