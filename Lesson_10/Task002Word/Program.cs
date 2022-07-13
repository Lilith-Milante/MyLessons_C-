/*В некотором машинном алфавите имеются четыре буквы «а», «и», «с» и «в». Покажите все слова, состоящие из n букв, которые можно построить из букв этого алфавита.
n = 2 -> аа, ии, сс, вв, аи, иа, ис, си, ас, са, 
ав, ва, ви, ив, св, вс*/

int Prompt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int numberN = Prompt("Введите n: ");

string[] Alphabet = new string{ "а", "и", "с", "в" };

void PrintWord(string[] array, string pref, int count = 4)
{
    if (count == 0)
    {
        Console.WriteLine(pref);
        return;
    }
    for (int i = 0; i < 4; i++)
    {
        PrintWord(array, pref + pref[i], count - 1);
    }
}

PrintWord(Alphabet, " ", 3);