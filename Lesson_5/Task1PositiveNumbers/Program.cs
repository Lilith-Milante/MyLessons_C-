//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int[] InitArray(int len)
{
    Random rnd = new Random();
    int[] arrA = new int[len];
    for (int i = 0; i < len; i++)
    {
        arrA[i] = rnd.Next(100, 1000);
    }
    return arrA;
}
int []MyArray = InitArray(5);

void PrintArray(int[] arrA)
{
    for (int i = 0; i < arrA.Length; i++)
    {
        int element = arrA[i];
        System.Console.Write($"{element}; ");
    }
    System.Console.WriteLine();
}

int FindPositiveElements(int[] arrA)
{
    int i = 0;
    foreach (int element in arrA)
    {
        if (element % 2 == 0)
        {
            i++;
        }
    }
    return i;
}

Console.WriteLine(FindPositiveElements (MyArray));

PrintArray(MyArray);