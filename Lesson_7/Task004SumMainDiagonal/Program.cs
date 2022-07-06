/*Задайте двумерный массив. Найдите сумму элементов главной диагонали
Например, задан массив:
1   4   7
5   9   2
8   4   2
Сумма элементов главной диагонали: 1+9+2 = 12*/


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
            array[i, j] = rnd.Next(1, 9);
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

int FindSumLine(int[,] array)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum = sum + array[i, i]; // i i потому как i и j равны в случае диагонали, тк пересечение
    }
    return sum;
}

int row = Prompt("Количество строк > ");
int column = Prompt("Количество столбцов > ");

int[,] array = GenerateArray(row, column);
PrintArray(array);

int sum = FindSumLine(array);
Console.WriteLine($"Сумма элементов главной диагонали: {sum}");