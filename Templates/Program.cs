/*Копируй да вставляй

int number1 = number % 10; - третья цифра числа
int number2 = number % 100; - первая цифра числа
int number3 = number / 10; - откидываем третью цифрц

int number = new Random().Next( , ); - генератор случайных чисел от сих и до сих

Console.WriteLine("Введите число"); - ввод информации
string numstring = Console.ReadLine(); - считывание строки
int numberStart = int.Parse(numstring); - перевод из строки в число

int Prompt(string message) - функция ввода строки
{
    Console.Write(message);
    string number = Console.ReadLine();
    int numInt = int.Parse(number);
    return numInt;
}

int Prompt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int Num = Convert.ToInt32(Console.ReadLine()); - конвертация строки с число

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

num/= 10; // num = num / 10

*/