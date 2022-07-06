// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа

Console.WriteLine("Введите трёхзначное число:  ");
string Num = Console.ReadLine();
int num = int.Parse(Num);

if (num > 999 || num < 100)
{
    Console.WriteLine("Введено не трёхзначное число");
}
else
{
    num = (num % 100) / 10;
    Console.WriteLine($"Вторая цифра числа: {num}");
}
