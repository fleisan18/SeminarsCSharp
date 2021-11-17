// 2. Даны два числа. Показать большее и меньшее число

int a2 = new Random().Next(-50, 50);
int b2 = new Random().Next(-50, 50);
int Bigger(int a, int b)
{
    if (a < b) return b;
    else return a;
}

int Smaller(int a, int b)
{
    if (a < b)
    {
        return a;
    }
    return b;
}
int max = Bigger(a2, b2);
int min = Smaller(a2, b2);
Console.WriteLine($"Большее: {max}, Меньшее: {min}");
