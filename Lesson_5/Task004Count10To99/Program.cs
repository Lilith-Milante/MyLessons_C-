// Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]

int[] InitArray(int len)
{
    Random rnd = new Random();
    int[] arrA = new int[len];
    for (int i = 0; i < len; i++)
    {
        arrA[i] = rnd.Next(-100, 101);
    }
    return arrA;
}
int[] MyArray = InitArray(123);

void PrintArray(int[] arrA)
{
    for (int i = 0; i < arrA.Length; i++)
    {
        int element = arrA[i];
        Console.Write($"{element}; ");
    }
    Console.WriteLine();
}
PrintArray(MyArray);

int Counts(int[] arrA)
{
    int i = 0;
    foreach (int element in arrA)
    {
        if (element >= 10 && element <= 99)
        {
            i++;
        }
    }
    return i;
}
Console.WriteLine(Counts (MyArray));