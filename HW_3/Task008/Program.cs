//Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y)

int Prompt(string message)
{
    System.Console.Write(message);
    string param = Console.ReadLine();
    return int.Parse(param);
}

int number = Prompt("Введите номер четверти: ");

if (number == 1) System.Console.WriteLine("Диапазаон координат: x > 0 и y > 0");
if (number == 2) System.Console.WriteLine("Диапазаон координат: x < 0 и y > 0");
if (number == 3) System.Console.WriteLine("Диапазаон координат: x < 0 и y < 0");
if (number == 4) System.Console.WriteLine("Диапазаон координат: x > 0 и y < 0");
if (number < 1 || number > 4) System.Console.WriteLine("Введен неверный номер четверти.");


