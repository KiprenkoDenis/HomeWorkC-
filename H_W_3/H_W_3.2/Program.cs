int EnterData(string text)
{
    Console.WriteLine(text);
    return (int.Parse(Console.ReadLine()));
}

int x1 = EnterData("Введите значение x1: ");
int y1 = EnterData("Введите значение y1: ");
int z1 = EnterData("Введите значение z1: ");
int x2 = EnterData("Введите значение x2: ");
int y2 = EnterData("Введите значение y2: ");
int z2 = EnterData("Введите значение z2: ");

double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
Console.WriteLine($"A {x1},{y1},{z1}; B {x2},{y2},{z2} -> {distance}");
