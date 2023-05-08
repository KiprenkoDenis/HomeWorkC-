int[] FillArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100,1000);
    }
    return array;
}

int CountEven(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}



int numA = 4;
int[] array = FillArray(numA);
int count = CountEven(array);
Console.WriteLine($"{String.Join(", ",array)} -> {count}");

