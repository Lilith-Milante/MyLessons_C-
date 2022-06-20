// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.

int []Array = new int [8];

void PrintArray(int []Array);

int count = Array.Length;

for (i = 0; i > count; i++)
{
 new Random().Next(0,2);
}
Console.WriteLine("Выводим массив ");

