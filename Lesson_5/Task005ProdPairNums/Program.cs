// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.

int[] InitArray(int len)
{
    Random rnd = new Random();
    int[] arrA = new int[len];
    for (int i = 0; i < len; i++)
    {
        arrA[i] = rnd.Next(-10, 11);
    }
    return arrA;
}
int[] MyArray = InitArray(10);

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

int[] Mult(int[] arrA)
{
    int[] result = new int[arrA.Length / 2];
    for (int i = 0; i < arrA.Length / 2; i++)
    {
        result[i] = arrA[i] * arrA[arrA.Length - i - 1];
    }
    return result;
}
PrintArray(Mult(MyArray));