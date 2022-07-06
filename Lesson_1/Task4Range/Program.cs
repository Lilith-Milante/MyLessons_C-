/*Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N
N = 9; 8,6,4,2*/

Console.Write("Введите число  ");
string numstring  = Console.ReadLine();
int numberN = int.Parse(numstring);
int numberI = 1;

while (numberN > numberI)
{
   if (numberI % 2 == 0)
   {
    Console.WriteLine("  " + numberI);
   }
   numberI = numberI + 1;
}