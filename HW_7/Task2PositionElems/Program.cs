//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет

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

string SearchElements(int[,] array, int rowPosition, int columnPosition)
{
    string answer = "\t";

    if ((rowPosition > array.GetLength(0) || columnPosition > array.GetLength(1))
    || (rowPosition < 1 || columnPosition < 1))
    {
        answer = "Такого элемента не существует (!)";
    }
    else
    {
        answer = $"{array[rowPosition - 1, columnPosition - 1]}"; // -1 делается чтобы отсчитывать позицию, а не индекс
    }
    return answer;
}

int row = Prompt("Количество строк > ");
int column = Prompt("Количество столбцов > ");

int[,] array = GenerateArray(row, column);
PrintArray(array);

int rowPosition = Prompt("Номер строки > ");
int columnPosition = Prompt("Номер столбца > ");

Console.WriteLine(SearchElements(array, rowPosition, columnPosition));