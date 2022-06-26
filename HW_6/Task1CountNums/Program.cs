//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь

Console.WriteLine("Введите числа через пробел: ");
string numstring = Console.ReadLine();
string[] numbers = numstring.Split();

foreach (var num in numbers)
{
    Console.WriteLine($"{num}");
}

int[] MassInt = Array.ConvertAll(numbers, int.Parse);

void PrintArray(int[] MassInt)
{
    for (int i = 0; i < MassInt.Length; i++)
    {
        int element = MassInt[i];
        Console.Write($"{element}; ");
    }
    Console.WriteLine();
}

int FindPositiveNum(int[] MassInt)
{
    for (int i = 0; i < MassInt.Length; i++)
    {
        int count = 0;
        if (MassInt[i] > 0)
        {
            count = i;
            i++;
        }
        return count;
    }
} 

PrintArray(MassInt);
Console.WriteLine(FindPositiveNum(MassInt));



/*int[] MassInt = new int[numbers.length];

for (int i = 0; i < numbers.length; i++)
{
    MassInt[i] = Convert.ToInt32(numbers[i]);
}
Console.WriteLine("{MassInt}");

Console.WriteLine("Количество положительных чисел {count}");

Console.Write("Введите элементы(через пробел): ");
int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int count = 0;
 
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > 0)
    {
        count++;
    }
}*/


