int[] FillArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(-9,9);
    }
    return array;
}

int EnterData(string text)
{
    Console.Write(text);
    return (int.Parse(Console.ReadLine()));
}

int numA = EnterData("Введите число: ");
int[] array = FillArray(numA);
Console.WriteLine($"{String.Join(", ",array)} -> [{String.Join(", ",array)}]");

