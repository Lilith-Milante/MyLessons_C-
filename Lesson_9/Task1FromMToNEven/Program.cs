/* Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии
M = 1; N = 5 -> "2, 4"
M = 4; N = 8 -> "4, 6, 8" */

int Prompt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

void PrintEven(int num1, int num2)
{
    if (num2 < num1) return;
    
    if (num2 % 2 == 1)
    {
        num2--;
    }
    PrintEven(num1, num2 - 2);
    Console.Write($"{num2} ");
}

int m = Prompt("Введите M: "); // num1
int n = Prompt("Введите N: "); // num2
Console.WriteLine($"M = {m}; N = {n}");

PrintEven(m, n);