// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

string EnterData(string text)
{
    Console.WriteLine(text);
    return ((Console.ReadLine()));
}

int CountNumbers(string[] massive)
{
    int sum = 0;
    for (int i = 0; i < massive.Length; i++)
    {
        int num = int.Parse(massive[i]);
        if(num > 0)
        {
        sum++;
        }
    }
    return sum;
}

string numbers = EnterData("Введите числа через  запятую : ");
string[] massive = numbers.Split(",");
int count = CountNumbers(massive);
Console.WriteLine($"{String.Join(", ",massive)} -> {count}");
