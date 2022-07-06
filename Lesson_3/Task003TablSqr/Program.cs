// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N

int Prompt(string message)
{
    System.Console.Write(message);
    string param = Console.ReadLine();
    return int.Parse(param);
}

void Result(int N)
{
    int index = 1;
    while (index < N)
    {
        System.Console.WriteLine(index*index);
        index++;
    }
}

int number = Prompt("Введите число N: ");

Result(number);


