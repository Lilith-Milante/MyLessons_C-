// Вычислить a^n

int PowerFor(int a, int n) // с циклом
{
    int result = 1;
    for (int i = 1; i <= n; i++) result *= a;
    return result;
}
int PowerRec(int a, int n) // с рекурсией
{
    if (n == 0) return 1;
    else return PowerRec(a, n - 1) * a;
}

Console.WriteLine(PowerFor(2, 10));
Console.WriteLine(PowerRec(2, 10));