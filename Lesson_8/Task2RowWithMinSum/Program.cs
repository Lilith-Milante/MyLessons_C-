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

int[] CalcSumFromRows(int[,] array)
{
    int[] sum = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int result = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            result += array[i, j];
        }
        sum[i] = result;
    }
    return sum;
}

int FindSmallestSumFromRows(int[] array)
{
    int min = array[0];
    int take = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
            take = i;
        }
    }
    return take;
}

int row = Prompt("Количество строк > ");
int column = Prompt("Количество столбцов > ");

int[,] array = GenerateArray(row, column);
Console.WriteLine("Исходный массив: ");
PrintArray(array);

int[] SumFromRows = CalcSumFromRows(array);
int RowThatWeFind = FindSmallestSumFromRows(SumFromRows);
Console.WriteLine($"Строка с наименьшей суммой элементов: {RowThatWeFind + 1}"); // + 1 для того, чтобы считалось по порядку, а не по индексу (воизбежание нулей)