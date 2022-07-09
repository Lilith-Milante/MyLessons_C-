//Напишите программу, которая по заданному номеру четверти показывает диапазон возможных координат точек в этой четверти (x и y)

int Prompt(string message)
{
    Console.Write(message);
    string param = Console.ReadLine();
    return int.Parse(param);
}

int number = Prompt("Введите номер четверти: ");

if (number == 1) Console.WriteLine("Диапазон координат: x > 0 и y > 0");
if (number == 2) Console.WriteLine("Диапазон координат: x < 0 и y > 0");
if (number == 3) Console.WriteLine("Диапазон координат: x < 0 и y < 0");
if (number == 4) Console.WriteLine("Диапазон координат: x > 0 и y < 0");

if (number < 1 || number > 4) Console.WriteLine("Введен неверный номер четверти");