// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе

Console.Write("Введите число: ");
string numstring = Console.ReadLine();
int Num = int.Parse(numstring);

int firstN = 0;
int sumNum = 0;

for (int i = 0; i < Num; i++)
{
    firstN = Num - Num % 10;
    sumNum = sumNum + (Num - firstN);
    Num = Num / 10;
}

Console.WriteLine($"Сумма цифр в числе равна: {sumNum}");