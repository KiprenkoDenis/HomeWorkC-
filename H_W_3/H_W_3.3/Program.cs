int EnterData(string text)
{
    Console.WriteLine(text);
    return (int.Parse(Console.ReadLine()));
}

int n = EnterData("Введите число N: ");
Console.Write($"{n} -> ");
for(int i = 1; i <= n; i++)
{
    Console.Write($"{i*i*i}");
    if(i<n)
    Console.Write(", ");
}