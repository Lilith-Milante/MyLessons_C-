//Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов

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

double[] FindSumOfRows(int[,] array)
{
    double[] DoubleAverageMass = new double[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(1); i++)
    {
        double take = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            take = +array[i, j];
        }
    }
    return DoubleAverageMass;
}

int row = Prompt("Количество строк > ");
int column = Prompt("Количество столбцов > ");


int[,] array = GenerateArray(row, column);
PrintArray(array);