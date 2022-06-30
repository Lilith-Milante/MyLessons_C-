//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет

int Prompt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int[,] GenerateArray(int row, int column) // - создание массива
{
    var array = new int[row, column];
    var rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(-10, -10);
        }
    }

    return array;
}

void PrintArray(int[,] array) // - печать массива
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

int CompareElems(int[,] array) // - сравнение элементов через..что?
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == array[])
    }
    }
}

int row = Prompt("Количество строк > ");
int column = Prompt("Количество столбцов > ");
int posElem = Prompt("Введите позиции элемента массива через запятую > ");

int[,] array = GenerateArray(row, column);
PrintArray(array);
}