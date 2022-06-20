//Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деление

Console.Write("Введите первое число  ");
string numstring  = Console.ReadLine();
int number1 = int.Parse(numstring);
Console.WriteLine("Вы ввели число:   " + number1);

Console.Write("Введите второе число  ");
string numstring2  = Console.ReadLine();
int number2 = int.Parse(numstring2);
Console.WriteLine("Вы ввели число:   " + number2);

if (number1 % number2 == 0)
{
    Console.WriteLine("Второе число кратно первому");
}
else
{
    int result = number1 % number2;
    Console.WriteLine($"Второе число не кратно первому, остаток = {result}");

}