//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце


int Prompt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int[,] GenerateArray(int row, int column)
{
    var array = new int[row, column];
    var rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(-10, 10);
        }
    }

    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

void PrintDoubleArray(double[] array) // - функция печати массива из вещ.чисел
{
    foreach (double element in array)
        Console.WriteLine($"{element:F2} ");
    Console.WriteLine();
}

double[] FindAverageOfColumns(int[,] array)
{
    double[] DoubleAverageMass = new double[array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double take = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            take = +array[i, j];
        }
        DoubleAverageMass[j] = take/array.GetLength(0);
    }
    return DoubleAverageMass;
}

int row = Prompt("Количество строк > ");
int column = Prompt("Количество столбцов > ");

int[,] array = GenerateArray(row, column);
PrintArray(array);

double[] DoubleAverageMass = FindAverageOfColumns(array);
Console.WriteLine("Среднее арифметическое элементов в каждом столбце: ");
PrintDoubleArray(DoubleAverageMass);