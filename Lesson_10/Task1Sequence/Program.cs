/* Есть монотонная последовательность, каждое число встречается ровно то количество раз, какое значение этого числа: 1, 2, 2, 3, 3, 3, 4, 4, 4, 4,... Выведите ряд этой последовательности до N-го значения, желательно использовать рекурсию:
N = 12 -> "1, 2, 2, 3, 3, 3, 4, 4, 4, 4, 5, 5" */

int Prompt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

void PrintSequence(int numberN, int k = 1, int m = 0)
{
    for (int i = 0; i < k; i++)
    {
        if (m == numberN) return;
        Console.Write(k + "\t");
        m++;
    }
    PrintSequence(numberN, k + 1, m);
}

int numberN = Prompt("Введите N: ");
PrintSequence(numberN);