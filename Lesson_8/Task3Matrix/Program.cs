/* Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц

Количество строк во второй матрице должно быть равно количеству строк во второй матрице */

int[,] CreateMatrix(string message) // функция по созданию матриц (вместо Prompt и выводов)
{
    Console.Write("Количество строк > ");
    int row = int.Parse(Console.ReadLine());

    Console.Write("Количество столбцов > ");
    int column = int.Parse(Console.ReadLine());

    int[,] array = GenerateArray(row, column); // новый двумерный массив создаётся с помощью функции GenerateArray
    return (array);
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

int[,] CreateResultMassive(int[,] matr1, int[,] matr2)
{
    int[,] result = new int[matr1.GetLength(0), matr2.GetLength(1)];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = SearchProdFromTwoMatrix(matr1, matr2, i, j); // заполняем массив с помощью функции с перемножением элементов
        }
    }
    return result;
}

int SearchProdFromTwoMatrix(int[,] matr1, int[,] matr2, int rowMatrix1, int columnMatrix2)
{
    int answer = 0;
    for (int i = 0; i < matr1.GetLength(0); i++)
    {
        answer += matr1[rowMatrix1, i] * matr2[i, columnMatrix2];
    }
    return answer;
}

int[,] matrix1 = CreateMatrix("Matrix1");
int[,] matrix2 = CreateMatrix("Matrix2");

Console.WriteLine("Первая матрица: ");
PrintArray(matrix1);
Console.WriteLine("Вторая матрица: ");
PrintArray(matrix2);

if(matrix1.GetLength(0) != matrix2.GetLength(1))
{
    Console.WriteLine("Количество СТОЛБЦОВ в первой матрице не равно количеству СТРОК во второй (!)");
    Environment.Exit(0);
}

int[,] matrix3 = CreateResultMassive(matrix1, matrix2);
Console.WriteLine("Произведение двух матриц: ");
PrintArray(matrix3);