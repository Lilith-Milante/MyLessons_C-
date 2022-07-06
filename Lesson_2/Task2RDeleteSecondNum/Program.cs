/* Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа

num = (num % 100) / 10; - нахождение второй цифры */

int number = new Random().Next(100, 1000);
Console.WriteLine("Случайное трёхзначное число: " + number);
int num1 = number / 100;
int num3 = number % 10;

Console.WriteLine("Число без второй цифры:  " + num1 + num3);