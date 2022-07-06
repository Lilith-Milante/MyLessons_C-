//Программа, которая на вход принимает значение, а на выходе показывает обратное значение

Console.Write("Введите число  ");
string numstring  = Console.ReadLine();
double numberStart = double.Parse(numstring);
double numberBack = 1 / numberStart;
Console.Write("Вы получили число  " + numberBack);