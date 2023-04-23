int Exp(int numA, int numB)
{
    int res = numA;
    for (int i = 1; i < numB; i++ )
    {
        res = res * numA;
    }
    return res;
}


int EnterData(string text)
{
    Console.WriteLine(text);
    return (int.Parse(Console.ReadLine()));
}

int numA = EnterData("Введите число А: ");
int numB = EnterData("Введите число B: ");
int res = Exp(numA, numB);
Console.WriteLine($"{numA}, {numB} -> {res}");