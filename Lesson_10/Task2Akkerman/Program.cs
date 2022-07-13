/* Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n. 
m = 3, n = 2 -> A(m,n) = 29 */

long Prompt(string message)
{
    Console.Write(message);
    return long.Parse(Console.ReadLine());
}

long m = Prompt("Введите m: ");
long n = Prompt("Введите n: ");

long Akkerman(long m, long n)
{
    if (m == 0)
    {
        return (n + 1);
    }
    else if (m > 0 && n == 0)
    {
        return Akkerman(m - 1, 1);
    }
    else
    {
    return Akkerman(m - 1, Akkerman(m, n - 1));
    }
}

Console.WriteLine($"m = {m}, n = {n} => A(m,n) = {Akkerman(m, n)}");