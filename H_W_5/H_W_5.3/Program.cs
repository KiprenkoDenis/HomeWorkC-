double[] FillArray(int size)
{
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().NextDouble() * 100;
        array[i] = Math.Floor(new Random().NextDouble() * 100);
    }
    return array;

}

double DifMinMax(double[] array)
{
   double min = array[0];
   double max = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] < min)
        {
           min = array[i];
        }
        if(array[i] > max)
        {
            max = array[i];
        }
    }
    double dif = max - min;
    return dif;
}

int size = 5;
double[] array = FillArray(size);
double dif = DifMinMax(array);
Console.WriteLine($"[{String.Join(" ",array)}] -> {dif}");