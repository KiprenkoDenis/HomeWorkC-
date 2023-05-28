// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int EnterData(string text)
{
    Console.Write(text);
    return (int.Parse(Console.ReadLine()));
}

string GetNaturalNumbers(int n)
{
    if (n == 1)
        {
         return "1";
        }
     else
        {
        return n + ", " + GetNaturalNumbers(n - 1);
        }
}

int n = EnterData("Введите число N: ");
string result = GetNaturalNumbers(n);
Console.Write($"N = {n} - > \"{result}\"");
