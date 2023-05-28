// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

 int SumNumMN(int m, int n)
 {
     if (m == n)
        {
        return m;
        }
     else
        {
        return m + SumNumMN(m + 1, n);
        }
 }

 int EnterData(string text)
{
    Console.Write(text);
    return (int.Parse(Console.ReadLine()));
}

int m = EnterData("Введите число M: ");
int n = EnterData("Введите число N: ");
int sum = SumNumMN(m,n);
Console.WriteLine($"M = {m}; N = {n} -> {sum}");