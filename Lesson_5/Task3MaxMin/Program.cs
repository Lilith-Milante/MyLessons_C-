//Задайте массив целых чисел. Найдите разницу между максимальным и минимальным элементов массива

int[] InitArray(int len) // - функция создания массива
{
    int[] arrA = new int[len];
    for (int i = 0; i < len; i++)
    {
        arrA[i] = new Random().Next(0, 100);
    }
    return arrA;
}

void PrintArray(int[] arrA)  // - функция печати массива
{
    for (int i = 0; i < arrA.Length; i++)
    {
        int element = arrA[i];
        Console.Write($"{element:F2}; ");
    }
    Console.WriteLine();
}

int FindMaxElem(int[] arrA)
{
    int max = arrA[0];
    for (int i = 0; i < arrA.Length; i++)
    {
        if (arrA[i] > max)
        {
            max = arrA[i];
        }
    }
    return max;
}

int FindMinElem(int[] arrA)
{
    int min = arrA[0];
    for (int i = 0; i < arrA.Length; i++)
    {
        if (arrA[i] < min)
        {
            min = arrA[i];
        }
    }
    return min;
}

int[] MyArray = InitArray(5); // - создаём массив
PrintArray(MyArray);

Console.WriteLine($"Максимальный элемент массива: {FindMaxElem(MyArray)}");
Console.WriteLine($"Минимальный элемент массива: {FindMinElem(MyArray)}");

int Dif = FindMaxElem(MyArray) - FindMinElem(MyArray);

Console.WriteLine($"Разность максимального и минимального значений: {Dif}");