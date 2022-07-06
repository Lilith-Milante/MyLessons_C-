//напишите трёхзначное число и перевести его в массив

Console.Write("Введите трёхзначное число: ");
string NumStr = Console.ReadLine();
int Num = int.Parse(NumStr);
int[] array = {0, 0, 0};

array[0] = Num / 100;
array[1] = ( Num - (Num / 100) * 100 ) / 10;
array[2] = Num % 10;

Console.WriteLine(array[0]);
Console.WriteLine(array[1]);
Console.WriteLine(array[2]);