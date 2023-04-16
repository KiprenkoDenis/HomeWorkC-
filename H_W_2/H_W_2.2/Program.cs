Console.Write("Введите число: ");
string serialNum = Console.ReadLine();
if (serialNum.Length < 3)
{
    Console.WriteLine($"{serialNum} ->  третьей цифры нет");
}
else
{
    Console.WriteLine($"{serialNum} -> {serialNum[2]}");
}