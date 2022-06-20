//напишите трёхзначное число и перевести его в массив

// Console.WriteLine("Напишите трёхзначное число  ");
// string numstring = Console.ReadLine();
// int number = int.Parse(numstring);
// int number1 = number % 10;
// int number2 = number % 100;
// int number3 = number / 10;

// Console.WriteLine( "{number1} {number2} {number3}");

Console.WriteLine("Enter number => ");
string NumStr = Console.ReadLine();
int Num = int.Parse(NumStr);
int[] array = {0, 0, 0};

array[0] = Num / 100;
array[1] = ( Num - (Num / 100) * 100 ) / 10;
array[2] = Num % 10;
Console.WriteLine(array[0]);
Console.WriteLine(array[1]);
Console.WriteLine(array[2]);

