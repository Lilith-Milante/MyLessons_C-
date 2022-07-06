//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет

Console.WriteLine("Введите число:  ");
string Num = Console.ReadLine();
int num = int.Parse(Num);

if (num < 100)
{
    Console.WriteLine("Третьей цифры не существует");
}
else
{
    while (num > 1000)
    {
     num = num / 10;   
    }
    num = num % 10;
    Console.WriteLine("Третья цифра числа: " + num);
}