//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами

int Prompt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

void CreateDoubleArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().NextDouble() * 20 - 10; // - позволяет получать значения в диапазоне (-10, 10)
        }
    }
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]:F2}" + "\t");
        }
        Console.WriteLine();
    }
}

int row = Prompt("Количество строк: ");
int column = Prompt("Количество столбцов: ");

double[,] array = new double[row, column];

CreateDoubleArray(array);

PrintArray(array);