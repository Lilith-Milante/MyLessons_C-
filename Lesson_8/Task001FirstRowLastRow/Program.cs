//Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива

int Prompt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int[,] GenerateArray(int row, int column, int min, int max)
{
    var array = new int[row, column];
    var rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(min, max + 1);
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

int[,] ChangeRow1ToRow2(int[,] array)
{
    int lastRow = array.GetLength(0) - 1;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        int temp = array[0, i];
        array[0, i] = array[lastRow, i];
        array[lastRow, i] = temp;
    }
    return array;
}

int row = Prompt("Количество строк > ");
int column = Prompt("Количество столбцов > ");
int min = -10;
int max = 10;

int[,] array = GenerateArray(row, column, min, max);
PrintArray(array);
Console.WriteLine();

PrintArray(ChangeRow1ToRow2(array));