// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B

int Prompt(string message)
{
    System.Console.Write(message);
    string param = Console.ReadLine();
    return int.Parse(param);
}

int A = Prompt("Введите число A: ");
int B = Prompt("Введите число B: ");

int result = 1;
for (int i = 1; i <= B; i++)
{
    result = result * B;
}

Console.WriteLine($"{result}");