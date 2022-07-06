//Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива

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

int FindMinElem(int[,] array) // - находим минимальный элемент
{
    int min = array[0, 0];
    foreach (int element in array)
    {
        if (element < min)
        {
            min = element;
        }
    }
    return min;
}

(int, int) FindIndexByValue(int[,] array, int value) // - создаём кортеж
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == value)
            {
                return (i, j);
            }
        }
    }
    return (0, 0);
}

int[,] RemoveRowColumn(int[,] array2, int row, int column) // - удаляем строку, создаём новый массив
{
    int[,] NewMass = new int[array2.GetLength(0) - 1, array2.GetLength(1) - 1];
    int k = 0;
    for (int i = 0; i < array2.GetLength(0); i++)
    {
        int l = 0;
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            if ((i != row) && (j != column))
            {
                NewMass[k, l] = array2[i, j];
                l++;
            }
        }
        if (i != row)
        {
            k++;
        }
    }
    return NewMass;
}

int row = Prompt("Количество строк > ");
int column = Prompt("Количество столбцов > ");
int min = -10;
int max = 10;

int[,] array = GenerateArray(row, column, min, max);
PrintArray(array);
Console.WriteLine();
(int row2, int column2) = FindIndexByValue(array, FindMinElem(array));
PrintArray(RemoveRowColumn(array, row2, column2));