// Задача 2: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

int Prompt(string message)
{
    Console.Write(message);
    string number = Console.ReadLine();
    int numInt = int.Parse(number);
    return numInt;
}

int multN(int maxNumber)
{
    int answer = 1;
    for (int i = 1; i <= maxNumber; i++)
    {
        answer *= i;
    }
    return answer;
}

int numberN = Prompt("Введмте число > ");
System.Console.WriteLine($"Произведение от 1 до {numberN} равно {multN(numberN)}");


