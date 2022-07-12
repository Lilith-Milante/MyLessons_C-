/* Есть монотонная последовательность, каждое число встречается ровно то количество раз, какое значение этого числа: 1, 2, 2, 3, 3, 3, 4, 4, 4, 4,... Выведите ряд этой последовательности до N-го значения, желательно использовать рекурсию:
N = 12 -> "1, 2, 2, 3, 3, 3, 4, 4, 4, 4, 5, 5" */

int Prompt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int numberN = Prompt("Введите N: "); // кол-во чисел в последовательности

/*void PrintSequence(int numberN)
{
    if (numberN > 1)
        PrintSequence(numberN - 1);

    for (int i = 0; i < numberN; i++)
        Console.Write($"{numberN}, ");
}
PrintSequence(numberN);*/

void PrintSequence(int numberN)
{
    int[] sequenceElements = new int[numberN]; // массив длиной в заданное число
    for (int i = 0, j = 1, k = j; i < numberN; i++)
    {
        if (sequenceElements[i] < numberN)
        {
            
        }
            sequenceElements[i] = j;
        if ((--k) == 0)
            k = (++j);
        Console.Write($"{j} ");
    }
}
PrintSequence(numberN);