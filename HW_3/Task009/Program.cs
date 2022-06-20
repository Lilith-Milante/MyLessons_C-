// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

int Prompt(string message)
{
    System.Console.Write(message);
    string param = Console.ReadLine();
    return int.Parse(param);
}

int x1 = Prompt("Введите x первой точки ");
int y1 = Prompt("Введите y первой точки ");

int x2 = Prompt("Введите x второй точки ");
int y2 = Prompt("Введите y второй точки ");

double result = Math.Sqrt((x1 - x2)*(x1 - x2) + (y1 - y2)*(y1 - y2));
System.Console.WriteLine("Расстояние между точками" + result);

