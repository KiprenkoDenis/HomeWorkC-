int[] FillArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(-99,100);
    }
    return array;
}

int Sum(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i = i + 2)
    {
        sum += array[i]
    }
    return sum;
}



int numA = 4;
int[] array = FillArray(numA);
int sum = Sum(array);
Console.WriteLine($"[{String.Join(", ",array)}] -> {sum}");