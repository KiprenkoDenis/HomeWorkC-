Console.Write("Введите число от 1 до 7: ");
int day = int.Parse(Console.ReadLine());
if(day != 6 & day != 7)
{
    Console.WriteLine($"{day} -> нет");
}
else
{
    Console.WriteLine($"{day} -> да");
}