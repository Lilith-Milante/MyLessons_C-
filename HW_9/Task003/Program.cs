/* Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр. Использовать рекурсию.
453 -> 12
45 -> 9 */

int Prompt(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int CalcSumNum(int number)
{
    if (number == 0)
    {
        return 0;
    }
    return number % 10 + CalcSumNum(number/10);
}

Console.WriteLine(CalcSumNum(Prompt("Введите число: ")));