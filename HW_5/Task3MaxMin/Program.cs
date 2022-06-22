// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементом массива

void PrintArray(int []rdm)   // - функция ввода-вывода массива
{
    for (int i = 0; i < rdm.Length; i++)
    {
        Console.Write($"{rdm[i]   }");
    }
}

int [] Fil(int Length) // - функция по заполнению массива
{
int []Random = new int[8];
for (int i = 0; i < 8; i++)
{
    Random[i] = new Random().Next (0, 8);
    //Console.WriteLine(i);
}
return Random;
}

int [] FindMaxElem(int[] arrA)
{
	int max = arrA[0];
	for (int i = 0; i < arrA.Length; i++)
	{
		if (arrA[i] > max)
        {
            arrA[i] = max;
            //i++;
        }
	}
    return arrA;
}


/*double [] FindMinElem(int[] arrA)
{
	double min = 0;
	for (int i = 0; i < arrA.Length; i++)
	{
		if (i < min)
        {
            min = arrA[i];
            i++;
        }
	}
}
return min;*/

//Console.WriteLine($"{max} - {min}"); // - вычисление разности
int []RandomArray = Fil(8);
PrintArray(FindMaxElem(RandomArray));

//PrintArray(RandomArray);

