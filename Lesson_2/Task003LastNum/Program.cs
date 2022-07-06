//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа

Console.WriteLine("Введите трёхзначное число   ");
string numstring  = Console.ReadLine();
int numberStart = int.Parse(numstring);
int num = numberStart % 10;
Console.Write($"Последняя цифра числа: {num}");
