int EnterData(string text)
{
    Console.WriteLine(text);
    return (int.Parse(Console.ReadLine()));
}

int SumNum(int b)
{
    int sum = 0;
    int res = 0;
    for(int i = 0; b > 10; i++ )
    {
        sum = b % 10;
        b = b / 10;
        res = res + sum;
    }
return res = res + b;
}

int num = EnterData("Введите число: ");
int res = SumNum(num);
Console.WriteLine($"{num} -> {res}");