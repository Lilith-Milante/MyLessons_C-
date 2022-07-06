/*Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2] */

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
int []MyArray = InitArray(4);

void PrintArray(int[] arrA)
{
    for (int i = 0; i < arrA.Length; i++)
    {
        int element = arrA[i];
        System.Console.Write($"{element}; ");
    }
    System.Console.WriteLine();
}
PrintArray(MyArray);

int [] RevertElements(int[] arrA)
{
    for (int i = 0; i < arrA.Length; i++)
    {
        arrA[i] = - arrA[i];
    }
    return arrA;
}
PrintArray (RevertElements(MyArray));