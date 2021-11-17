// 11. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

int a11 = new Random().Next(10, 100);

int MaxNumber(int a)
{
    int b = a / 10;
    int c = a % 10;
    if (b > c) return b;
    else return c;
}

Console.WriteLine($"Максимальная цифра числа {a11} = {MaxNumber(a11)}");
