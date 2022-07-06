// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.

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
int[] MyArray = InitArray(4);

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

int Prompt(string message)
{
    Console.Write(message);
    string number = Console.ReadLine();
    int numInt = int.Parse(number);
    return numInt;
}

int number = Prompt("Введите число  ");

bool FindElement(int[] arrA, int Num)
{
    foreach (int element in arrA)
    {
        if (element == Num)
        {
            return true;
        }
    }
    return false;
}

Console.WriteLine(FindElement(MyArray,number)? "да": "нет");
