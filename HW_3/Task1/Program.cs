// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом

Console.WriteLine("Введите число  ");
string Num = Console.ReadLine();
int Len = Num.Length;

bool q = true;
int i = 0;

for (i = 0; i <= Len / 2; i++);
{
    if (Num[i] != Num[Len - 1 - i])
    {
        Console.WriteLine($"Число {Num} Не является палиндромом");
        q = false;
    }
}
if (q == true)
{
    Console.WriteLine($"Число {Num} является палиндромом");
}