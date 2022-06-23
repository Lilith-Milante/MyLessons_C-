//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива

double[] InitArray(int len) // - функция создания массива
{
    double[] arrA = new double[len];
    for (int i = 0; i < len; i++)
    {
        arrA[i] = new Random().NextDouble()*1000;
    }
    return arrA;
}
double []MyArray = InitArray(5); // - создаём массив

void PrintArray(double[] arrA)  // - функция печати массива
{
    for (int i = 0; i < arrA.Length; i++)
    {
        double element = arrA[i];
        System.Console.Write($"{element:F2}; ");
    }
    System.Console.WriteLine();
}

double FindMaxElem(double[] arrA)
{
  double max = arrA[0];
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

double FindMinElem(double[] arrA)
{
  double min = arrA[0];
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

double Dif = FindMaxElem(MyArray) - FindMinElem(MyArray);

Console.WriteLine($"Разность максимального и минимального значений: {Dif:F2}");
