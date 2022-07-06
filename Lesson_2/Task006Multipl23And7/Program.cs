//Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23

Console.Write("Введите число  ");
string numstring = Console.ReadLine();
int number = int.Parse(numstring);
Console.WriteLine("Вы ввели число:   " + number);

if (number % 7 == 0 && number % 23 == 0)
{
    Console.WriteLine($"{number} кратно 7 и 23");
}
else
{
    Console.WriteLine($"{number} не кратно 7 и 23");
}