// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе

Console.Write("Введите число: ");
string Num = Console.ReadLine();
int num = int.Parse(Num);
int i = 0;

while (num > 0)
{
    num/= 10; // num = num / 10
    i++;
}
Console.WriteLine("Количество цифр в числе равно: " + i);