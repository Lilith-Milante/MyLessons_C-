/* Дано натуральное число N. Выведите все его цифры по одной, в обратном порядке, разделяя их пробелами или новыми строками.
При решении этой задачи нельзя использовать строки, списки, массивы (ну и циклы, разумеется). Разрешена только рекурсия и целочисленная арифметика */

int Prompt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int NumberToDevide = Prompt("Введите число: ");

void DevideNumber(int number)
{
    if (number == 0)
    {
        return;
    }
    Console.Write(number % 10);
    DevideNumber(number / 10);
}

DevideNumber(NumberToDevide);