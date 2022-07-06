// Двумерный массив

string[,] table = new string[2, 5]; // - задаём массив

//String.Empty;
/*table[0, 0] table[0, 1] table[0, 2] table[0, 3] table[0, 4] ;
table[1, 0] table[1, 1] table[1, 2] table[1, 3] table[1, 4] ; */

table[1, 2] = "слово"; // - обратились к элементу массива

for (int rows = 0; rows < 2; rows++) // - задаём массив
{
    for (int columns = 0; columns < 5; columns++)
    {
        Console.WriteLine($"--{table[rows, columns]}--");
    }
}

// выводим на экран матрицу и заполняем её

void PrintArray(int[,] matr) // - функция по печати массива
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr) // - функция по заполнению массива
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}

int[,] matrix = new int[3, 4];
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);

// программа по закрашиванию картинки

void PrintImage(int[,] image)
{
    for (int i = 0; i < image.GetLength(0); i++)
    {
        for (int j = 0; j < image.GetLength(1); j++)
        {
            if (image[i, j] == 0) Console.Write($" ");
            else Console.Write($"+");
        }
        Console.WriteLine();
    }
}

void FillImage(int [] pic, int row, int col)
{
    if (pic[row, col] == 0)
    {
        pic[row, col] = 1;
        FillImage(row - 1, col);
        FillImage(row, col - 1);
        FillImage(row + 1, col);
        FillImage(row, col + 1);
    }
}
PrintImage(pic);
FillImage(13, 13);
PrintImage(pic);

// n - факториал - пример рекурсии в этой жизни

int Factorial(int n)
{
    if (n == 1) return 1;
    else return n * Factorial(n - 1);
}
Console.WriteLine(Factorial(3));

// числа Фибоначчи || f (n) = f(n - 1) + f(n - 2)

double Fibonacci(int n)
{
    if (n == 1 || n == 2) return 1;
    else return Fibonacci(n - 1) + Fibonacci(n - 2);
}
for (int i = 1; i < 50; i++)
{
    Console.WriteLine($"f({i}) = {Fibonacci}");
}