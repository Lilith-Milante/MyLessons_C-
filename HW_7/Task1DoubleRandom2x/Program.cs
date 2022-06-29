//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами

Console.Write("Количество строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Количество столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());

double[,] array = new double[row, column]; // - создание массива

CreateDoubleArray(array);

PrintArray(array);

void CreateDoubleArray(double[,] array) // - функция создания массива
{
  for (int i = 0; i < row; i++)
  {
    for (int j = 0; j < column; j++)
    {
      array[i, j] = new Random().NextDouble() * 20 - 10;
    }
  }
}

void PrintArray (double[,] array) // - функция печати массива
{
for (int i = 0; i < row; i++)
  {
      for (int j = 0; j < column; j++)
      {
        Console.Write(array[i, j] + "\t");
      }
      Console.WriteLine();
  }
}