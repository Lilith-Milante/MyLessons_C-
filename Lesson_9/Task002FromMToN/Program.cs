/* Задайте значения M и N. Напишите программу, которая рекурсивно выведет все натуральные числа в промежутке от M до N
M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 6, 7, 8" */

int Prompt(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}

void PrintNatural(int num1, int num2)
{
    if (num2 < num1)
    {
        return;
    }
    PrintNatural(num1, num2 - 1); //от большего отнимаем - 1
    Console.Write($"{num2} ");
}

int m = Prompt("Введите M: ");
int n = Prompt("Введите N: ");

PrintNatural(m, n);