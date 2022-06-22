// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int[] InitArray(int len) // - функция по заполнению массива
{
    Random rnd = new Random();
    int[] arrA = new int[len];
    for (int i = 0; i < len; i++)
    {
        arrA[i] = rnd.Next(-10, 10);
    }
    return arrA;
}
int []MyArray = InitArray(5);

void PrintArray(int[] arrA) // - функция печати массива
{
    for (int i = 0; i < arrA.Length; i++)
    {
        int element = arrA[i];
        System.Console.Write($"{element}; ");
    }
    System.Console.WriteLine();
}

int CalcSumElemOdd(int[] arrA)
{
    int sum = 0;
    int i = 0;
    while (i < arrA.Length)
    {
      sum = sum + arrA[i];
      i += 2;
    }
    return sum;

}
PrintArray(MyArray);
Console.Write(CalcSumElemOdd (MyArray));