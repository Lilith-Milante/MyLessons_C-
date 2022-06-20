//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве

int Prompt(string message)
{
    Console.WriteLine(message);
    string number = Console.ReadLine();
    int numberInt = int.Parse(number);
    return numberInt;
}

int X1 = Prompt("Введите X первой точки ");
int Y1 = Prompt("Введите Y первой точки ");
int Z1 = Prompt("Введите Z первой точки ");

int X2 = Prompt("Введите X второй точки ");
int Y2 = Prompt("Введите Y второй точки ");
int Z2 = Prompt("Введите Z второй точки ");

double Sqr(double num)
{
    return num * num;
}

double S = Sqr(X1 - X2) + Sqr(Y1 - Y2) + Sqr(Z1 - Z2);
double result = Math.Sqrt(S);

Console.WriteLine($"Расстояние между точками {result:F2}");
