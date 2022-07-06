//Программа для вычисления модуля числа

Console.WriteLine("Введите число");
string numstring = Console.ReadLine();
int numberStart = int.Parse(numstring);

if (numberStart < 0)
{
    Console.WriteLine("Модуль числа  " + numberStart * (-1));
}
else
{
    Console.WriteLine("Модуль числа  " + numberStart);
}