/* Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8 */

int Prompt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int Degree(int numberA, int numberB)
{
    if (numberB == 0)
    {
        return 1;
    }
    return numberA * Degree(numberA, numberB - 1);
}

Console.WriteLine(Degree(Prompt("Введите число A "), Prompt("Введите число B ")));