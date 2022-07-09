/* Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии
M = 1; N = 15 -> 120
M = 4; N = 8 -> 30 */

int Prompt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int PrintSum(int num1, int num2)
{
    if (num2 < num1) return 0;

    return PrintSum(num1, num2 - 1) + num2;
}

int num1 = Prompt("Введите M: ");
int num2 = Prompt("Введите N: ");

int Sum = (PrintSum(num1, num2));
Console.WriteLine($"Сумма натуральных элементов от {num1} до {num2} равна {Sum}");
PrintSum(num1, num2);