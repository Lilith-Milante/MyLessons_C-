// Напишите программу, которая задаёт массив из 8 элементов случайными числами и выводит их на экран. Оформите заполнение массива и вывод в виде функции

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

int []RandomArray = Fil(8); // - действие функции по выводу массива
PrintArray(RandomArray);