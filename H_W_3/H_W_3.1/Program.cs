// int x = (84212 / 1000) % 10 ;
//int x = (84212 / 10) % 10;



int EnterData(string text)
{
    Console.Write(text);
    return(int.Parse(Console.ReadLine()));
}

int num = EnterData("Введите пятизначное число: ");

if(num / 10000 == num % 10 & (num / 1000) % 10 == (num / 10) % 10 )
Console.WriteLine($"{num} -> да");
else
Console.WriteLine($"{num} -> нет");




