// 4. Найти максимальное из трех чисел

int a4 = new Random().Next(-50, 50);
int b4 = new Random().Next(-50, 50);
int c4 = new Random().Next(-50, 50);
Console.WriteLine($"a={a4}, b={b4}, c={c4}");

int Max(int a, int b, int c)
{
    int result = a;
    if (b > result) result = b;
    if (c > result) result = c;
    return result;
}
int max = Max(a4, b4, c4);
Console.WriteLine($"Максимальное число = {max}");


