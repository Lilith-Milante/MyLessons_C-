//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел

Console.Write("Введите первое число  ");
string numstring  = Console.ReadLine();
int number = int.Parse(numstring);

Console.Write("Введете второе число  ");
string numstring2  = Console.ReadLine();
int number2 = int.Parse(numstring2);

Console.Write("Введете второе число  ");
string numstring3  = Console.ReadLine();
int number3 = int.Parse(numstring3);
{
	int result = number;
	if (number2 > result) result = number2;
	if (number3 > result) result = number3;
	Console.WriteLine($"{result}");
}