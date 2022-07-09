// Напишите программу, которая на вход принимает два числа и выдаёт первые N чисел, для которых каждое следующее равно сумме двух предыдущих

long Prompt(string message)
{
    Console.Write(message);
    return long.Parse(Console.ReadLine());
}

long Fibonacci(long num1, long num2, long num)
{
    if (num == 0) return 0;
    Console.WriteLine(num1);
    long temp = Fibonacci(num2, num2 + num1, num - 1) + num1;
    return temp;
}

long num1 = Prompt("Введите первое число: ");
long num2 = Prompt("Введите второе число: ");
long num = Prompt("Введите число: ");

Fibonacci(num1, num2, num);