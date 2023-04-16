Console.Write("Введите трехзначное число: ");
int firstNum = int.Parse(Console.ReadLine());
int secondNum = firstNum / 10;
int thirdNum = secondNum % 10;
Console.WriteLine($"{firstNum} -> {thirdNum}");


