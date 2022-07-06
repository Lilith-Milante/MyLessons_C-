// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным

Console.WriteLine("Введите номер дня недели: ");
string Num = Console.ReadLine();
int day = int.Parse(Num);

if (day > 7 || day < 1)
{
    Console.WriteLine("Дня недели с таким номером не существует (!)");
}
else
{
    if (day == 6 || day  == 7) Console.WriteLine("Это выходной!");
    else Console.WriteLine("Это не выходной");
}