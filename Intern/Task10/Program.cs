// 10. Показать вторую цифру трёхзначного числа

int a10 = new Random().Next(100, 1000);

int SecondNum(int a)
{
    return (a % 100) / 10;
}
Console.WriteLine($"Вторая цифра числа {a10}: {SecondNum(a10)}");

