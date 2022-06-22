

int[] InitArray(int len) // - функция создания массива
{
    Random rnd = new Random();
    int[] arrA = new int[len];
    for (int i = 0; i < len; i++)
    {
        arrA[i] = rnd.Next(1, 100);
    }
    return arrA;
}
int []MyArray = InitArray(5); // - создаём массив

void PrintArray(int[] arrA)  // - функция печати массива
{
    for (int i = 0; i < arrA.Length; i++)
    {
        int element = arrA[i];
        System.Console.Write($"{element}; ");
    }
    System.Console.WriteLine();
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
Console.WriteLine($"Максимальный элемент массива: {FindMaxElem (MyArray)}");

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
Console.WriteLine($"Минимальный элемент массива: {FindMinElem (MyArray)}");

PrintArray(MyArray);

int Dif = FindMaxElem(MyArray) - FindMinElem(MyArray);

Console.WriteLine($"Разность максимального и минимального значений: {Dif}");