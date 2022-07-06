//Задача 1 Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее

Console.Write("Введите первое число  ");
string numstring  = Console.ReadLine();
int number1 = int.Parse(numstring);
Console.WriteLine("Вы ввели число:   " + number1);

Console.Write("Введите второе число  ");
string numstring2  = Console.ReadLine();
int number2 = int.Parse(numstring2);
Console.WriteLine("Вы ввели число:   " + number2);

if (number1 > number2)
{
    Console.WriteLine("Максимальное число  " + number1);
    Console.WriteLine("Минимальное число  " + number2);
}
else
{
	Console.WriteLine("Максимальное число  " + number2);
    Console.WriteLine("Минимальное число  " + number1);
}