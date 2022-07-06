//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)

Console.Write("Введите число  ");
string numstring  = Console.ReadLine();
int numberStart = int.Parse(numstring);
int result = numberStart % 2;

if (result == 0)
{
	Console.WriteLine("Да");
}
else
{
	Console.WriteLine("Нет");
}