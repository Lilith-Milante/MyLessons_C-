/*Составить частотный словарь элементов двумерного массива. 
Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных. Значения элементов массива 0..9*/

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
            array[i, j] = rnd.Next(0, 10);
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

int[] FrequencyVoc(int[,] array)
{
    int [] FreqMass = new int[10];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            FreqMass[array[i, j]]++;
        }
    }
    return FreqMass;
}

void PrintArray2(int[] arrA)
{
    for (int i = 0; i < arrA.Length; i++)
    {
        int element = arrA[i];
        Console.Write($"{i}-{element}; ");
    }
    System.Console.WriteLine();
}

int row = Prompt("Количество строк > ");
int column = Prompt("Количество столбцов > ");

int[,] array = GenerateArray(row, column);
PrintArray(array);
Console.WriteLine();
PrintArray2(FrequencyVoc(array));


