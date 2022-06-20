//Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа

int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из отрезка {number}");
int x = number % 10;
int y = number / 10;
if (x > y)
{
    Console.WriteLine($"Большая вторая цифра  {x}");
}
else
{
    Console.WriteLine($"Большая цифра первая  {y}");
}