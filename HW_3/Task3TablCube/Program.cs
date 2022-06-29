//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N

int Prompt(string message)
{
    Console.Write(message);
    string number = Console.ReadLine();
    int numInt = int.Parse(number);
    return numInt;
}

int x = Prompt("Введите число ");

for (int i = 1; i <= x; i++)
{
    Console.Write($"{Math.Pow(i, 3):F0} ");
}